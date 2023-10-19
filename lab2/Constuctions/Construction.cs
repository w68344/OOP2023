using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Constuctions
{
    class Construction
    {
        public Construction(double height, 
            double width, 
            int entrances, 
            int humanCapasity, 
            string builtMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapasity = humanCapasity;
            BuiltMaterial = builtMaterial;
        }
        public double Height { get; set; }
        public double Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapasity { get; set; }
        public string BuiltMaterial { get; set; }
    }
}
