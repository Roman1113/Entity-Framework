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

            using (EFContext context = new EFContext())
            {
                int action = 0;
                do
                {
                    Console.WriteLine("0. Вихід");
                    Console.WriteLine("1. Додати клас тварин");
                    Console.WriteLine("2. Показати клас тварин");
                    Console.Write("----->");
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
                                Console.WriteLine("-------------");
                                foreach (var aType in context.AnimalTypes)
                                {
                                    Console.WriteLine($"{aType.Id} - {aType.Name}");
                                    Console.WriteLine("---------------");
                                }
                            }break;
                        default:
                            break;
                    }
                } while (action != 0);
            }
        }
    }
}
