using System.Collections.ObjectModel;

namespace DoughnutChart
{
    public class DataModel
    {
        public string? Industry {get; set;}
        public double Percent {get; set;}
        public string? Gender {get; set;}
        public ObservableCollection<DataModel>? Collections {get; set;}

        public DataModel(string? gender, double percent)
        {
            Gender = gender;
            Percent = percent;  
        }

        public DataModel(string industry, double percent, ObservableCollection<DataModel>? collections)
        {
            Industry = industry;
            Percent = percent;
            Collections = collections;
        }
    }
}
