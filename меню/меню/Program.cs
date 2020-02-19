using System;

namespace меню
{
    class Program
    {
        public static void Main (string[] args)
        {
            int i;

            {

                {
                    Console.Write("Меню:\n1) Имя \n2) Фамилия \n3) Возраст \nВведите номер: ");
                    i = int.Parse(Console.ReadLine());
                    switch (i)
                    {
                        case 1:
                            Console.WriteLine("Введите имя");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Введите фамилию ");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Введите возраст");
                            Console.ReadLine();
                            break;
                    }
                            
                    Console.Write("\nНажмите любую клавишу, чтобы выйти: ");
                    Console.ReadLine();
                    Console.Clear();
                }

            }
        }
    }
}