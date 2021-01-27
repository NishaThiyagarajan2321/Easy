using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePromotion
{
    class Program
    {
        static void Main(string[] args)

        {   //1.Hold the employee names in a list
            
            
            List<string> Employeenames = new List<string>();
            
            Console.WriteLine("Please Enter the employee names in the order of their eligibility for promotion");
            
            for(int i=0;i<5;i++)
            {
                 var Inputlist = Console.ReadLine();
                Employeenames.Add(Inputlist);
            }
            

            //2.Finding the position value for promotion

            Console.WriteLine("Please enter the name of the employee to check promotion position");
            var positionname =Console.ReadLine();
            var index = Employeenames.IndexOf(positionname);
            Console.WriteLine(" ''{0}'' is the position {1} for promotion.",positionname , index+1); 


            //3.Removing the excess memory
            Console.WriteLine("The current size of the collection is {0}:", Employeenames.Capacity);
            Employeenames.TrimExcess();
            Console.WriteLine("The size after removing the extra space is {0}:", Employeenames.Capacity);

            //4.Sorted the employee names in ascending
            Console.WriteLine("Promoted List:");
            Employeenames.Sort();
            foreach (var Sortedname in Employeenames)
            {
                Console.WriteLine(Sortedname);
            }
            Console.ReadKey();

        }
    }
}
