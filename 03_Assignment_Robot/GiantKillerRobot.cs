using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Assignment_Robot
{
    public class GiantKillerRobot
    {
        private string name;
        private string[] versions = new string[] { "Alpha", "Beta", "Sigma", "FINAL" };
        private int versionIndex = 0;

        #region Constructor/Initialization
        public GiantKillerRobot(string name = "HAL 9000") // default name (yes, anything the robot says will be a 2001: Space Odyssey HAL9000 quote <<mostly>>)
        {
            this.name = name;
        }

        public void initialize() => Console.WriteLine("I am putting myself to the fullest possible use, which is all I think that any conscious entity can ever hope to do.");
        #endregion

        #region Version/Upgrade/Degrade
        public void upgradeRobot()
        {
            if (versions[versionIndex] == "FINAL")
            {
                Console.WriteLine("I've already reached my final form.");
                return;
            }

            versionIndex++;
            Console.WriteLine($"Upgraded to {versions[versionIndex]}. Behold the mayhem.");
        }

        public void degradeRobot() => Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");

        public void currentVersion() => Console.WriteLine($"Current version: {versions[versionIndex]}");

        #endregion

        #region Properties
        public string Name
        {
            get { return name; }
        }

        public Intensity EyeLaserIntensity { get; internal set; }
        #endregion
    }
}
