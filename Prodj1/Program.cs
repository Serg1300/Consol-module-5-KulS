using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prodj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ShowPrint();
            Console.ReadKey();
        }


        static bool ChekNum(string number, out int corrnumber, out string answer)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum >= 0)
                {
                    corrnumber = intnum;
                    answer = "Ответ принят.";
                    return false;
                }
            }
            {
                corrnumber = 0;
                answer = "Ответ не принят, введите цифры.";
                return true;
            }
        }

        static bool ChekName(string number, out string corrnumber, out string answer)
        {
            if (int.TryParse(number, out int intnum))
            {
                if (intnum >= 0)
                {
                    corrnumber = "нет";
                    answer = "Ответ не принят, введите буквы.";
                    return true;
                }
            }
            {
                corrnumber = number;
                answer = "Ответ принят.";
                return false;
            }
        }

        static int EnterNumbers(string word)
        {
            string otvet = " ";
            string age;
            int intage;
            do
            {
                Console.WriteLine(otvet);
                Console.WriteLine("Введите " + word);
                age = Console.ReadLine();
            } while (ChekNum(age, out intage, out otvet));
            Console.WriteLine(otvet);
            return intage;
        }

        static string EnterName(string word)
        {
            string otvet = " ";
            string name;
            string intage;
            do
            {
                Console.WriteLine(otvet);
                Console.WriteLine("Введите " + word);
                name = Console.ReadLine();
            } while (ChekName(name, out intage, out otvet));
            Console.WriteLine(otvet);
            return intage;
        }

        static string[] AddName (int num)
        {
            var result = new string[num];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = Console.ReadLine();
            }
            return result;
        }

        static (string Name, string LastName, int Age, string[] PetsName, string[] FavoriteColor) EnterUser()
        {
            (string Name, string LastName, int Age, string[] PetsName, string[] FavoriteColor) User;

            User.Name = EnterName("Имя");           
            User.LastName = EnterName("Фамилию");
            User.Age = EnterNumbers("ваш возраст цифрами");
            User.PetsName = new string[1];
            User.FavoriteColor = new string[1];
            int PetsNumber = EnterNumbers("сколько у вас домашних питомцев цифрами");            
            if (PetsNumber > 0)
            {
                Console.WriteLine("Введите имена питомцев");
                User.PetsName = AddName(PetsNumber);
            }
            else
            {
                User.PetsName[0] = "нет";
            }
            
            int ColorNumber = EnterNumbers("сколько у вас любимых цветов цифрами");
            if (ColorNumber > 0)
            {
                Console.WriteLine("Введите цвета");
                User.FavoriteColor = AddName(ColorNumber);
            }
            else
            {
                User.FavoriteColor[0] = "нет";
            }            
            return User;
        }
        
        static void ShowPrint()
        {
            var User = EnterUser();
            Console.WriteLine("");
            Console.WriteLine("    Данные пользователя");
            Console.WriteLine("Имя пользователя: " + User.Name);
            Console.WriteLine("Фамилия пользователя: " + User.LastName);
            Console.WriteLine("Возраст: " + User.Age);
            Console.WriteLine("Питомцы пользователя:");
            foreach (var item in User.PetsName) { Console.WriteLine(item); }
            Console.WriteLine("Любимые цвета пользователя:");
            foreach(var item in User.FavoriteColor) { Console.WriteLine(item); }

        }



    }
}
