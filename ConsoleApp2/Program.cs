using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker("Владимир", "Полтавченко", "Русланович", new DateTime(1979, 11, 28),
                                            Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                            "Колоть дрова");
            Console.WriteLine(worker);
            if (!worker.IsWorking)
            {
                worker.NextTask("Выпить кофе");
            }
            worker.StopWorking();
            worker.NextTask("Потупить.");
            Console.WriteLine(worker.Work());
            worker.StopWorking();
            worker.NextTask("Колоть дрова.");
            Console.WriteLine(worker.Work());

            // *******************

            Tutor tutor = new Tutor();
            Console.WriteLine(tutor);
            tutor.Show();

            Tutor tutor_two = new Tutor("Владимир", "Полтавченко", "Русланович", new DateTime(1979, 11, 28),
                                            Gender.MALE, Nationality.Ukrainian, EducationLevel.Higher, 15000,
                                            TutorSpeciality.Hystorian);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(tutor_two);

            // --------------------------

            Director director = new Director("Владимир", "Полтавченко", "Русланович", new DateTime(1979, 11, 28),
                                            Gender.MALE, Nationality.Ukrainian, DirectorLevel.Financial_Director, 15000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(director);
            Meneger meneger = new Meneger("Григорий", "Лепс", "Владимирович", new DateTime(1985, 8, 11),
                                            Gender.MALE, Nationality.Russian, EducationLevel.Higher, 2500,
                                            ManagerLevel.JuniorManagers, 235);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(meneger);
            Employee employee = new Employee("Василий", "Петров", "Андреевич", new DateTime(1990, 10, 25),
                                            Gender.MALE, Nationality.English, EducationLevel.Secondary, 1000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(employee);   
            

            /*          Human human = new Human("Морко", "Поло", "Иммунаилович", new DateTime(1990, 10, 25), Gender.MALE, Nationality.English);
                      Console.WriteLine(human);*/
            /*Human human = new Human();
            Console.WriteLine(human);*/
            /*            Human human = new Human();     // Экземпляр класса.
                        Console.WriteLine(human.ToString());
                        Console.WriteLine(human.gender);
                        Console.WriteLine(human.nationality);
                        Console.WriteLine(human.Name); // поле - чтение.
                        human.Name = "Вася";           // поле - запись.
                        Console.WriteLine(human.Name);
                        Console.WriteLine(human.getName());*/

            try
            {
                // Клас абстрактный = нет возможности создать  его экземпляр.
                //Human human = new Human("Морко", "Поло", "Иммунаилович", new DateTime(1775, 10, 25), Gender.MALE, Nationality.English);
                //Employee employee = new Employee();
                //Console.WriteLine(employee);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Я ошибка , но прога не вылетела.");
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            //Console.WriteLine("Я программа и я все равно работаю.");
            Console.ResetColor();
        }
    }
}
