using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW_ZamosteanuAndraBeatrice
{
    public class NewChartValues
    {
        public NewChartValues(string label, double value)
        {
            Label = label;
            Value = value;
        }

        public string Label { get; set; }
        public double Value { get; set; }

    }
}
