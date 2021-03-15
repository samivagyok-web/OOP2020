using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Assignment_Robot
{
    public class Earth
    {
        private static Random rnd = new Random();
        private string name = "Earth";
        private int population = rnd.Next(1000, 100000);
        private int populationStrength = 17; // 0-100 scale; ex. if strength is 60, only 60% of attacks by the robot will be fatal

        public bool containsLife() => population > 0 ? true : false;

        #region Properties

        public string Name { get { return name; } }

        public int PopulationStrength
        {
            get
            {
                return populationStrength;
            }
        }

        public int Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }
        #endregion
    }
}
