using System;



namespace translation
{
  class Program
  {
    static void Main(string[] args)
    {
      string choise;
      while (true)
      {
        Console.WriteLine("1. Перевести из двоичной в десятичную");
        Console.WriteLine("2. Перевести из десятичной в двоичную");
        Console.WriteLine("3. Выйти");
        Console.Write("Ваш выбор: ");
        choise = Console.ReadLine();
        Console.Clear();
        switch (choise)
        {
          case "1":
            Console.Write("Введите число (для дробных разделитель . ): ");
            string binaryNumber = Console.ReadLine();
            int separator = -1; // Переменная для хранения номера ячейки разделителя
            for(int i = 0; i < binaryNumber.Length; i++)
            {
              if (binaryNumber[i] != '1' && binaryNumber[i] != '0' && binaryNumber[i] != '.')
              {
                Console.WriteLine("Ошибка ввода!");
                break;
              }
              if (binaryNumber[i] == '.') separator = i;
            }
            double result = 0;
            if (separator != -1)
            {
              for(int i = 0; i < separator; i++)
              {
                double preResult = (binaryNumber[separator - i - 1] - '0') * Math.Pow(2, i);
                result += preResult;
              }
              int counter = -1;
              for(int i = separator+1; i < binaryNumber.Length; i++)
              {
                double preResult = (binaryNumber[i] - '0') * Math.Pow(2, counter);
                counter--;
                result += preResult;
              }
            
            } else
            {
              for(int i = binaryNumber.Length-1; i >= 0; i--)
              {
                double preResult = (binaryNumber[i] - '0') * Math.Pow(2, binaryNumber.Length-1-i);
                result += preResult;
              }
            }
            Console.Write("Введённое число в десятичной системе счисления: ");
            Console.WriteLine(result);

            Console.ReadLine();
            Console.Clear();
            break;



          case "2":

            Console.Write("Введите число: ");
            string decimalNumber = Console.ReadLine();
            int intDecimalNumber = Int32.Parse(decimalNumber);
            
            string result2 = "";
            while (intDecimalNumber > 0)
            {
              result2 = ((intDecimalNumber % 2 == 0) ? "0" : "1") + result2;
              intDecimalNumber /= 2;
            }

            Console.Write("Введённое число в двоичной системе счисления: ");
            Console.WriteLine(result2);

            Console.ReadLine();
            Console.Clear();
            break;
          
          
          
          case "3":
            return;
        }
      }
    }
  }
}
