# AutoCalc - WebView2-Based Automated Calculation Tool

AutoCalc is a modern calculation tool application built using C# WinForms and WebView2 technology. It integrates Web frontend technology with Windows desktop applications, providing a smooth user interface and powerful calculation capabilities.

## Features

- **Modern Interface**: UI built with Web technology, supporting rich interactive experiences
- **High-Performance Rendering**: Based on Microsoft WebView2 engine, providing native-level Web content rendering
- **Lightweight Deployment**: Supports single-file deployment, with resource files automatically extracted
- **Cross-Platform Compatibility**: Supports x86 and x64 system architectures

## System Requirements

- Windows 10/11 or Windows Server 2019+
- .NET Framework 4.6.2 or higher
- Microsoft Edge WebView2 Runtime

## Installation Instructions

1. Download the latest version of the AutoCalc installer
2. Run the installer and follow the wizard to complete the installation
3. Ensure the WebView2 runtime is installed on your system (the installer will automatically detect and prompt for installation if necessary)

## Usage

1. Launch the AutoCalc application
2. Enter calculation expressions in the main interface
3. Click the Calculate button to obtain results
4. Keyboard shortcut operations are supported

## Project Structure

```
AutoCalc/
├── AutoCalc.csproj      # Project configuration file
├── FormMain.cs          # Main window logic
├── FormMain.Designer.cs # Main window design file
├── Program.cs           # Program entry point
├── App.config           # Application configuration
├── wwwroot.zip          # Web resources archive
└── runtimes/            # WebView2 runtime libraries
    ├── win-x64/
    └── win-x86/
```

## Technical Architecture

- **Frontend Framework**: HTML5 + CSS3 + JavaScript
- **Rendering Engine**: Microsoft WebView2
- **UI Framework**: Windows Forms
- **Build Tools**: Fody, MSBuild

## License

This project is open sourced under the MIT License.

## Contribution Guidelines

Contributions via Issues and Pull Requests are welcome to help improve this project.

## Contact Information

- Project Address: https://gitee.com/ext2/autocalc

---

Thank you for using AutoCalc! If you have any questions, please contact us through the project homepage.