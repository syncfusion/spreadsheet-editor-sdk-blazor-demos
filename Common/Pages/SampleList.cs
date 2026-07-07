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
                Type =  SampleType.None,
                Samples = Spreadsheet,
                ControllerName = "Spreadsheet",
                DemoPath = "spreadsheet/overview",
                IsPreview = false
            });
        }
    }
}
