using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    public class SensorData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Temperature { get; set; }
        public string CO2 { get; set; }

        public SensorData()
        {
            
        }

        public SensorData(int id, string name, string temperature, string co2)
        {
            Id = id;
            Name = name;
            Temperature = temperature;
            CO2 = co2;
        }
    }
}
