using Microsoft.Maui.Controls.Shapes;

namespace DrillDownChart
{
    public class DataModel
    {
        public string Industry { get; set; } = string.Empty;
        public double EmployeeCount {get; set;}
        public double Male {get; set;}
        public double Female {get; set;}

        public DataModel(string industry, double employeeCount, double male, double female)
        {
            Industry = industry;
            EmployeeCount = employeeCount;
            Male = male;
            Female = female;
        }
    }

    public class Model
    {
        public double AgricultureEmployee { get; set; }

        public double MiningEmployee { get; set; }

        public double ConstructionEmployee { get; set; }

        public double ManufacturingEmployee { get; set; }

        public double WholesaleEmployee { get; set; }

        public double TransportationEmployee { get; set; }

        public double InformationEmployee { get; set; }

        public double FinancialEmployee { get; set; }

        public double ProfessionalEmployee { get; set; }

        public double EducationEmployee { get; set; }

        public double LeisureEmployee { get; set; }

        public double OtherEmployee { get; set; }

        public double PublicEmployee { get; set; }

        public string? Gender { get; set; }

        public Geometry? Path { get; set; }

        public Model(string gender, double agricultureEmployee, double miningEmployee, double constructionEmployee, double manufacturingEmployee, double wholesaleEmployee, double transportEmployee, double informationEmployee, double financialEmployee, double professionalEmployee, double educationEmployee, double leisureEmployee, double otherEmployee, double publicEmployee, Geometry? path)
        {
            Gender = gender;
            AgricultureEmployee = agricultureEmployee;
            MiningEmployee = miningEmployee;
            ConstructionEmployee = constructionEmployee;
            ManufacturingEmployee = manufacturingEmployee;
            WholesaleEmployee = wholesaleEmployee;
            TransportationEmployee = transportEmployee;
            InformationEmployee = informationEmployee;
            FinancialEmployee = financialEmployee;
            ProfessionalEmployee = professionalEmployee;
            EducationEmployee = educationEmployee;
            LeisureEmployee = leisureEmployee;
            OtherEmployee = otherEmployee;
            PublicEmployee = publicEmployee;
            Path = path;
        }
    }
}
