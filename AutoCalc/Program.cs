using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoCalc
{
    internal static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var resNames = Assembly.GetExecutingAssembly().GetManifestResourceNames();

            string tempDir = Path.Combine(Path.GetTempPath(), "AutoCalc");
            Directory.CreateDirectory(tempDir);
            string arch = Environment.Is64BitProcess ? "win_x64" : "win_x86";
            string dllName = "WebView2Loader.dll";

            // 资源名需要根据你的项目命名空间调整
            string resourceName = $"AutoCalc.runtimes.{arch}.native.{dllName}";

            using (Stream stream = Assembly.GetExecutingAssembly()
                .GetManifestResourceStream(resourceName))
            using (FileStream fs = new FileStream(Path.Combine(tempDir, dllName),
                FileMode.Create, FileAccess.Write))
            {
                stream.CopyTo(fs);
            }

            // 在 EnsureCoreWebView2Async 之前设置
            CoreWebView2Environment.SetLoaderDllFolderPath(tempDir);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
