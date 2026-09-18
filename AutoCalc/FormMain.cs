using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCalc
{
    public partial class FormMain : Form
    {
        private const string VirtualHost = "autocalc.example";
        private const string ZipResourceName = "AutoCalc.wwwroot.zip";
        private string _tempWebRoot;

        public FormMain()
        {
            InitializeComponent();
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            //string version = CoreWebView2Environment.GetAvailableBrowserVersionString();

            // 指定一个系统临时目录下的专属文件夹
            string userDataFolder = Path.Combine(Path.GetTempPath(), "AutoCalc_UserData");
            // 创建自定义环境
            var env = await CoreWebView2Environment.CreateAsync(
                browserExecutableFolder: null,
                userDataFolder: userDataFolder,
                options: null
            );

            await webView.EnsureCoreWebView2Async(env);

            // 清理右键菜单，只保留复制功能
            webView.CoreWebView2.ContextMenuRequested += (_, args) =>
            {
                for (int i = args.MenuItems.Count - 1; i >= 0; i--)
                {
                    if (args.MenuItems[i].Name != "copy")
                    {
                        args.MenuItems.RemoveAt(i);
                    }
                }
            };
            // 禁用各种快捷键
            webView.CoreWebView2.Settings.AreBrowserAcceleratorKeysEnabled = false;

            // 准备临时目录
            _tempWebRoot = Path.Combine(Path.GetTempPath(), "AutoCalc_wwwroot");
            if (Directory.Exists(_tempWebRoot))
            {
                Directory.Delete(_tempWebRoot, true); // 清理旧文件，避免残留
            }
            Directory.CreateDirectory(_tempWebRoot);

            // 从嵌入资源读取 zip 流，并解压到临时目录
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream zipStream = assembly.GetManifestResourceStream(ZipResourceName))
            {
                if (zipStream == null)
                {
                    throw new InvalidOperationException("资源文件出错。");
                }

                // 使用 ZipArchive 从流中解压
                using (ZipArchive archive = new ZipArchive(zipStream, ZipArchiveMode.Read))
                {
                    archive.ExtractToDirectory(_tempWebRoot);
                }
            }

            // 映射虚拟域名到解压后的临时目录
            webView.CoreWebView2.SetVirtualHostNameToFolderMapping(
                VirtualHost,
                _tempWebRoot,
                CoreWebView2HostResourceAccessKind.Allow
            );

            // 导航
            webView.CoreWebView2.Navigate($"https://{VirtualHost}/index.html");
        }
    }
}
