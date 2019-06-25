using EntityBase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityBase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Default;
            Console.InputEncoding = System.Text.Encoding.Default;
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(1251);

            using (EFContext context = new EFContext())
            {
                int action = 0;
                do
                {
                    Console.WriteLine("0. Вихід");
                    Console.WriteLine("1. Додати клас тварин");
                    Console.WriteLine("2. Показати клас тварин");
                    Console.WriteLine("3. Додати користувача");
                    Console.WriteLine("4. Показати всіх користувачів");
                    Console.WriteLine("5. Редагувати користувача");
                    Console.WriteLine("6. Видалити користувача");
                    Console.Write("----->\n");
                    action = int.Parse(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            {
                                AnimalType animalType = new AnimalType();
                                Console.WriteLine("Вкажіть імя типу тварини");
                                animalType.Name = Console.ReadLine();
                                context.AnimalTypes.Add(animalType);
                                context.SaveChanges();
                            }break;
                        case 2:
                            {
                                foreach (var aType in context.AnimalTypes)
                                {
                                    Console.WriteLine($"{aType.Id} - {aType.Name}");
                                    Console.WriteLine("-------------");
                                }
                            }break;
                        case 3:
                            {
                                UsersList usersList = new UsersList();
                                Console.WriteLine("Вкажіть імя користувачча");
                                usersList.Name = Console.ReadLine();
                                context.Users.Add(usersList);
                                context.SaveChanges();
                            }break;
                        case 4:
                            {
                                foreach (var aType in context.Users)
                                {
                                    Console.WriteLine($"{aType.Id} - {aType.Name}");
                                    Console.WriteLine("-------------");
                                }
                            }break;
                        case 5:
                            {
                                
                            }
                            break;
                        case 6:
                            {
                                UsersList usersList = new UsersList();
                                context.Users.Remove(usersList);
                                context.SaveChanges();
                            }
                            break;
                        default:
                            break;
                    }
                } while (action != 0);
            }
        }
    }
}
