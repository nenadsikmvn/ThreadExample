using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ThreadExample;

namespace ThreadExample
{
    public class ThreadedWorker
    {
        int Id;
        Thread t;

        public ThreadedWorker(int Id)
        {
            this.Id = Id;
            t = new Thread(new ThreadStart(doWork));
            t.Start();
        }

        void doWork()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread " + Id + " is running");
            }
            Console.WriteLine("Thread  " + Id + " is finished.");

        }
    }
}

    class Program
    {
    static void Main(string[] args)
    {
        
        for (int i = 0; i < 10; i++)
        {
            ThreadedWorker tr = new ThreadedWorker(i);
          
        }
  
        Console.ReadLine();
    }
    }
