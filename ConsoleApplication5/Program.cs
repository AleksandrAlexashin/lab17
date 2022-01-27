using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Schet<int> schet1 = new Schet<int>() {Nomer=111111, Balance=500000, Name ="Ивашов Иван Иванович" };
            Schet<string> schet2 = new Schet<string>() { Nomer = "A111111", Balance = 100000, Name = "Сидоров Семён Иванович" };
            Schet<string> schet3 = new Schet<string>() { Nomer = "Привелигированный", Balance = 10000000, Name = "Пупкин Василий Васильевич" };
            Schet<int> schet4 = new Schet<int>() { Nomer = 64000058, Balance = 10000, Name = "Гоблинов Пётр Петрович" };
            Schet<string> schet5 = new Schet<string>() { Nomer = "Пенсионный2022", Balance = 10000, Name = "Петров Иван Петрович" };
           
            Console.WriteLine("Номер: {0} Баланс: {1} ФИО: {2}",schet1.Nomer,schet1.Balance,schet1.Name);
            Console.WriteLine("Номер: {0} Баланс: {1} ФИО: {2}", schet2.Nomer, schet2.Balance, schet2.Name);
            Console.WriteLine("Номер: {0} Баланс: {1} ФИО: {2}", schet3.Nomer, schet3.Balance, schet3.Name);
            Console.WriteLine("Номер: {0} Баланс: {1} ФИО: {2}", schet4.Nomer, schet4.Balance, schet4.Name);
            Console.WriteLine("Номер: {0} Баланс: {1} ФИО: {2}", schet5.Nomer, schet5.Balance, schet5.Name);
           
            Console.ReadKey();
        }
        
    }
    

}
