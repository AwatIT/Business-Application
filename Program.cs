using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOfBirthCalculatorByAwat
{
    class Program
    {
        private string sName;
        private int sAge;
        private int currentYear;


        public Program()
        {
            this.sName = "NoName";
            this.sAge = 0;
            this.currentYear = DateTime.Now.Year;
        }

        public Program(string sName, int sAge, int currentYear)
        {
            // some data validation just for fun
            this.sName = (sName == "" || string.IsNullOrEmpty(sName)) ? "NoName" : sName;
            this.sAge = (sAge < 0) ? 0 : sAge;
            this.currentYear = (currentYear < DateTime.Now.Year) ? DateTime.Now.Year : currentYear;
        }

        public void ageSetter(int nAge)
        {
            if (nAge >0 )
            {
                sAge = nAge;
            }
        }

        public int ageGetter()
        {
            return sAge;
        }

        public void nameSetter(string nName)
        {
            if (nName != "" || !string.IsNullOrEmpty(nName))
            {
                sName = nName;
            }
        }

        public string nameGetter()
        {
            return sName;
        }

        public int yearOfBirth(int age)
        {
            int calYaerOfAge = 0; 
            if (age  > 0)
            {
                calYaerOfAge = currentYear - age;
            }
            return calYaerOfAge;
        }

        public static void header()
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine("=====\t Awat Z. Hamad\t\t\t\t\t=====");
            Console.WriteLine("=====\t First Assignment\t\t\t\t=====");
            Console.WriteLine("=====\t Date {0}\t\t\t=====", DateTime.Now.ToString());
            Console.WriteLine("=============================================================");
        }

        public static void footer()
        {
            Console.WriteLine("=============================================================");
            Console.WriteLine("=====\t Thank you for using my app.\t\t\t=====");
            Console.WriteLine("=============================================================");
        }


        static void Main(string[] args)
        {
            string rawName = "";
            int age = 0;
            string exit;

            header();

            do
            {
                Console.Write("Hello I am Awat, I will calculate your age, What is your name?: ");
                rawName = Console.ReadLine();

                Console.Write("Hello {0}, what is your age: ", rawName);
                int.TryParse(Console.ReadLine(), out age);

                Program obj = new Program(rawName, age, 2021);

                Console.WriteLine("Hello {0}, and your age is {1}, so you were born in {2}\n", obj.nameGetter(), obj.ageGetter().ToString(), obj.yearOfBirth(obj.ageGetter()));

                Console.Write("For Exit the program? {no}. Do you want to try again?: ");
                exit = Console.ReadLine();
            } while (!exit.Equals("no"));

            footer();

            // for holding console window.
            Console.Read();

        }



    }
}
