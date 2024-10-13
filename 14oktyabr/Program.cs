using _14oktyabr.Models;
using System.Drawing;

namespace _14oktyabr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student student = new student
            {
                Name = "Nurana",
                Surname = "Valiyeva",
                Group = "KE023S1",
                Point = 65
               
            };
          student.GetInfo();
            student.CheckGradiation();
                student.GetDiplomDegree();
           
        }

    }

    
}
