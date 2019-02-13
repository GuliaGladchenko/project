using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxLab
{
    public class Car
    {
        public string marka;
        public string model;
        public int number;
        public string SNF;
        public string color;

        public Car()
        {
            marka = "";
            model = "";
            number = 0;
            SNF = "";
            color = "";
        }

        public Car (string marka, string model, int number, string SNF, string color)
        {
            this.marka = marka;
            this.model = model;
            this.number = number;
            this.SNF = SNF;
            this.color = color;
        }
    }
}
