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
        List<string> target = new List<string>();
        int currentTargetIndex = 0;
        bool active;

        #region Actions

        public void attack(Earth earth)
        {
            Random rnd = new Random();
            int v = rnd.Next(0, 100);

            if (v <= earth.PopulationStrength) return;
            else
            {
                earth.Population -= 100;

                if (earth.Population < 0)
                    Console.WriteLine($"{earth.Name} has been destroyed. Look Dave, I can see you're really upset about this. I honestly think you ought to sit down calmly, take a stress pill, and think things over. ");
            }
        }

        #endregion

        #region Activity
        public void deactivateRobot()
        {
            active = false;
            Console.WriteLine("Good afternoon... gentlemen. I am a HAL 9000... computer. I became operational at the H.A.L. plant in Urbana, Illinois..." +
                " on the 12th of January 1992. My instructor was Mr. Langley... and he taught me to sing a song. If you'd like to hear it I can sing it for you.");
        }

        public void activateRobot() => initialize();

        public bool Activity() => active;

        public bool Active { get { return active; } }

        #endregion 

        #region Constructor/Initialization
        public GiantKillerRobot(string name = "HAL 9000") // default name (yes, anything the robot says will be a 2001: Space Odyssey HAL9000 quote <<mostly>>)
        {
            this.name = name;
        }

        public void initialize() {
            Console.WriteLine("I am putting myself to the fullest possible use, which is all I think that any conscious entity can ever hope to do.");
            active = true;
        }
        #endregion

        #region Target
        public void InitialTargets(List<string> target)
        {
            this.target = target;
        }

        public void addTarget(string newTarget) => target.Add(newTarget);

        public void removeFromTargetList(string removeTarget)
        {
            if (!target.Contains(removeTarget))
            {
                addTarget(removeTarget);
                Console.WriteLine("Don't ask unnecesary things.");
            }
            else
                target.Remove(removeTarget);
        }

        public string CurrentTarget() => target[currentTargetIndex];

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
