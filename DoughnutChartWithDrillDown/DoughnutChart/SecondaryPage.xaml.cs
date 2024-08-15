using Syncfusion.Maui.Charts;
using System.Globalization;

namespace DoughnutChart
{
    public partial class SecondaryPage : ContentPage
    {
        public SecondaryPage(DataModel selectedData)
        {
            InitializeComponent();

            viewModel.Data = selectedData;
            centerView.Text = selectedData.Industry;
            var field = selectedData.Industry.Split(' ')[0].Replace(",", "");
            series.YBindingPath = field + "Employee";
            viewModel.ImageName = field.ToLower() == "public" ? "public1.png": field + ".png";
        }
    }

    public class TooltipTemplate : IValueConverter
    {
        DataViewModel? viewModel;
        Model? model;
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is TooltipInfo tooltipbehavior && tooltipbehavior.Source is RadialBarSeries series)
            {
                viewModel = series.BindingContext as DataViewModel;


                if (viewModel == null || parameter == null)
                {
                    return value;
                }

                var path = series.YBindingPath;
                var index = tooltipbehavior.Index;

                var param = parameter.ToString();

                return param switch
                {
                    "image" => index == 0 ? viewModel.MalePath: viewModel.FemalePath,
                    "yValue" => GetYValue(viewModel, index, path),
                    "percent" => CalculatePercent(viewModel, index, path),
                    _ => value
                };
            }

                return value;
        }

        private object? GetYValue(DataViewModel viewModel, int index, string path)
        {
            var currentModel = viewModel.EmployeeCollection[index];
            return currentModel?.GetType()?.GetProperty(path)?.GetValue(currentModel);
        }

        private object? CalculatePercent(DataViewModel viewModel, int index, string path)
        {
            var value = GetYValue(viewModel, index, path);
            if (value is double yValue && viewModel.Data != null)
            {
                var percent = (yValue / viewModel.Data.Percent) * 100;
                return Math.Round(percent, 2);
            }
            return value;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class BrushToColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type? targetType, object? parameter, CultureInfo? culture)
        {
            if (!Brush.IsNullOrEmpty(value as SolidColorBrush))
            {
                SolidColorBrush? brush = value as SolidColorBrush;
                return brush == null ? null : brush.Color;
            }
            throw new ArgumentException("Expected value to be a type of brush", nameof(value));
        }

        public object ConvertBack(object? value, Type? targetType, object? parameter, CultureInfo? culture)
        {
            if (value != null && value is Color color)
            {
                return new SolidColorBrush(color);
            }
            throw new ArgumentException("Expected value to be a type of color", nameof(value));
        }
    }
}