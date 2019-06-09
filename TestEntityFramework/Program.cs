using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TestDbContext())
            {
                var grade = (from s in db.Grades
                             select s).ToList();

                Console.WriteLine("Xong");
            }

            Console.ReadKey();
        }
    }
}
