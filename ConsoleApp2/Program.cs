using System;
using System.Collections;
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










            /**            Point2D point2D = new Point2D();
                        Console.WriteLine(point2D);
                        point2D++;
                        ++point2D;
                        Console.WriteLine(point2D);

                        Console.WriteLine(point2D + new Point2D(15,45));

                        Console.WriteLine(point2D + 15);
                        Console.WriteLine(45 + point2D);

                        Console.WriteLine(point2D == point2D);
                        Console.WriteLine(point2D != point2D);

                        if (point2D)
                        {
                            Console.WriteLine("Точка в положительном простанстве.");
                        }
                        else
                        {
                            Console.WriteLine("Точка в отрицательном простанстве.");
                        }*/

            /*Random rnd = new Random();
            string[] Names = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska"};*/


            // Generate random indexes for pet names.
            //int Index = rnd.Next(Names.Length);


            /*Random random = new Random();
            ListOfWorkers listOfWorkers = new ListOfWorkers();
            for (int i = 0; i < 5; i++)
            {
                listOfWorkers.AddWorker(new Worker(
                                         Names[rnd.Next(0,Names.Length)],
                                        "tested",
                                        "tested",
                                        DateTime.Now,
                                        Gender.MALE,
                                        Nationality.Argentina,
                                        EducationLevel.Higher,
                                        random.Next(2500, 5500),
                                        "Рабоатет."));
            }*/

            /*Worker worker_1 = new Worker("Макс", "", "", DateTime.Now, Gender.MALE, Nationality.Argentina,
                                        EducationLevel.Higher, 2500, "работаю.");
            Console.WriteLine(worker_1);
            Worker worker_2 = worker_1; // ссылка.

            worker_2.Name = "Максимилиан";
            Console.WriteLine(worker_1);
            Console.WriteLine(worker_2);

            //ICloneable - что бы объект смог создавать копию самого себя


            Worker worker_3 = (Worker)worker_1.Clone();
            worker_3.Name = "Макс";
            worker_3.Surname = "Имануилов";
            worker_3.Patronymic = "Владимирович";
            //worker_3.BirthDate = "Макс";
            Console.WriteLine(worker_3);

            Worker worker_4 = (Worker)worker_3.Clone(CloneNameMethod.Complete);
            worker_4.Name = "Маклауд";*/

            /*Console.WriteLine(worker_4.Name);
            Console.WriteLine(worker_3.Name);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(worker_4);
            Console.WriteLine(worker_3);*/

            /*Console.ForegroundColor = ConsoleColor.Green;
            IWorker[] tmp = listOfWorkers.Workers;
            Array.Sort(tmp, new WorkerSalaryDescComparer());

            foreach (Worker worker in tmp)
            {
                Console.WriteLine(worker);
            }
            Console.ResetColor();*/

            /*foreach (Worker worker in tmp)
            {
                Console.WriteLine(worker);
            }*/


            /*listOfWorkers[5] = new Worker();
            Console.WriteLine(((Worker)listOfWorkers[5]).Name); // по индексу.

            Console.WriteLine(((Worker)listOfWorkers[listOfWorkers.Workers[5]]).Name);// через ссылку на объект.
            listOfWorkers[listOfWorkers.Workers[6]] = new Worker();
            Console.WriteLine(((Worker)listOfWorkers[listOfWorkers.Workers[6]]));*/

            //*****************************


            /*foreach (IWorker worker in listOfWorkers)
            {

            }*/
            //Random random = new Random();
            /*int[] arr = new int[25];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 10);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();*/

            /* IEnumerable  Возвращает GenEnumerator()
                
                IEnumerable
                    : MoveNext()
                    : object Current {get; }
                    : void Reset()
             
            */

            /*Console.WriteLine("Через IEnumerator: ");
            IEnumerator ieArr = arr.GetEnumerator();
            while (ieArr.MoveNext())
            {
                int item = (int)ieArr.Current;
                Console.Write(item + " ");
            }
            ieArr.Reset();
            Console.WriteLine();

            foreach (Worker item in listOfWorkers)
            {
                Console.WriteLine(item);
            }

            Worker worker_1 = new Worker("Макс", "", "", DateTime.Now, Gender.MALE, Nationality.Argentina,
                                        EducationLevel.Higher,2500, "работаю.");

            Worker worker_2 = worker_1; // ссылка.

            worker_2.Name = "Максимилиан";
            Console.WriteLine(worker_1);
            Console.WriteLine(worker_2);

            *//*ICloneable - что бы объект смог создавать копию самого себя*//*


            Worker worker_3 = (Worker)worker_1.Clone();
            worker_3.Name = "Новое имя";
            Console.WriteLine(worker_3);

            Worker worker_4 = (Worker)worker_3.Clone(CloneNameMethod.Complete);
            worker_4.Name = "Маклауд";

            Console.WriteLine(worker_4.Name);
            Console.WriteLine(worker_3.Name);*/
            /*************************************************************************************************/
            /* Задействуется страндартная сортировка - default - по возрастанию.
                
                int string
                IComperable

                int CompareTo(Object 0){
                    < 0 текущее значение идет первым - левее от сравниваемого
                    > 0 текущее значение идет вторым - после сравниваемого
                    == 0 значит что значения равны
                }
             */

            /* Используется стандартная сотрировка - но переопределенная нами -- наоборот - по ниспаданию */
            /*Array.Sort(listOfWorkers.Workers);
            foreach (Worker worker in listOfWorkers.Workers)
            {
                Console.WriteLine(worker);
            }*/

            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            /*Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Сортировка по зарплате - по ниспаданию.");

            IWorker[] tmp = listOfWorkers.Workers;
            Array.Sort(tmp, new WorkerSalaryDescComparer());

            foreach (Worker worker in tmp)
            {
                Console.WriteLine(worker);
            }
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Сортировка по зарплате - по возрастанию.");
            //IWorker[] tmp_1 = listOfWorkers.Workers;
            Array.Sort(tmp, new WorkerSalaryAscComparer());

            foreach (Worker worker in tmp)
            {
                Console.WriteLine(worker);
            }
            Console.ResetColor();*/

            /*Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Сортировка Имени - по ниспаданию.");
            IWorker[] tmp_1 = listOfWorkers.Workers;
            Array.Sort(tmp_1, new WorkerNameDescComparer());

            foreach (Worker worker in tmp_1)
            {
                Console.WriteLine(worker);
            }
            Console.ResetColor();*/
            // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            //Console.WriteLine(listOfWorkers);

            /*            for (int i = listOfWorkers.Count - 1; i >= 0; i--)
                        {
                            listOfWorkers.RemoveWorker(listOfWorkers.Workers[i]);
                        }*/
            /*for (int i = 0; i < 25; i++)
            {
                listOfWorkers.RemoveWorker(listOfWorkers.Workers[0]);
            }*/



            //Console.WriteLine(listOfWorkers);


            /*            Worker worker = new Worker("Владимир", "Полтавченко", "Русланович", new DateTime(1979, 11, 28),
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
                        Console.WriteLine(employee);   */


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

                /*Point3D<int> point3Dint = new Point3D<int>();
                Console.WriteLine(point3Dint);
                Point3D<decimal> point3Ddec = new Point3D<decimal>(0.0005m, 0.0003m, 0.0001m);
                Console.WriteLine(point3Ddec);

                Point3D<int>[] point3Darr = new Point3D<int>[10];
                for (int i = 0; i < point3Darr.Length; i++)
                {
                    point3Darr[i] = new Point3D<int>(1, 2, 3);
                    Console.WriteLine(point3Darr[i]);
                }

                MyTwoParameter<Guid, Worker> myTwoParameter = new MyTwoParameter<Guid, Worker>();
                myTwoParameter.Key = Guid.NewGuid();
                myTwoParameter.Value = new Worker("Макс", "Пушкин", "Максимович", DateTime.Now,
                                                  Gender.MALE, Nationality.Argentina,
                                                  EducationLevel.Higher, 2500, "работаю.");



                Console.WriteLine(myTwoParameter);

                Console.ForegroundColor = ConsoleColor.Green;
                MyTwoParameter<Guid, Worker>[] myTwoParameter_arr = new MyTwoParameter<Guid, Worker>[5];

                for (int i = 0; i < myTwoParameter_arr.Length; i++)
                {
                    myTwoParameter_arr[i] = new MyTwoParameter<Guid, Worker>();
                    myTwoParameter_arr[i].Key = Guid.NewGuid();
                    myTwoParameter_arr[i].Value = new Worker("Макс", "Пушкин", "Максимович", DateTime.Now,
                                                      Gender.MALE, Nationality.Argentina,
                                                      EducationLevel.Higher, 2500, "работаю.");
                    Console.WriteLine(myTwoParameter_arr[i]);
                }
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("**********************************************");
                CalcInt calcInt = new CalcInt(15);
                Console.WriteLine(calcInt);

                calcInt = calcInt.Div(new CalcInt(90), new CalcInt(45));
                Console.WriteLine(calcInt);
                calcInt = calcInt.Sum(new CalcInt(90), new CalcInt(45));
                Console.WriteLine(calcInt);
                calcInt = calcInt.Multy(new CalcInt(90), new CalcInt(45));
                Console.WriteLine(calcInt);
                calcInt = calcInt.Substr(new CalcInt(90), new CalcInt(45));
                Console.WriteLine(calcInt);*/

                // Обобщенный тип - парамертезированную коллекцию.
                // Bozing - unboxing - низкая производительность + безопасность типов.
                // ArratList - List<>
                // HashTable - DiCtionary<key, value>
                // SortedList - SortedList<>


                /*ArrayList employeers = new ArrayList();
                employeers.Add(new Tutor());
                employeers.Add(new Worker());
                employeers.Add(new Worker());
                employeers.Add(new Tutor());
                employeers.Add(new Meneger());

                Console.WriteLine(employeers.Count); // кол-во элементов в списке.
                Console.WriteLine(employeers.Capacity); // 

                foreach (var item in employeers)
                {
                    if (item is Tutor)
                    {
                        Console.WriteLine((Tutor)item);
                    }
                    else if (item is Worker)
                    {
                        Console.WriteLine((Worker)item);
                    }
                    else if (item is Meneger)
                    {
                        Console.WriteLine((Meneger)item);
                    }
                }*/
                //***************************************************************************************
                
                Console.ForegroundColor = ConsoleColor.Green;
                Random random = new Random();
                string[] Names = { "Владимир", "Алексей", "Макс", "Дмитрий",
                          "Роман", "Олег"};                
                string[] Surname = { "Петров", "Иванов", "Васёв", "Пушкин",
                          "Галкин", "Шевченко"};                
                string[] Patromymic = { "Владимирович", "Алексеевич", "Максимович", "Дмитрович",
                          "Романович", "Олегович"};

                List<Worker> workerslist = new List<Worker>();

                for (int i = 0; i < 5; i++)
                {
                    workerslist.Add(new Worker(
                                            Names[random.Next(0, Names.Length)],
                                            Surname[random.Next(0, Names.Length)],
                                            Patromymic[random.Next(0, Names.Length)],
                                            DateTime.Now,
                                            Gender.MALE,
                                            Nationality.Argentina,
                                            EducationLevel.Higher,
                                            random.Next(2500, 5500),
                                            "Рабоатет."));
                }
               
                foreach (var item in workerslist)
                {
                    if(item is Worker)
                    {
                        Console.WriteLine(item);
                    }
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Сортировка по зарплате - по возрастанию.");
                /*IWorker[] tmp = workerslist.;
                List<IWorker>[] tmp1 = workerslist.List<Worker>;*/

                //workerslist.Sort(new WorkerSalaryAscComparer());
                workerslist.Sort(new WorkerNameAscComparerT());

                foreach (var item in workerslist)
                {
                    if (item is Worker)
                    {
                        Console.WriteLine(item);
                    }
                }
                Console.ResetColor();


                /*IWorker[] tmp = listOfWorkers.Workers;
                Array.Sort(tmp, new WorkerSalaryDescComparer());

                foreach (Worker worker in tmp)
                {
                    Console.WriteLine(worker);
                }*/
                //List<Worker>
                //заполнить
                //отобразить
                //отсортировать
                //отобразить отсортированные



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
