namespace WeatherApp
{
    class City
    {
        private string _name;
        public string Name
        {
            get => _name;
            private set => _name = value;
        }
        public City(string name)
        {
            _name = name;
        }
    }
}
