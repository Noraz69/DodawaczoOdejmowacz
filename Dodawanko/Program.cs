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

            Console.WriteLine("Witamy w DodawaczoOdejmowaczu");
            Console.WriteLine("Prosze wpisac Pierwsza liczbe: ");
            Numbers FirstNumber = new Numbers();
            int FirstNum =FirstNumber.TakeNumber(Num);
            Console.WriteLine("Prosze nacisnac Operatora Dzialania: ");
            Console.WriteLine("-");
            Console.WriteLine("+");
            Equastions Op = new Equastions();
            string Opera = Op.Oper(Operator);
            Console.WriteLine("Prosze wpisac druga liczbe: ");
            Numbers SecondNumber = new Numbers();
            int SecondNum = SecondNumber.TakeNumber(Num);
            Equastions End = new Equastions();
            End.Counting(FirstNum, SecondNum, Opera);

        }
    }
    class Numbers
    {
        String Number = "";
        String con = "";

        public int TakeNumber(int Num)

        {
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
    class Equastions
    {

        public string Oper(string Operator)
        {
            string exit = "";
            
            do
            {
                Operator = Console.ReadLine();
                if (Operator.Equals("+"))
                {
                    exit = "exit";
                    return Operator ="+";
                }
                else if (Operator.Equals("-"))
                {
                    exit = "exit";
                    return Operator ="-";
                }
                else
                {
                    Console.WriteLine("Niepoprawny wybor, wybierz + lub -");
                }
            } while (exit != "exit");
            return Operator;
        }

        public void Counting(int FirstNum, int SecondNum, string Operator)
        {
            int wynik;
            if (Operator.Equals("+"))
            {
                wynik = FirstNum + SecondNum;
                Console.WriteLine("Wynik Odejmowania : " + wynik + " ");
                Console.WriteLine("Prosze nacisnac dowolny klawisz by zakonczyc");
                Console.ReadKey();

            }
            else if (Operator.Equals("-"))

            {
                wynik = FirstNum - SecondNum;
                Console.WriteLine("Wynik Odejmowania : " + wynik + " ");
                Console.WriteLine("Prosze nacisnac dowolny klawisz by zakonczyc");
                Console.ReadKey();
            }
        }
    }
}