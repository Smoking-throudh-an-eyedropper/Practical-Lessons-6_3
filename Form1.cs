using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private WeatherDatabase _weather;

        public WeatherForm()
        {
            InitializeComponent();

            _weather = new WeatherDatabase();
            _weather.Initialize();

            WeatherDataGrid.DataSource = _weather.Pill.ToList();
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {

            WeatherDataGrid.DataSource = _weather.Pill.Where(u=>u.CityName.ToLower().Contains(textBox1.Text.ToLower())).ToList();

        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            switch (comboBox1.SelectedIndex) 
            { 
                case 0:
                    WeatherDataGrid.DataSource = _weather.Pill.Where(u => u.ActiveSubstance == ActiveSubstance.Antidepressants).ToList();
                   break; 
                case 1:
                    WeatherDataGrid.DataSource = _weather.Pill.Where(u => u.ActiveSubstance == ActiveSubstance.Antihistamines).ToList();
                    break;
                case 2:
                    WeatherDataGrid.DataSource = _weather.Pill.Where(u => u.ActiveSubstance == ActiveSubstance.BloodPressureMedications).ToList();
                    break;
                case 3:
                    WeatherDataGrid.DataSource = _weather.Pill.Where(u => u.ActiveSubstance == ActiveSubstance.CholesterolLoweringDrugs).ToList();
                    break;
                case 4:
                    WeatherDataGrid.DataSource = _weather.Pill.Where(u => u.ActiveSubstance == ActiveSubstance.Decongestants).ToList();
                    break;
                case 5:
                    WeatherDataGrid.DataSource = _weather.Pill.Where(u => u.ActiveSubstance == ActiveSubstance.DiabetesMedications).ToList();
                    break;
                case 6:
                    WeatherDataGrid.DataSource = _weather.Pill.Where(u => u.ActiveSubstance == ActiveSubstance.PainRelievers).ToList();
                    break;
                case 7:
                    WeatherDataGrid.DataSource = _weather.Pill.Where(u => u.ActiveSubstance == ActiveSubstance.VitaminsAndMinerals).ToList();
                    break;
            }
            
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            textBox1.Text = "";
            WeatherDataGrid.DataSource = _weather.Pill.ToList();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            WeatherDataGrid.DataSource = _weather.Pill.Where(u => u.Price>1000 ).ToList();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            WeatherDataGrid.DataSource = _weather.Pill.OrderBy(u => u.Price).ToList();
        }
    }
}