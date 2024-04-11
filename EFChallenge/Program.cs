using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // using the student class, add userinput to the database
            using (var db = new BlogDbContext())
            {
                Console.WriteLine("Enter first name: ");
                string fName = Console.ReadLine();
                Console.WriteLine("Enter last name: ");
                string lName = Console.ReadLine();

                var student = new Student { fName = fName, lName = lName};
                db.Students.Add(student);
                db.SaveChanges();
            }

        }
    }
}
