using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dodawanko
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 0;
            string Operator = "";

            Console.WriteLine("Witamy w DodawaczoOdejmowaczuMnozaczu");
            
            Numbers Number = new Numbers();
            int FirstNum =Number.TakeNumber(Num);
            
            Equastions Op = new Equastions();
            string Opera = Op.Oper(Operator);
           
            int SecondNum = Number.TakeNumber(Num);

            IDzialania end = new Equastions();
            end.Dzialanie(FirstNum, SecondNum, Opera);

        }
    }
    class Numbers
    {
        String Number = "";
        String con = "";

        public int TakeNumber(int Num)
        {
            Console.WriteLine("Prosze wpisac liczbe: ");
            do
            {
                try
                {
                    Number = Console.ReadLine();
                    Num = int.Parse(Number);
                    con = "wkoncu";
                }
                catch (FormatException fEx)
                {
                    Console.WriteLine(fEx.Message);
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
                catch (OverflowException OverEx)
                {
                    Console.WriteLine(OverEx.Message);
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
                catch (ArithmeticException ArgEx)
                {
                    Console.WriteLine(ArgEx.Message);
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
                catch (Exception Ex)
                {
                    Console.WriteLine("Coś poszło nie tak");
                    Console.WriteLine("Wpisz Liczbe Ponownie: ");
                }
            } while (con != "wkoncu");
            return Num;
        }
    }
    class Equastions : IDzialania
    {

        public string Oper(string Operator)
        {
            string exit = "";
            Console.WriteLine("Prosze nacisnac Operatora Dzialania: ");
            Console.WriteLine("-");
            Console.WriteLine("+");
            Console.WriteLine("*");
            do
            {
                Operator = Console.ReadLine();
                if (Operator.Equals("+"))
                {
                    exit = "exit";
                    return Operator = "+";
                }
                else if (Operator.Equals("-"))
                {
                    exit = "exit";
                    return Operator = "-";
                }
                else if (Operator.Equals("*"))
                {
                    exit = "exit";
                    return Operator = "*";
                }
                else
                {
                    Console.WriteLine("Niepoprawny wybor, wybierz +,- lub * ");
                }
            } while (exit != "exit");
            return Operator;
        }
        public int Dzialanie(int FirstNum,int SecondNum,string Operator)

        {
            int Wynik=0;

            if (Operator.Equals("+"))
            {
                Wynik = FirstNum + SecondNum;
                Console.WriteLine("Wynik działania to: " + Wynik + "");
                Console.ReadKey();

            }
            else if (Operator.Equals("-"))

            {

                Wynik = FirstNum - SecondNum;
                Console.WriteLine("Wynik działania to: " + Wynik + "");
                Console.ReadKey();
            }
            else if (Operator.Equals("*"))
            {
                Wynik = FirstNum * SecondNum;
                Console.WriteLine("Wynik działania to: " + Wynik + "");
                Console.ReadKey();
            }
            return Wynik;
      
        }

        }
    interface IDzialania
    {
        int Dzialanie(int FirstNum, int SecondNum, String Operator);
    }
}
    

