using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelFactory.Classes
{
    public class InputResources
    {
        public double Ore { get; set; }
        public double Nikel { get; set; }
        public double Chrome { get; set; }
        public double Marganec { get; set; }
        public double TimeFurnace { get; set; }
        public double TimeConverter { get; set; }
        public double TimeRollingMachine { get; set; }
        

        //Задаем значение полям т.е. кол-во ресурсов в целом
        public InputResources(double[] arr)
        {
            Ore = arr[0];
            Nikel = arr[1];
            Chrome = arr[2];
            Marganec = arr[3];
            TimeFurnace = arr[4];
            TimeConverter = arr[5];
            TimeRollingMachine = arr[6];
        }
    }
}
