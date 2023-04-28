using System.Xml.Linq;

namespace WeatherApp
{
    public enum ActiveSubstance
    {
        PainRelievers,
        Antihistamines,
        Decongestants,
        VitaminsAndMinerals,
        CholesterolLoweringDrugs,
        DiabetesMedications,
        Antidepressants,
        BloodPressureMedications
    }

    internal class Pills
    {
        private string _name;
        private int _price;
        private int _ageOfAdmission;
        private ActiveSubstance _activeSubstance = ActiveSubstance.VitaminsAndMinerals;
        private City _city;

        public int Price
        {
            get => _price;
        }

        public string Name
        {
            get => _name;
        }

        public int AgeOfAdmission
        {
            get => _ageOfAdmission;
        }

        public ActiveSubstance ActiveSubstance
        {
            get => _activeSubstance;
        }

        private City City
        {
            get => _city;
        }

        public string CityName
        {
            get { return City != null ? City.Name : "Не назначено"; }
        }

        public Pills(string name, int price, int ageOfAdmission, ActiveSubstance activeSubstance, City city)
        {
            _name = name;
            _price = price;
            _ageOfAdmission = ageOfAdmission;
            _activeSubstance = activeSubstance;
            _city = city;
        }


    }
}