# Creating a .NET MAUI Doughnut Chart with Drill Down for Workforce Distribution Across Industries
This sample shows how to create a [.MAUI Doughnut Chart](https://www.syncfusion.com/maui-controls/maui-circular-charts/chart-types/maui-doughnut-chart) with drill-down functionality to visualize workforce distribution across various industries.

**Drill-down support** in charts provides the capability to explore data at varying levels of detail by interacting with specific chart elements, such as segments in a doughnut chart. This functionality enables navigation from a high-level overview to more detailed data visualizations, enhancing data analysis and presentation. 

## Key features of the Syncfusion .NET MAUI Doughnut chart

### Center View: Adding image into the center view
The [Center view](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.DoughnutSeries.html?tabs=tabid-1#Syncfusion_Maui_Charts_DoughnutSeries_CenterView) in the Syncfusion doughnut chart helps convey additional information about the chart. In this example, we have included an image related to the content in the center view of our doughnut chart. The images were sourced from [Metro Studio](https://www.syncfusion.com/downloads/metrostudio).

### Palette: Making Data Pop with colors
The Syncfusion Circular chart allows for a customized [palette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes) to use distinct colors for each category, making it easier to differentiate between them. Each segment of the doughnut represents an industry with unique colors. This use of color coding helps in quick visual identification and comparison of categories.

### Data Labels
The [LableContext](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.LabelContext.html) property is used to present the data labels in percentage format.

### Legend: A Quick Reference guide
The [legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) in the Syncfusion Doughnut chart provides information about the segments displayed in the circular chart. It lists all the categories with their respective colors as icons, making it easy to interpret the data at a glance without needing to hover over each segment.

### Adding drill-down functionality in Doughnut chart
The drill-down functionality is used to navigate from one chart to another chart when tapping on a segment. This functionality is achieved by using the [SelectionChanging event](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionChanging) in the .NET MAUI Chart. For example, initially, we displayed the distribution of workers categorized by industries in the doughnut chart. When you tap on a particular segment to know more details, it generates a new chart, which provides further detailed information.

The chart below provides a clear visualization of workforce distribution across industries for 2021–2022 using drill down functionality.

### Output

![windows](https://github.com/user-attachments/assets/f7420413-acf0-4a3c-9d03-b4ed09f2ee97)

## Troubleshooting

#### Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For a step-by-step procedure, refer to the [Visualize workforce distribution across various industries blog with drill down]().
