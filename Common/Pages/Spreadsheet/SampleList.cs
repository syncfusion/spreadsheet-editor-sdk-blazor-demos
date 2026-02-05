#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.Generic;
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
            new Sample
            {
                Name = "Number Formatting",
                Category = "Formatting",
                Directory = "Spreadsheet/Spreadsheet",
                Url = "spreadsheet/number-formatting",
                FileName = "NumberFormatting.razor",
                MetaTitle = "Blazor Spreadsheet Number Formatting | Number Formats | Syncfusion",
                HeaderText = "Blazor Spreadsheet Example - Number Formatting",
                MetaDescription = "This demo shows how to apply various number formatting options in the Syncfusion Blazor Spreadsheet component, including currency, percentage, decimal places, and date formats for better data presentation.",
                Type = SampleType.New,
                NotificationDescription = new string[] { @"This sample demonstrates number formatting capabilities in the Syncfusion Blazor Spreadsheet component. It illustrates how to format numeric values as currency, percentages, dates, and custom number formats to enhance readability and visualization." }
             },
            new Sample
            {
                Name = "Merge Cells",
                Category = "Data Analysis",
                Directory = "Spreadsheet/Spreadsheet",
                Url = "spreadsheet/merged-cells",
                FileName = "MergedCells.razor",
                MetaTitle = "Blazor Spreadsheet Merge Cells | Merge and Unmerge | Syncfusion",
                HeaderText = "Blazor Spreadsheet Example -  Merge Cells",
                MetaDescription = "This demo shows how to merge and unmerge cells in the Syncfusion Blazor Spreadsheet component to create headers, group data, and improve layout for better presentation.",
                Type = SampleType.New,
                NotificationDescription = new string[] { @"This sample demonstrates the merge cell feature in the Syncfusion Blazor Spreadsheet component. It illustrates how to combine multiple cells into one for creating titles, organizing data, and enhancing spreadsheet structure." }
             },
            new Sample
            {
                Name = "Cell Borders",
                Category = "Formatting",
                Directory = "Spreadsheet/Spreadsheet",
                Url = "spreadsheet/cell-borders",
                FileName = "CellBorders.razor",
                MetaTitle = "Blazor Spreadsheet Cell Borders | Apply Borders | Syncfusion",
                HeaderText = "Blazor Spreadsheet Example -  Cell Borders",
                MetaDescription = "This demo shows how to apply different border styles to cells in the Syncfusion Blazor Spreadsheet component, including solid, dashed, and custom borders for better data separation and presentation.",
                Type = SampleType.New,
                NotificationDescription = new string[] { @"This sample demonstrates the cell border feature in the Syncfusion Blazor Spreadsheet component. It illustrates how to add, customize, and remove borders around cells to organize data and improve visual clarity." }
             },
        };
    }
}