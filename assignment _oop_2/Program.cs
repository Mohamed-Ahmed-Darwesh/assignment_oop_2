using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace assignment__oop_2
{
    internal class Program
    {
        static void Main()
        {
            #region Q1
            #region add_people
            Person[] people = new Person[]
            {
                    new Person("Iso", 30),
                    new Person("Hamda", 23),
                    new Person("Jett", 27)
            };
            #endregion
            Console.WriteLine("People Details:");
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine($"Name: {people[i].Name}, Age: {people[i].Age}");
            }

            #endregion
            #region Q2

            #region getting the inputs
            bool Flag = false;
            int x1;
            int x2;
            int y1;
            int y2;
            Console.WriteLine("Enter coordinates for Point 1 X:");
            do
            {
                Console.Write("X1: ");
                Flag = int.TryParse(Console.ReadLine(), out x1);
            }
            while (!Flag);
            Console.WriteLine("Enter coordinates for Point 1 Y:");
            do
            {
                Console.Write("Y1: ");
                Flag = int.TryParse(Console.ReadLine(), out y1);
            }
            while (!Flag);
            Console.WriteLine("Enter coordinates for Point 2 X:");
            do
            {
                Console.Write("X2: ");
                Flag = int.TryParse(Console.ReadLine(), out x2);
            }
            while (!Flag);
            Console.WriteLine("Enter coordinates for Point 2 Y:");
            do
            {
                Console.Write("Y2: ");
                Flag = int.TryParse(Console.ReadLine(), out y2);
            }
            while (!Flag);
            Point p1 = new Point(x1, y1);
            Point p2 = new Point(x2, y2);
            #endregion
            double distance = Point.Distance(p1, p2);
            Console.WriteLine($"the distance between point 1 and point 2 is: {distance}");
            #endregion
            #region Q3
            Person1 oldest;
            bool flag = false;
            int Age;
            string? Name;

            #region Taking the people data
            Person1[] People = new Person1[3];
            for (int i = 0; i < People.Length; i++)
            {
                Console.WriteLine($"enter details of the {i + 1} person:");
                do
                {
                    Console.Write($"age of person {i + 1}: ");
                    flag = int.TryParse(Console.ReadLine(), out Age);
                }
                while (!flag || Age == 0);
                do
                {
                    Console.Write($"name of person {i + 1}: ");
                    Name = Console.ReadLine();
                }
                while (Name == null || Name.Trim() == "");

                People[i] = new Person1(Name, Age);
            }
            #endregion

            #region getting the oldest
            oldest = People[0];
            for (int i = 0; i < People.Length; i++)
            {
                oldest = oldest.Age < People[i].Age ? People[i] : oldest;
            }

            #endregion
            Console.WriteLine($"the oldest person is {oldest.Name} and he is {oldest.Age} years old");
            #endregion
            #region Q4
            Rectangle rect = new Rectangle();
            rect.Width = 4;
            rect.Height = 5;

            rect.DisplayInfo();
            #endregion 
        }
    }
}
