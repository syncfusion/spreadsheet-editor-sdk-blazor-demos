#region Copyright Syncfusion® Inc. 2001-2026.
// Copyright Syncfusion® Inc. 2001-2026. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlazorDemos.Shared
{
    /// <summary>
    /// A component to dynamically load CSS styles and scripts based on the current sample.
    /// </summary>
    public class DynamicResourceLoader : ComponentBase
    {
        [Inject]
        protected NavigationManager? UriHelper { get; set; }

        [Inject]
        protected SampleService? SampleService { get; set; }

        // Defines the structure for holding resource information (CSS directory and JS files) for a component.
        private class ComponentSamplesResources
        {
            public string? CssDirectory { get; set; }
            public string[]? JsFiles { get; set; }
        }

        // A static dictionary that maps component names (keys) to their required resources (ComponentSamplesResources objects).
        // This allows for efficient lookup of CSS and JS dependencies for each component.
        private readonly Dictionary<string, ComponentSamplesResources> CompSamplesResourcesMappings = new()
        {
            {"spreadsheet", new() { CssDirectory= "spreadsheet", JsFiles= new[] {"syncfusion-blazor-spreadsheet" } } },
            {"excel", new() { CssDirectory= "excel", JsFiles= new[] {"sf-grid", "sf-dropdownlist" } } }
        };
        private readonly Dictionary<string, string> StaticAssetScriptPathMappings = new()
        {
            { "syncfusion-blazor-spreadsheet", "spreadsheet" },
        };
        private string GetStaticAssetScriptPath(string jsFile)
        {
            return $"_content/syncfusion.blazor.{StaticAssetScriptPathMappings.GetValueOrDefault(jsFile)}/scripts/";
        }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
#if !WASM
            builder.AddMarkupContent(0, GetResourcesMarkup(true));
#else
                if (!SampleService.IsScriptReinitialized)
                {
                    builder.AddMarkupContent(0, GetResourcesMarkup(false));
                    SampleService.IsScriptReinitialized = true;
                }
                else
                {
                    builder.AddMarkupContent(0, GetResourcesMarkup(true));
                }
#endif
        }

        private string GetResourcesMarkup(bool isAddScript)
        {
            var theme = SampleUtils.GetThemeName(UriHelper.Uri);
            if (SampleService != null && SampleService.IsThemeChangeOnBrowserNav)
            {
                theme = SampleService.BrowserNavTheme;
                SampleService.IsThemeChangeOnBrowserNav = false;
            }
            StringBuilder sb = new StringBuilder();
#if RELEASE || (!DEBUG && STAGING)
        var minExtension = ".min";
#else
        var minExtension = "";
#endif
#if !STAGING && RELEASE
            // Use CDN links for Release builds
            var scriptPath = "https://cdn.syncfusion.com/blazor/32.1.19/";
            var stylePath = "https://cdn.syncfusion.com/blazor/documentprocessing-sb/spreadsheet/styles/32.1.19/";
            var overallStylePath = "https://cdn.syncfusion.com/blazor/32.1.19/styles/";
            var sbSamplesJsPath = "https://cdn.syncfusion.com/blazor/documentprocessing-sb/spreadsheet/scripts/32.1.19/";
            var sbCommonCssPath = stylePath;
            var sbDiagramCssPath = $"{stylePath}common/";
#else
            var scriptPath = "";
            var stylePath = $"{SampleService.AssetsPath}styles/component-samples/";
            var overallStylePath = "_content/Syncfusion.Blazor.Themes/";
            var sbSamplesJsPath = $"{SampleService.AssetsPath}scripts/";
            var sbCommonCssPath = $"{SampleService.AssetsPath}styles/";
            var sbDiagramCssPath = sbCommonCssPath; 
#endif
            var demoPageCompsScript = new string[] { "sf-tab", "sf-tooltip", "sf-toast" };
            if (SampleUtils.IsHomePage(UriHelper))
            {
#if !STAGING && RELEASE
                sb.AppendLine($"<script src=\"{scriptPath}sf-drop-down-button.min.js\"></script>");
#else
                sb.AppendLine($"<script src=\"_content/syncfusion.blazor.splitbuttons/scripts/sf-drop-down-button.min.js\"></script>");
#endif
            }
            else 
            {
                if(theme != "fluent2")
                {
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"{stylePath}demo-page-comps/{theme}.min.css\" />");
                }
                // Get the current component page details
                var compKey = GetComponentKey()?.ToLower();
                if(compKey == null)
                {
                    return sb.ToString();
                }
                // Retrieve the two values (e.g., CssDirectory and JsFiles) based on compName
                ComponentSamplesResources resources = CompSamplesResourcesMappings.GetValueOrDefault(compKey);
                // Guard against null resources to prevent NullReferenceException
                if (resources == null)
                {
                    resources = new ComponentSamplesResources();
                }
                // sf-tab, sf-toast, and sf-tooltip - Since these resources are loaded commonly in every page for the SB's common layout, they are not loaded during comp to comp navigation.
                resources.JsFiles = resources.JsFiles != null ? resources.JsFiles.Except(demoPageCompsScript).ToArray() : null;
                if (SampleService?.SampleName == null)
                {
                    if (!string.IsNullOrEmpty(resources.CssDirectory))
                    {
                        if (resources.CssDirectory == "overall")
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{overallStylePath}{theme}.css\" />");
                        }
                        else
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{stylePath}{resources.CssDirectory}/{theme}.min.css\" />");
                        }
                    }
                    if (resources.JsFiles != null && isAddScript)
                    {
                        foreach (var file in resources.JsFiles)
                        {
#if DEBUG || STAGING
                            scriptPath = GetStaticAssetScriptPath(file);
                            if(file == "syncfusion-blazor")
                            {
                                scriptPath = "_content/Syncfusion.Blazor.Core/scripts/";
                            }
#endif
                            var jsPath = file == "syncfusion-blazor" ? $"{scriptPath}syncfusion-blazor.min.js" : $"{scriptPath}{file}.min.js";
                            sb.AppendLine($"<script src=\"{jsPath}\"></script>");
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(resources.CssDirectory))
                    {
                        if (resources.CssDirectory == "overall")
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{overallStylePath}{theme}.css\" />");
                        }
                        else if (resources.JsFiles == null)
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{stylePath}{resources.CssDirectory}/{theme}.min.css\" onload=\"onCompStylesLoaded(false)\" />");
                        }
                        else
                        {
                            sb.AppendLine($"<link rel=\"stylesheet\" href=\"{stylePath}{resources.CssDirectory}/{theme}.min.css\" onload=\"onCompStylesLoaded(true)\" />");
                        }
                    }
                    if (resources.JsFiles != null && isAddScript == true)
                    {
                        foreach (var file in resources.JsFiles)
                        {
#if DEBUG || STAGING
                            scriptPath = GetStaticAssetScriptPath(file);
                            if (file == "syncfusion-blazor")
                            {
                                scriptPath = "_content/Syncfusion.Blazor.Core/scripts/";
                            }
#endif
                            var jsPath = file == "syncfusion-blazor" ? $"{scriptPath}syncfusion-blazor.min.js" : $"{scriptPath}{file}.min.js";
                            if (resources.JsFiles[resources.JsFiles.Length - 1] == file)
                            {
                                sb.AppendLine($"<script src=\"{jsPath}\" onload=\"onCompScriptsLoaded()\"></script>");
                            }
                            else
                            {
                                sb.AppendLine($"<script src=\"{jsPath}\"></script>");
                            }
                        }
                    }
                }
                if (compKey == "image-editor")
                {
                    sb.AppendLine($"<script src=\"${sbSamplesJsPath}image-editor{minExtension}.js\"></script>");
                }
                if (compKey == "ribbon")
                {
                    sb.AppendLine($"<script src=\"${sbSamplesJsPath}ribbon{minExtension}.js\"></script>");
                }
                if (compKey == "rich-text-editor")
                {
                    sb.AppendLine($"<script src=\"${sbSamplesJsPath}richtexteditor{minExtension}.js\"></script>");
                }
                if (compKey == "speech-to-text")
                {
                    sb.AppendLine($"<script src=\"${sbSamplesJsPath}speechtotext{minExtension}.js\"></script>");
                }
                if (compKey == "diagram" || compKey == "ai-diagram")
                {
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"{sbDiagramCssPath}diagram/syncfusion-blazor-icons{minExtension}.css\" />");
                }
                if (theme.Contains("dark") || theme.Contains("fluent2-highcontrast") || theme.Contains("highcontrast"))
                {
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"{sbCommonCssPath}common/highcontrast{minExtension}.css\" />");
                    sb.AppendLine($"<link rel=\"stylesheet\" href=\"{sbCommonCssPath}common/dark-theme{minExtension}.css\" />");
                }
                // Add sf-tab, sf-toast, and sf-tooltip for the SB's common layout if syncfusion-blazor.js is not already being loaded.
                if (resources.JsFiles == null || !resources.JsFiles.Contains("syncfusion-blazor"))
                {
#if DEBUG || STAGING
                    sb.AppendLine("<script src=\"_content/syncfusion.blazor.navigations/scripts/sf-tab.min.js\"></script>");
                    sb.AppendLine("<script src=\"_content/syncfusion.blazor.popups/scripts/sf-tooltip.min.js\"></script>");
                    sb.AppendLine("<script src=\"_content/syncfusion.blazor.notifications/scripts/sf-toast.min.js\"></script>");
#else
                    sb.AppendLine($"<script src=\"{scriptPath}sf-tab.min.js\"></script>");
                    sb.AppendLine($"<script src=\"{scriptPath}sf-tooltip.min.js\"></script>");
                    sb.AppendLine($"<script src=\"{scriptPath}sf-toast.min.js\"></script>");
#endif
                }
            }
            return sb.ToString();
        }

        private string GetComponentKey()
        {
            string? demoPath;
            // Url is often like "Component/SampleName" e.g., "datagrid/overview"
            // First try to use SampleName if available, otherwise fall back to SampleInfo?.Url
            if (!string.IsNullOrEmpty(SampleService?.SampleName))
            {
                demoPath = SampleService.SampleName;
            }
            else
            {
                demoPath = SampleService?.SampleInfo?.Url;
            }

            // Guard against null demoPath to prevent NullReferenceException
            if (string.IsNullOrEmpty(demoPath))
            {
                return null!;
            }

            List<string> specialCaseComponents = new List<string>
                {
                    "split-button",
                    "button-group",
                    "dropdown-menu",
                    "progress-button",
                    "toggle-switch-button",
                    "checkbox",
                    "radio-button"
                };
            foreach (var component in specialCaseComponents)
            {
                if (demoPath.Contains("buttons/" + component))
                {
                    return component;
                }
            }
            var componentName = demoPath?.Split('/')[0];
            return componentName;
        }

        public void Refresh()
        {
            StateHasChanged();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            // Assign reference to sample service for outside usage.
            if (firstRender && SampleService != null)
            {
                SampleService.DynamicResourceLoader = this;
            }
        }
    }
}