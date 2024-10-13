using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _14oktyabr.Models
{
    internal class student
    {
        public string Name;
        public string Surname;
        public string Group;
        public double Point;
        public bool IsGraduated;
        

        public student() 
        {
            Console.WriteLine("person created");
        }
        public student(string name, string surname, string group, double point, bool isgraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
            Point = point;
            IsGraduated = point >=65; 

        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name} Surname: {Surname} Group: {Group} Point: {Point}");
        }
        public void CheckGradiation()
        {
            if (Point < 65)
            {
                IsGraduated = false;
                Console.WriteLine($"Is Graduate: {IsGraduated}" );
               
            }
            else if(Point>=65 && Point <= 100)
            {
                IsGraduated = true;
                Console.WriteLine($"Is Graduate: {IsGraduated}");
            }
        }
            public void GetDiplomDegree()
            {
                if (Point < 65)
                {
                   
                    Console.WriteLine("Diplom yoxdur.");

                }
                else if (Point > 65 && Point < 80)
                {
                   
                    Console.WriteLine("adi diplom");
                }
                else if (Point >= 80 && Point < 90)
                {
                    
                    Console.WriteLine("sheref");
                }
                else
                {
                   
                    Console.WriteLine("yuksek sheref");
                }
            }
        }
    }

