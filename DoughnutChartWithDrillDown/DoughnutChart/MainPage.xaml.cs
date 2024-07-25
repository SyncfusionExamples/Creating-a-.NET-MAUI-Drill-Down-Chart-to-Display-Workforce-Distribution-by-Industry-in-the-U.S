﻿
using Syncfusion.Maui.Charts;
using System.Collections;
using System.Globalization;

namespace DoughnutChart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DataPointSelectionBehavior_SelectionChanging(object sender, ChartSelectionChangingEventArgs e)
        {
            var series = sender as DoughnutSeries;
            int selectedIndex = e.NewIndexes[0];

            if (series == null || series.ItemsSource is not IList items)
            {
                return;
            }
            
            //Get selected segment data
            var selectedData = items[selectedIndex] as DataModel;

            if (selectedData != null)
            {
                // Navigate to the next page which is representing the chart with details.
                Navigation.PushAsync(new SecondaryPage(selectedData, series.PaletteBrushes[selectedIndex]));
                e.Cancel = true;
            }
        }
    }

    public class CenterViewDimension : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            //            int value1 = 0;
            //            value1 = (int)value;
            //#if MACCATALYST

            //            value1 = value1 / 4;
            //#endif
            //            return value1;

            double size;
            string para = value.ToString();

#if MACCATALYST
            if(value != null && double.TryParse(para, out size))
            {
                return (double)value / 2;
            }
#endif

            return value;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
