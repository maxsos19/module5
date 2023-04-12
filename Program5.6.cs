using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._6
{
    class Program
    {   
        static void Main(string[] args)
        {
            PrintResults();
            Console.ReadKey();
        }
        public static void PrintResults()
        {
            (string Name, string LastName, int Age, string[] petsArray, string[] favouriteColors) data = createTuple();

            Console.WriteLine("Ваше имя: " + data.Name);
            Console.WriteLine("Ваша фамилия: " + data.LastName);
            Console.WriteLine("Ваш возраст: " + data.Age);


            Console.WriteLine("Клички ваших домашних животных");
            for (int i = 0; i < data.petsArray.Length; i++)
            {
                Console.WriteLine(data.petsArray[i]);
            }

            Console.WriteLine("Любимые цвета: ");
            for (int i = 0; i < data.favouriteColors.Length; i++)
            {
                Console.WriteLine(data.favouriteColors[i]);
            }
        }

        static string[] ShowColor()
        {
            Console.WriteLine("Сколько у вас любимых цветов?");
            
            int qantity = int.Parse(Console.ReadLine());
            var color = new string[qantity];

            for (int i = 0; i < color.Length; i++)
            {
                if (qantity == 0)
                {
                    break;
                }
                Console.WriteLine("Введите цвет: ");
                color[i] = Console.ReadLine();
            }
            return color;
        }
        public static (string Name, string LastName, int Age, string[] petsArray, string[] favouriteColors) createTuple()
        {
            (string Name, string LastName, int Age) user = EnterUser();
            string[] petsArray = CreateArrayPets();
            string[] favouriteColors = ShowColor();

            (string Name, string LastName, int Age, string[] petsArray, string[] favouriteColors) data;
            data.Name = user.Name;
            data.LastName = user.LastName;
            data.Age = user.Age;
            data.petsArray = petsArray;
            data.favouriteColors = favouriteColors;

            return data;  
        }

        static (string Name, string LastName, int Age) EnterUser()
        {
            (string Name, string LastName, int Age) user;

            Console.WriteLine("Введите имя");
            user.Name = Console.ReadLine();

            Console.WriteLine("Введие фамилию");
            user.LastName = Console.ReadLine();

            string age;
            int intage;

            do
            {
                Console.WriteLine("Введите возраст цифрами");
                age = Console.ReadLine();
            } while (CheckNum(age, out intage));

            user.Age = intage;
            return user;
        }

        static string[] CreateArrayPets()
        {
            Console.WriteLine(" Если у вас есть домашние животные введите их число");
            int num = int.Parse(Console.ReadLine());
            var result = new string[num];
            if (num != 0)
            {
                for (int i = 0; i < result.Length; i++)
                {
                    Console.WriteLine("Введите кличку животного");
                    result[i] = Console.ReadLine();


                }
               
            }
            else 
            {
                Console.WriteLine("У вас нет домашних питомцев");
            }
            return result;
           
        
        }

        static bool CheckNum(string number, out int corrnumber)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum > 0)
                {
                    corrnumber = intnum;
                    return false;
                }
            }
            {
                corrnumber = 0;
                return true;
            
            }
        
        
        }
        static void Data()
        {
            Console.WriteLine("Ваше имя: ");
        
        
        }
    }   
    
}
