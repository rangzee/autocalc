

# AutoCalc - 基于 WebView2 的自动化计算工具

AutoCalc 是一个使用 C# WinForms 和 WebView2 技术构建的现代化计算工具应用程序。它将 Web 前端技术与 Windows 桌面应用相结合，提供流畅的用户界面和强大的计算功能。

## 功能特点

- **现代化界面**：采用 Web 技术构建的 UI，支持丰富的交互体验
- **高性能渲染**：基于 Microsoft WebView2 引擎，提供原生级别的 Web 内容渲染
- **轻量级部署**：单文件部署支持，资源文件自动解压
- **跨平台兼容**：支持 x86 和 x64 系统架构

## 系统要求

- Windows 10/11 或 Windows Server 2019+
- .NET Framework 4.6.2 或更高版本
- Microsoft Edge WebView2 运行时

## 安装说明

1. 下载最新版本的 AutoCalc 安装包
2. 运行安装程序并按照向导完成安装
3. 确保系统中已安装 WebView2 运行时（安装程序会自动检测并提示安装）

## 使用方法

1. 启动 AutoCalc 应用程序
2. 在主界面中输入计算表达式
3. 点击计算按钮获取结果
4. 支持键盘快捷键操作

## 项目结构

```
AutoCalc/
├── AutoCalc.csproj      # 项目配置文件
├── FormMain.cs          # 主窗口逻辑
├── FormMain.Designer.cs # 主窗口设计文件
├── Program.cs           # 程序入口点
├── App.config           # 应用程序配置
├── wwwroot.zip          # Web 资源压缩包
└── runtimes/            # WebView2 运行时库
    ├── win-x64/
    └── win-x86/
```

## 技术架构

- **前端框架**：HTML5 + CSS3 + JavaScript
- **渲染引擎**：Microsoft WebView2
- **UI 框架**：Windows Forms
- **构建工具**：Fody、MSBuild

## 许可证

本项目采用 MIT 许可证开源。

## 贡献指南

欢迎提交 Issue 和 Pull Request 来帮助改进本项目。

## 联系方式

- 项目地址：https://gitee.com/ext2/autocalc

---

感谢使用 AutoCalc！如有任何问题，请通过项目主页联系我们。