using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Assignment_Robot
{
    class Venus
    {
        private static Random rnd = new Random();
        private string name = "Venus";
        private uint population = (uint)rnd.Next(1000, 100000);
        private int populationStrength = 20; // 0-100 scale; ex. if strength is 60, only 60% of attacks by the robot will be fatal
        private bool isAlive = true;

        public bool containsLife() => population == 0 ? false : true;

        #region Properties
        public bool IsAlive
        {
            get
            {
                return isAlive;
            }
        }

        public int PopulationStrength
        {
            get
            {
                return populationStrength;
            }
        }

        public uint Population
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