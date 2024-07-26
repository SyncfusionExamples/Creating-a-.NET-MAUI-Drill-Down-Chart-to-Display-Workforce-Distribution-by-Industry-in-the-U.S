namespace DoughnutChart;

public partial class SecondaryPage : ContentPage
{
    public SecondaryPage(DataModel selectedData, Brush fill)
    {
        InitializeComponent();

        titleLabel.Text = $"Share of workers: {selectedData.Industry}";
        this.BindingContext = selectedData;
        series.Fill = fill;
    }
}