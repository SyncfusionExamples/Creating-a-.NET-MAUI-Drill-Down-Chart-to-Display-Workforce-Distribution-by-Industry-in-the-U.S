using System.Collections.ObjectModel;

namespace DoughnutChart
{
    public class DataViewModel
    {
        public ObservableCollection<DataModel> DataCollection {get; set; }
        private ObservableCollection<DataModel> Data1 {get; set;}
        private ObservableCollection<DataModel> Data2 {get; set;}
        private ObservableCollection<DataModel> Data3 {get; set;}
        private ObservableCollection<DataModel> Data4 {get; set;}
        private ObservableCollection<DataModel> Data5 {get; set;}
        private ObservableCollection<DataModel> Data6 {get; set;}
        private ObservableCollection<DataModel> Data7 {get; set;}
        private ObservableCollection<DataModel> Data8 {get; set;}
        public List<Brush> CustomBrushes {get; set;}

        public DataViewModel() 
        {
            Data1 = new ObservableCollection<DataModel>
            {
                new DataModel ("Male", 38.1),
                new DataModel ("Female", 62.9)
            };

            Data2 = new ObservableCollection<DataModel>
            {
                new DataModel ("Male", 0.4),
                new DataModel ("Female", 0.1)
            };

            Data3 = new ObservableCollection<DataModel>
            {
                new DataModel ("Male", 11.8),
                new DataModel ("Female", 11.2)
            };

            Data4 = new ObservableCollection<DataModel>
            {
                new DataModel ("Male", 0.7),
                new DataModel ("Female", 0.2)
            };

            Data5 = new ObservableCollection<DataModel>
            {
                new DataModel ("Male", 15.6),
                new DataModel ("Female", 5.0)
            };

            Data6 = new ObservableCollection<DataModel>
            {
                new DataModel ("Male", 14.7),
                new DataModel ("Female", 5.9)
            };

            Data7 = new ObservableCollection<DataModel>
            {
                new DataModel ("Male", 7.5),
                new DataModel ("Female", 1.2)
            };

            Data8 = new ObservableCollection<DataModel>
            {
                new DataModel ("Male", 11.2),
                new DataModel ("Female", 13.6)
            };

            DataCollection = new ObservableCollection<DataModel>
            {
                new DataModel("Agriculture", 45.5, Data1),
                new DataModel("Construction", 12.4, Data5),
                new DataModel("Trade, hotel & restaurant", 12.1, Data6),
                new DataModel("Other services", 11.9, Data8),
                new DataModel("Manufacturing", 11.6, Data3),
                new DataModel("Transport, storage & communications", 5.6, Data7),
                new DataModel("Electricity, water, etc.",0.6, Data4),
                new DataModel("Mining and quarrying", 0.3, Data2)
            };

            CustomBrushes = new List<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#34ea61")),
                new SolidColorBrush(Color.FromArgb("#a86229")),
                new SolidColorBrush(Color.FromArgb("#948b84")),
                new SolidColorBrush(Color.FromArgb("#78cddd")),
                new SolidColorBrush(Color.FromArgb("#fe5858")),
                new SolidColorBrush(Color.FromArgb("#ff813d")),
                new SolidColorBrush(Color.FromArgb("#b57af0")),
                new SolidColorBrush(Color.FromArgb("#a7b172"))
            };
        }
    }
}
