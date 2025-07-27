using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment__oop_2
{
    #region Q1
    internal struct Person
    {
        private string? name;
        private int age;

        #region properties

        public string Name
        {
            get => name ?? "";
            set
            {
                if (value is not null)
                    name = value;
            }
        }

        public int Age
        {
            get => age != 0 ? age : -1;
            set
            {
                if (value != 0)
                    age = value;
            }
        }
        #endregion
        #region constructor
        public Person(string Name, int Age)
        {
            age = Age;
            name = Name;
        }
        #endregion

    }
    #endregion
    #region Q2
    internal struct Point {
        private int x;
        private int y;

        #region Properties
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        #endregion
        #region constructor
        public Point(int X, int Y)
        {
            x=X; 
            y=Y;
        }
        #endregion
        #region function
        public static double Distance(Point p1, Point p2)
        {
            double res;
            double dx = p1.x - p2.x;
            double dy = p1.y - p2.y;
            res = Math.Sqrt(dx * dx + dy * dy);
            return res;
        }
        #endregion
    }
    #endregion
    #region Q3
    internal struct Person1
    {
        private int age;
        private string? name;

        #region properties

        public string Name
        {
            get => name ?? "";
            set
            {
                if (value is not null)
                    name = value;
            }
        }

        public int Age
        {
            get => age != 0 ? age : -1;
            set
            {
                if (value != 0)
                    age = value;
            }
        }
        #endregion
        #region constructor
        public Person1(string Name, int Age)
        {
            age = Age;
            name = Name;
        }
        #endregion
    }
    #endregion
    #region Q4
    public struct Rectangle
    {
        private int width;
        private int height;

        #region Properties 
        public int Width
        {
            get { return width; }
            set
            {
                if (value >= 0)
                    width = value;
                else Console.WriteLine("you can't enter a negative number");
            }
        }

        public int Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else Console.WriteLine("you can't enter a negative number");
            }
        }
        public int Area {
            get
            {
                return width * height;
            }
        }
        #endregion
        public void DisplayInfo()
        {
            Console.WriteLine($"Width: {Width}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Area: {Area}");
        }
    }
    #endregion


}
   

    

