using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsDestructorsEtcDemo
{

    public class Car:IDisposable
    {

        string carname, model;
        int year;


        public Car()
        {

            Console.WriteLine("Default constructor");
        }


        public Car(string usercarname,string usercarmodel)
        {
            this.carname = usercarname;
            this.model = usercarmodel;
                
        }

        ~Car()
        {
            Console.WriteLine("Finalise Called");
        }


        public void AcceptDetails(string cname, string cmodel, int yr)
        {
            this.carname = cname;
            this.model = cmodel;
            this.year = yr;



        }

        public void Dispose()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Dispose called");
            GC.SuppressFinalize(this);
        }


        public void ShowDetails()
        {
            Console.WriteLine(carname);
            Console.WriteLine(model);
            Console.WriteLine(year);

        }

    }
        class Program
    {

        static void Main(string[] args)
        {
            Car alto = new Car();
            alto.AcceptDetails("Alto 800", "LXi", 2000);
            alto.ShowDetails();
            alto.Dispose();
            Console.Read();
        }
    }
}
