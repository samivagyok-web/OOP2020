using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02_Assignment_Geometry
{
    public class Point
    {
        private double x, y;
        private double initialX, initialY;

        #region History

        List<Point> history = new List<Point>();
        int currentHistoryIndex = 0;

        public void returnToInitialValues()
        {
            this.x = initialX;
            this.y = initialY;
        }

        public void StepBack(int steps) // how many steps back do we take?
        {
            if (currentHistoryIndex < steps)
            {
                currentHistoryIndex = 0;
                return;
            }
            else
            {
                currentHistoryIndex = currentHistoryIndex - steps;

                this.x = history[currentHistoryIndex].x;
                this.y = history[currentHistoryIndex].y;
            }
        }

        public void StepAhead(int steps) // redo
        {
            if (currentHistoryIndex + steps >= history.Count)
            {
                currentHistoryIndex = history.Count - 1;

                this.x = history[currentHistoryIndex].x;
                this.y = history[currentHistoryIndex].y;
            }
            else
            {
                currentHistoryIndex += steps;

                this.x = history[currentHistoryIndex].x;
                this.y = history[currentHistoryIndex].y;
            }
        }

        #endregion

        #region Constructors
        public Point(): this(0.0, 0.0)
        {
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
            initialX = x;
            initialY = y;
        }

        public void ResetToInitialCoordinates()
        {
            x = initialX;
            y = initialY;
        }

        public Point(string p)
        {
            // we get rid of the usless elements ( '(' , ')', spaces) and split the string in two => left part of ',' and right part of ','
            p = Regex.Replace(p, @"\s+", "");
            p = Regex.Replace(p, @"\(", "");
            p = Regex.Replace(p, @"\)", "");

            try
            {
                string[] coordinates = p.Split(',');
                this.x = double.Parse(coordinates[0]);
                this.y = double.Parse(coordinates[1]);
            }
            catch (Exception)
            {
                Console.WriteLine("EXCEPTION: Bad input format :(");
            }
        }
        #endregion

        public double DistanceToOrigin() => DistanceTo(new Point());

        public double DistanceTo(Point p2) => Math.Sqrt(Math.Pow(x - p2.x, 2) + Math.Pow(y - p2.y, 2));



        public override string ToString()
        {
            return $"({x}, {y})";
        }

        public void MoveBy(double dx, double dy)
        {
            this.x += dx;
            this.y += dy;


            // add to the history the new point and jumps to the end of the list
            history.Add(new Point(x, y));
            currentHistoryIndex = history.Count - 1;
        }

        #region Properties
        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        #endregion
    }
}