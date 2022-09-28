using System;

namespace Task_3
{
    public class Converter
    {
        private decimal dollarToHryvnia;
        private decimal euroToHryvnia;
        public Converter(decimal dollar, decimal euro)
        {
            dollarToHryvnia = dollar;
            euroToHryvnia = euro;
        }
        public decimal convertHryvniaToEuro(decimal uah)
        {
            return uah / euroToHryvnia;
        }
        public decimal convertHryvniaToDollar(decimal uah)
        {
            return uah / dollarToHryvnia;
        }
        public decimal convertEuroToHryvnia(decimal eur)
        {
            return eur * euroToHryvnia;
        }
        public decimal convertDollarToHryvnia(decimal dollar)
        {
            return dollar * dollarToHryvnia;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть курс долара по відношенню до гривні");
            decimal dollarCurr = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Введіть курс євро по відношенню до гривні");
            decimal euroCurr = Convert.ToDecimal(Console.ReadLine());
            Converter converter = new Converter(dollarCurr, euroCurr);
            bool cycle = true;
            do
            {
                Console.WriteLine("Введіть у яку валюту хочете конвертувати (євро/долар/гривня)");
                string currency = Console.ReadLine()!;
                if (currency == "євро")
                {
                    Console.WriteLine("Введіть кількість гривень");
                    decimal hryvnia = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Результат: {converter.convertHryvniaToEuro(hryvnia)}");
                }
                else if (currency == "долар")
                {
                    Console.WriteLine("Введіть кількість гривень");
                    decimal hryvnia = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine($"Результат: {converter.convertHryvniaToDollar(hryvnia)}");
                }
                else if (currency == "гривня")
                {
                    Console.WriteLine("Введіть яку валюту хочете конвертувати (євро/долар)");
                    string toCurrency = Console.ReadLine()!;
                    if (toCurrency == "євро")
                    {
                        Console.WriteLine("Введіть кількість євро");
                        decimal eur = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Результат: {converter.convertEuroToHryvnia(eur)}");
                    }
                    else if (toCurrency == "долар")
                    {
                        Console.WriteLine("Введіть кількість доларів");
                        decimal dollar = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine($"Результат: {converter.convertDollarToHryvnia(dollar)}");
                    }
                    else
                    {
                        Console.WriteLine("Таку валюту конвертер не конвертує");
                    }
                }
                else
                {
                    Console.WriteLine("У таку валюту конвертер не конвертує");
                }
                Console.WriteLine("Продовжити? (true/false)");
                if (bool.Parse(Console.ReadLine()!) == false)
                {
                    cycle = false;
                }
            }
            while (cycle);
            
            
        }
    }
}

