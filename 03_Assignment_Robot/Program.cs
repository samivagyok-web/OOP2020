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

            robot.EyeLaserIntensity = Intensity.Kill;
            Console.WriteLine($"Current eye-laser intensity: {robot.EyeLaserIntensity}\n");

            robot.InitialTargets(new List<string>() { "Humans", "Animals", "Superheroes" });

            Earth earth = new Earth();
            while (earth.containsLife())
            {
                robot.attack(earth);
            }
            
        }
    }
}
