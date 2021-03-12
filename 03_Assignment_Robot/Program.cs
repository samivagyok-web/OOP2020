using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Assignment_Robot
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantKillerRobot robot = new GiantKillerRobot();
            robot.initialize();
            robot.currentVersion();
            robot.degradeRobot();
            robot.upgradeRobot();
            robot.currentVersion();

            robot.EyeLaserIntensity = Intensity.Kill;
            Console.WriteLine($"Current eye-laser intensity: {robot.EyeLaserIntensity}");
        }
    }
}
