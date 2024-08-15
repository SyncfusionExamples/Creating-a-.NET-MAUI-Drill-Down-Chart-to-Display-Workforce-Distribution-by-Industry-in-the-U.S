using Microsoft.Maui.Controls.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DoughnutChart
{
    public class DataViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<DataModel> DataCollection {get; set; }
        public ObservableCollection<Model> EmployeeCollection { get; set; }

        public List<Brush> CustomBrushes { get; set; }

        public Geometry? MalePath { get; set; } = (Geometry?)(new PathGeometryConverter().ConvertFromInvariantString("M14.700006,19.1L19.999991,19.1C25.099964,19.1,29.199999,23.200008,29.199999,28.300016L29.199999,32 0,32 0,28.399992C-9.5822543E-08,23.300015,4.0999738,19.200007,9.2000085,19.200007L14.499993,19.200007C13.999994,19.399988,12.09997,20.399988,12.09997,21.200007L14.09997,22.300015C14.09997,22.300015 12.09997,25.39999 12.09997,29.800016 12.09997,30.300018 16.999993,30.5 16.999993,29.800016 16.999993,25.300015 15.099969,22.200008 15.099969,22.200008L16.999993,21.1C16.999993,20.200007,15.200006,19.300013,14.700006,19.1z M14.599969,0C19.099968,0 22.799978,3.6999987 22.799978,8.2000008 22.799978,12.700003 19.099968,16.399986 14.599969,16.399986 10.099971,16.399986 6.4000217,12.800009 6.4000217,8.2000008 6.4000217,3.5999926 10.099971,0 14.599969,0z"));
        public Geometry? FemalePath { get; set; } = (Geometry?)(new PathGeometryConverter().ConvertFromInvariantString("M18.900009,20.599976C22,21,24.5,23.5,24.5,26.399994L24.5,32 0,32 0,26.399994C0,23.699982,2.1000061,21.399994,4.9000092,20.699982L5,20.699982 4.3000031,24.399994 8.2000122,22.299988 12.200012,31.699982 16,22.399994 20,24.5z M12.200012,0C16.5,0,20,3.3999939,20.100006,7.6999817L20.100006,7.7999878 20.100006,16.599976C20.100006,17.5,19.300003,18.299988,18.400009,18.299988L14.700012,18.299988C19.100006,15.699982 18.900009,9.7999878 18.900009,9.7999878 14.200012,9.6999817 12.300003,6 12.300003,6 10,9.5 5.8000031,9.7999878 5.8000031,9.7999878 5.6000061,15.199982 8.7000122,17.5 10,18.199982L6,18.199982C5.1000061,18.199982,4.3000031,17.399994,4.3000031,16.5L4.3000031,8.7999878C4.3000031,8.5 4.2000122,8.1999817 4.2000122,7.8999939 4.3000031,3.5 7.8000031,0 12.200012,0z"));

        private string? _imageName;
        public string? ImageName
        {
            get => _imageName;
            set
            {
                if (_imageName != value)
                {
                    _imageName = value;
                    OnPropertyChanged(nameof(ImageName));
                }
            }
        }

        private DataModel? data;
        public DataModel? Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
                OnPropertyChanged("Data");
            }
        }

        public DataViewModel() 
        {
            DataCollection = new ObservableCollection<DataModel>
            {
                new DataModel("Agriculture", 2264,  1601, 663),
                new DataModel("Mining, quarrying, and oil and gas extraction", 590, 500, 90),
                new DataModel("Construction",  11896, 10610, 1287),
                new DataModel("Manufacturing", 15570,  10971,  4599),
                new DataModel("Wholesale and retail trade", 19787, 10877,  8910),
                new DataModel("Transportation and utilities", 9949, 7530,  2420),
                new DataModel("Information", 2971,  1833,  1138),
                new DataModel("Financial activities", 11018, 5384, 5634),
                new DataModel("Professional and business services", 20735, 11980, 8756),
                new DataModel("Education and health services", 36378,  9322, 27056),
                new DataModel("Leisure and hospitality", 14288, 7027, 7261),
                new DataModel("Other services", 7605,  3551,  4055),
                new DataModel("Public administration", 7984,  4313,  3670),
            };

            CustomBrushes = new List<Brush>()
            {
                new SolidColorBrush(Color.FromArgb("#67bd57")),
                new SolidColorBrush(Color.FromArgb("#e33d3d"))
            };

            EmployeeCollection = new ObservableCollection<Model>
            {
                new Model("Male", 1601, 500, 10610, 10971, 10877, 7530, 1833, 5384, 11980, 9322, 7027, 3551, 4313, MalePath),
                new Model("Female", 663, 90, 1287, 4599, 8910, 2420, 1138, 5634, 8756, 27056, 7261, 4055, 3670, FemalePath),
            };
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
