using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Schet <T>
    {
        public T nomer { get; set; }
        public double balance { get; set; }
        public string fio { get; set; }

        public void write(T n, double b, string f)
        {
            nomer = n;
            balance = b;
            fio = f;
        }
        void read(T n, double b, string f)
        {
            nomer = n;
            balance = b;
            fio = f;
        }
    }
}
