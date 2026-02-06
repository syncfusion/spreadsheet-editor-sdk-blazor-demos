# Syncfusion® Blazor Spreadsheet Editor SDK Demos 
This repository contains the demos of Syncfusion® Blazor [**Spreadsheet**](https://www.syncfusion.com/spreadsheet-editor-sdk/blazor-spreadsheet-editor) component samples.
The following topics can help you to use the Syncfusion Blazor Spreadsheet component and run this application in your local.
* [Requirements to run the demo](#requirements-to-run-the-demo)
* [How to run the demo](#how-to-run-the-demo)
* [Spreadsheet Component Catalog](#spreadsheet-component-catalog)
* [License](#license)
* [Support and feedback](#support-and-feedback)
## Requirements to run the demo
* [System requirements](https://help.syncfusion.com/document-processing/system-requirements)
* [NET 8 WebAssembly Workload / NET 9 WebAssembly Workload](https://learn.microsoft.com/en-us/aspnet/core/blazor/webassembly-build-tools-and-aot?view=aspnetcore-8.0#net-webassembly-build-tools) (For [Spreadsheet Component](https://help.syncfusion.com/document-processing/excel/spreadsheet/blazor/getting-started))
* Nodejs Version : [10.24.* or above](https://nodejs.org/download/release/v8.1.0/)
## How to run the demo
Clone the repository. This repository contains Blazor Server demos and Blazor WASM demos project and solution files for .NET 8 and .NET 9. This repository has Common, Blazor Server Demos, and Blazor WASM Demos folders.
* `Blazor-Server-Demos` folder has solution and project files to run Blazor server demos.
* `Blazor-WASM-Demos` folder has solution and project files to run Blazor WebAssembly demos.
* The Common folder contains all the common files (i.e., samples, static web assets, resources) which are applicable for both Blazor Server demos and Blazor WASM demos.
### Run the demo using .NET CLI
* Open the command prompt from the demo's directory.
* Run the demo using the following command.
   
   To run .NET 8 Blazor Server Demos project
   > `dotnet run --project Blazor-Server-Demos/Blazor_Server_Demos_NET8.csproj`
   To run .NET 9 Blazor Server Demos project
   > `dotnet run --project Blazor-Server-Demos/Blazor_Server_Demos_NET9.csproj`
   To run .NET 8 Blazor WASM Demos project
   > `dotnet run --project Blazor-WASM-Demos/Blazor_WASM_Demos_NET8.csproj`
   To run .NET 9 Blazor WASM Demos project
   > `dotnet run --project Blazor-WASM-Demos/Blazor_WASM_Demos_NET9.csproj`
### Run the demo using Visual Studio
* Open the solution file using Visual Studio.
* Press `Ctrl + F5` to run the demo.
### Run the demo using Visual Studio code
* Open the Visual Studio code from the demos directory where the project file is present.
    > Ensure the [C# for Visual Studio Code](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp) extension is installed in your Visual Studio code before running the Blazor demos.
* Press `Ctrl + F5` to run the demo.
## Spreadsheet Component Catalog
This repository focuses on Spreadsheet component with comprehensive examples showcasing various features and functionalities.
### Spreadsheet Component (Preview)
The **Syncfusion® Blazor Spreadsheet** component enables users to create, edit, and manage Excel-like spreadsheets directly within web applications. It offers a comprehensive suite of features for data manipulation, visualization, and interaction.

**Key Features:**
- **Editing**: Direct cell editing and formula bar support for dynamic data entry.
- **Selection**: Flexible selection of cells, rows, columns, and ranges using mouse or keyboard.
- **Open and Save**: Load and save Excel files (.xlsx, .xls) via Base64 strings or local file operations.
- **Clipboard**: Full support for cut, copy, and paste, including interoperability with Excel and Google Sheets.
- **Formulas**: Built-in calculation engine with pre-defined formulas, named ranges, and auto/manual calculation modes.
- **Cell Formatting**: Rich formatting options including fonts, colors, borders, alignment, and text styles.
- **Sorting**: Sort data in ascending or descending order with single-column support.
- **Filtering**: Apply text, number, date, and custom filters to refine data views.
- **Hyperlink**: Insert links to external URLs or internal cell references across sheets.
- **Undo/Redo**: Track and revert up to 25 actions with undo and redo functionality.
- **Worksheet Management**: Insert, delete, rename, hide/unhide, move, and duplicate sheets.
- **Protection**: Secure sheets and workbooks with password protection and customizable permissions.
- **Context Menu**: Right-click menus for quick access to common operations like insert, delete, sort, and filter.
- **Cell Range Management**: Advanced operations like auto-fill, wrap text, and clearing content, formats, or links.
**Accessibility**: Keyboard navigation, ARIA attributes, and screen reader compatibility for inclusive usage.

**Available Samples:**
- [Default Functionalities](https://document.syncfusion.com/demos/spreadsheet-editor/blazor-server/spreadsheet/overview)
- [Hyperlink](https://document.syncfusion.com/demos/spreadsheet-editor/blazor-server/spreadsheet/hyperlink)
- [Formula](https://document.syncfusion.com/demos/spreadsheet-editor/blazor-server/spreadsheet/formula)
- [Protection](https://document.syncfusion.com/demos/spreadsheet-editor/blazor-server/spreadsheet/protection)
- [Sorting](https://document.syncfusion.com/demos/spreadsheet-editor/blazor-server/spreadsheet/sorting)
- [Filtering](https://document.syncfusion.com/demos/spreadsheet-editor/blazor-server/spreadsheet/filtering)
- [Cell Formatting](https://document.syncfusion.com/demos/spreadsheet-editor/blazor-server/spreadsheet/cell-formatting)

**Documentation:** [Spreadsheet Documentation](https://help.syncfusion.com/document-processing/excel/spreadsheet/blazor/getting-started-webapp)
> **Note:** Spreadsheet is currently in preview mode.
## Getting Started
### Spreadsheet
To get started with the Spreadsheet component:
1. Install the Syncfusion.Blazor.Spreadsheet NuGet package
2. Configure the Spreadsheet in your application
3. Add the Spreadsheet component to your Blazor page
```csharp
@page "/spreadsheet"
@using Syncfusion.Blazor.Spreadsheet
<SfSpreadsheet @ref=SpreadsheetInstance DataSource="@DocumentPath">
    <SpreadsheetRibbon></SpreadsheetRibbon>
</SfSpreadsheet>
```
## License
Syncfusion Blazor components is available under the Syncfusion Essential Studio program, and can be licensed either under the Syncfusion Community License Program or the Syncfusion commercial license.
To be qualified for the Syncfusion Community License Program, you must have gross revenue of less than one (1) million U.S. dollars (USD 1,000,000.00) per year and have less than five (5) developers in your organization, and agree to be bound by Syncfusion's terms and conditions.
Customers who do not qualify for the community license can contact sales@syncfusion.com for commercial licensing options.
You may not use this product without first purchasing a Community License or a Commercial License, as well as agreeing to and complying with Syncfusion's license terms and conditions.
The Syncfusion license that contains the terms and conditions can be found at
[https://www.syncfusion.com/content/downloads/syncfusion_license.pdf](https://www.syncfusion.com/content/downloads/syncfusion_license.pdf)
## Support and feedback
* For any other queries, reach the [Syncfusion support team](https://support.syncfusion.com/) or post the queries through the [community forums](https://www.syncfusion.com/forums?utm_source=github&utm_medium=listing&utm_campaign=blazor-samples).
* To renew the subscription, click [here](https://www.syncfusion.com/sales/products?utm_source=github&utm_medium=listing&utm_campaign=blazor-spreadsheet-samples) or contact our sales team at <salessupport@syncfusion.com>.
* Don't see what you need? Please request it in our [feedback portal](https://www.syncfusion.com/feedback/blazor-components).
## See also
* [Blazor Spreadsheet Documentation](https://help.syncfusion.com/document-processing/excel/spreadsheet/blazor/getting-started-webapp)
* [Blazor Spreadsheet Live Demos](https://document.syncfusion.com/demos/spreadsheet-editor/blazor-server/spreadsheet/overview)
* [Syncfusion Blazor Components](https://www.syncfusion.com/blazor-components)
* [Blazor Documentation](https://blazor.syncfusion.com/documentation/introduction)
* [Blazor Smart/AI Samples](https://github.com/syncfusion/smart-ai-samples)