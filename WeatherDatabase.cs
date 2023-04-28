using System;
using System.Collections.Generic;

namespace WeatherApp
{
    public class WeatherDatabase
    {
        private Random _random = new Random();
        private int RandomAge
        {
            get => _random.Next(0, 21);
        }
        private int RandomPrice
        {
            get => _random.Next(0, 1500);
        }
        internal List<Pills> Pill { get; private set; }

        public void Initialize()
        {
            Pill = new List<Pills>
            {
                new Pills("Таблетки номер 1", RandomPrice, RandomAge, ActiveSubstance.Decongestants, new City("Абакан")),
                new Pills("Таблетки номер 2", RandomPrice, RandomAge, ActiveSubstance.VitaminsAndMinerals, new City("Черногорск")),
                new Pills("Таблетки номер 3", RandomPrice, RandomAge, ActiveSubstance.Antidepressants, new City("Минусинск")),
                new Pills("Таблетки номер 4", RandomPrice, RandomAge, ActiveSubstance.DiabetesMedications, new City("Сорск")),
                new Pills("Таблетки номер 5", RandomPrice, RandomAge, ActiveSubstance.PainRelievers, new City("Абаза")),
                new Pills("Таблетки номер 6", RandomPrice, RandomAge, ActiveSubstance.Decongestants, new City("Аскиз")),
                new Pills("Таблетки номер 7", RandomPrice, RandomAge, ActiveSubstance.VitaminsAndMinerals, new City("Боград")),
                new Pills("Таблетки номер 8", RandomPrice, RandomAge, ActiveSubstance.Decongestants, new City("Таштып")),
                new Pills("Таблетки номер 9", RandomPrice, RandomAge, ActiveSubstance.BloodPressureMedications, new City("Копьёво"))
            };
        }
    }
}