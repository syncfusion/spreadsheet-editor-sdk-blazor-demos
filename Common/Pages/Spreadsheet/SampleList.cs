using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDemos;
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        public List<Sample> Spreadsheet { get; set; } = new List<Sample>
        {
           new Sample
            {
                Name = "Overview",
                Category = "Spreadsheet",
                Directory = "Spreadsheet/Spreadsheet",
                Url = "spreadsheet/overview",
                FileName = "Overview.razor",
                MetaTitle = "Blazor Spreadsheet Example | Spreadsheet Overview | Syncfusion Demos",
                HeaderText = "Blazor Spreadsheet Example - Overview",
                MetaDescription = "This Blazor Spreadsheet example demonstrates is an overview of the Blazor Spreadsheet features with its performance metrics calculated for huge volume of data.",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"This sample provides an overview of the Blazor Spreadsheet component, highlighting its features for data entry, analysis, and visualization." }
             },
           new Sample
            {
                Name = "Hyperlink",
                Category = "Spreadsheet",
                Directory = "Spreadsheet/Spreadsheet",
                Url = "spreadsheet/hyperlink",
                FileName = "Hyperlink.razor",
                MetaTitle = "Blazor Spreadsheet Hyperlink | Interactive Links | Syncfusion",
                HeaderText = "Blazor Spreadsheet Example - Hyperlink",
                MetaDescription = "This demo shows how to create, edit and manage hyperlinks in a worksheet and clickable links to websites, email addresses/other cells within your spreadsheet.",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"This sample illustrates the use of hyperlinks in the Blazor Spreadsheet, enabling quick navigation between sheets and external links." }
             },
           new Sample
            {
                Name = "Formula",
                Category = "Spreadsheet",
                Directory = "Spreadsheet/Spreadsheet",
                Url = "spreadsheet/formula",
                FileName = "Formula.razor",
                MetaTitle = "Blazor Spreadsheet Example | Spreadsheet Formula | Syncfusion Demos",
                HeaderText = "Blazor Spreadsheet Example - Formula",
                MetaDescription = "Blazor Spreadsheet offers diverse function, formulas for sophisticated data analysis. Perform complex calculation, seamless computation with worksheet features.",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"This sample showcases the formula capabilities of the Blazor Spreadsheet component, enabling you to perform complex calculations and analysis directly within spreadsheets." }
             },
            new Sample
            {
                Name = "Sorting",
                Category = "Data Analysis",
                Directory = "Spreadsheet/Spreadsheet",
                Url = "spreadsheet/sorting",
                FileName = "Sorting.razor",
                MetaTitle = "Blazor Spreadsheet Example | Spreadsheet sorting | Syncfusion Demos",
                HeaderText = "Blazor Spreadsheet Example - Sorting",
                MetaDescription = "Learn how to sort data efficiently in Blazor Spreadsheet to improve organization and data analysis speed. Optimize workflow with powerful sorting capabilities.",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"This sample demonstrates the sorting capabilities of the Blazor Spreadsheet component, allowing you to organize data by attributes." }
             },

           new Sample
            {
                Name = "Filtering",
                Category = "Data Analysis",
                Directory = "Spreadsheet/Spreadsheet",
                Url = "spreadsheet/filtering",
                FileName = "Filtering.razor",
                MetaTitle = "Blazor Spreadsheet Example | Spreadsheet filtering | Syncfusion Demos",
                HeaderText = "Blazor Spreadsheet Example - Filtering",
                MetaDescription = "Discover the filtering capabilities of Blazor Spreadsheet, allowing users to focus on essential data while hiding unnecessary information for enhanced analysis.",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"This sample demonstrates the Blazor Spreadsheet component's filtering capabilities, which help sort and search through large sets of data efficiently." }
             },
           new Sample
            {
                Name = "Protection",
                Category = "Spreadsheet",
                Directory = "Spreadsheet/Spreadsheet",
                Url = "spreadsheet/protection",
                FileName = "Protection.razor",
                MetaTitle = "Blazor Spreadsheet Example | Protection | Syncfusion Demos",
                HeaderText = "Blazor Spreadsheet Example - Protection",
                MetaDescription = "Learn how to secure spreadsheet data by setting permission and access restrictions. Implement protection measures to maintain data integrity, enhance security.",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"This sample demonstrates the protection features of the Blazor Spreadsheet, allowing you to secure worksheet data and structure against unauthorized modifications." }
             },
            new Sample
            {
                Name = "Cell Formatting",
                Category = "Formatting",
                Directory = "Spreadsheet/Spreadsheet",
                Url = "spreadsheet/cell-formatting",
                FileName = "CellFormatting.razor",
                MetaTitle = "Blazor Spreadsheet Cell Formatting | Styling Cells | Syncfusion",
                HeaderText = "Blazor Spreadsheet Example - Cell Formatting",
                MetaDescription = "This demo shows applying various formatting options to cells including fonts, colors, borders, number formats for better data visualization and presentation.",
                Type = SampleType.None,
                NotificationDescription = new string[] { @"This sample demonstrates the cell formatting capabilities of the Syncfusion Blazor Spreadsheet component. It shows how to apply custom styles and formats to different cells in a spreadsheet." }
             },
        };
    }
}