#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace BlazorDemos
{
    internal partial class SampleConfig
    {
        internal SampleConfig()
        {
            SampleBrowser.SampleList.Add(new SampleList
            {
                Name = "Spreadsheet",
                Category = "Editor",
                Directory = "Spreadsheet",
                Type = SampleType.None,
                Samples = Spreadsheet,
                ControllerName = "Spreadsheet",
                DemoPath = "spreadsheet/overview",
                IsPreview = false
            });
        }
    }
}
