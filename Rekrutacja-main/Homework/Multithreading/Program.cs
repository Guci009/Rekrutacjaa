using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();

            var preproc = new Preprocess(data);
            var calc = new Calculate(data);
            var display = new Display(data);

            //TODO: start all stuff in new threads
            //Display should wait for calculate to calculate, and calculate needs to wait for preprocess to finish preprocessing
            //(so basically except of parallel processing some sort of syncronization is required!)

            Thread preprocThread = new Thread(new ThreadStart(preproc.Start));
            Thread calcThread = new Thread(new ThreadStart(calc.Start));
            Thread displayThread = new Thread(new ThreadStart(display.Start));


            
            preprocThread.Start();
            preprocThread.Join();
            calcThread.Start();
            calcThread.Join();
            displayThread.Start();
            displayThread.Join();



            //TODO: wait for all threads to finish
            while (preprocThread.IsAlive || calcThread.IsAlive || displayThread.IsAlive)
	        {
               // wait until all threads are finished
            }

            Console.WriteLine("Press any key to exit");
            Console.WriteLine("\t\twhich one is any?!");
            Console.ReadKey();
        }
    }
}
