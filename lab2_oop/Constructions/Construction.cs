using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_oop.Constructions
{
    internal class Construction
    {
        private string _BuildMaterial;

        public Construction()
        {
            
        }

        public Construction(float height, float width, int entrances, int humanCapacity, string buildMaterial)
        {
            Height = height;
            Width = width;
            Entrances = entrances;
            HumanCapacity = humanCapacity;
            BuildMaterial = buildMaterial;
        }

        public float Height { get; set; }
        public float Width { get; set; }
        public int Entrances { get; set; }
        public int HumanCapacity { get; set; }
        public string BuildMaterial 
        { 
            get 
            {
                return _BuildMaterial;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(nameof(value));
                }
                _BuildMaterial = value;
            }
        }
    }
}
