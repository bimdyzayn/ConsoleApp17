using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            Schet<int> schet1 = new Schet<int> ();
            Schet<string> schet2 = new Schet<string>();
            Schet<double> schet3 = new Schet<double>();
            schet1.write(5, 15.50, "Мамаев");
            schet2.write("--5--", 20.50, "Магомедов");
            schet3.write(5.15, 15.50, "Мамаев");
            Console.WriteLine($"Номер счета: {schet1.nomer}  баланс: {schet1.balance} ФИО клиента: {schet1.fio}");
            Console.WriteLine($"Номер счета: {schet3.nomer}  баланс: {schet3.balance} ФИО клиента: {schet3.fio}");
            Console.WriteLine($"Номер счета: {schet2.nomer}  баланс: {schet2.balance} ФИО клиента: {schet2.fio}");
            Console.ReadLine();

        }
    }
}
