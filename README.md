# Creating a .NET MAUI Drill-Down Chart to Display Workforce Distribution by Industry in the U.S.
This sample shows how to create a MAUI Drill-Down Chart to visualize workforce distribution across various industries in the U.S for 2023.

**Drill-down support** 

Drill-down support in charts allows users to explore data at different levels of detail by interacting with specific chart elements, such as segments in a bar chart. This functionality facilitates navigation from a high-level overview to more detailed data visualizations, enhancing data analysis and presentation. In our scenario, a bar chart is initially displayed. By clicking on a segment, its details are shown in a radial bar chart. To achieve the Drill down view, we can use the use case of illustrating workforce distribution across industries in the United States.

## Key features of the Syncfusion .NET MAUI Doughnut chart

### Center View: Adding image into the center view
The [Center view](https://help.syncfusion.com/maui/circular-charts/radialbarchart#centerview) in the Syncfusion Radial Bar chart helps convey additional information about the chart. In this example, we have included an image related to the content in the center view of our Radial Bar chart. The images were sourced from [Metro Studio](https://www.syncfusion.com/downloads/metrostudio).

### Palette: Making Data Pop with colors
The Syncfusion Circular Chart allows for a customized [palette](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSeries.html#Syncfusion_Maui_Charts_ChartSeries_PaletteBrushes) to use distinct colors for each category, making it easier to differentiate between them. Each segment of the Radial Bar Chart represents gender within each industry. This use of color coding helps in the quick visual identification and comparison of categories.

### Legend: A Quick Reference guide
The [legend](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartBase.html#Syncfusion_Maui_Charts_ChartBase_Legend) in the Syncfusion Radial Bar chart provides information about the segments displayed in the circular chart. It lists all the categories with their respective colors as icons, making it easy to interpret the data at a glance without needing to hover over each segment. Here, we can also further customize the legend with preferred template.

### Adding drill-down functionality in chart
The drill-down functionality is used to navigate from one chart to another chart when tapping on a segment. This functionality is achieved by using the [SelectionChanging event](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Charts.ChartSelectionBehavior.html#Syncfusion_Maui_Charts_ChartSelectionBehavior_SelectionChanging) in the .NET MAUI Chart. For example, initially, we displayed the distribution of workers categorized by industries in the Bar chart. When you tap on a particular segment to know more details, it generates a new Radial Bar chart, which provides further detailed information.

The chart below provides a clear visualization of workforce distribution across industries in the US for 2023 using drill down functionality.

### Output
![ScreenCapture-8-18-2024-61708-PM](https://github.com/user-attachments/assets/dfa2aa21-c427-442f-aafa-6a8fd31b70dd)

## Troubleshooting

#### Path too long exception

If you are facing a path too long exception when building this example project, close Visual Studio and rename the repository to a shorter name before building the project.

For a step-by-step procedure, refer to the [Visualize workforce distribution across various industries blog with drill down]().
