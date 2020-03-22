using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseWork.Models;

namespace CourseWork.Data
{
    public static class DbInitializer
    {
        public static void Initialize(Construction_Context db)
        {
            Random random = new Random();

            db.Database.EnsureCreated();

            if (db.Customers.Any() || db.Orders.Any() || db.Materials.Any() || db.Teams.Any() || db.Positions.Any() || db.Workers.Any()
                 || db.ListMaterials.Any() || db.TypeOfWorks.Any())
            {
                return;
            }

            int customersNumber = 100;
            int materialsNumber = 100;
            int teemsNumber = 100;
            int workerNumber = 100;
            int listMatNumber = 100;
            int typeOfworkNumber = 100;
            int orderNumber = 100;
            int positionNumber = 6;

            string[] customersNames = { "Евгений", "Роман", "Иван", "Андрей", "Николай", "Александр", "Алексей", "Анатолий",  "Константин",
                                        "Валерий", "Даниил", "Кирилл", "Степан", "Максим", "Юрий"};
            string[] customersMiddleName = { "Григорьевич", "Иванович", "Петрович", "Сергеевич", "Николаевич", "Михайлович", "Анатольевич",
                                                "Данилович", "Дмитриевич", "Васильевич", "Леонидович","Максимович"};

            string[] customersSurnames = { "Шулякевич", "Шепелевич", "Федоренко", "Черняков", "Михайлов", "Гончар", "Вакулин", "Стельченко", "Елисеев", "Романов",
                                            "Малиновский", "Котов", "Калинин", "Григорьев", "Суворов", "Синицин", "Савенко"};

            string[] passportSeries = { "НВ", "АВ", "ВМ", "КН", "МР", "МС", "КВ" };
            string[] materialNames = { "Цемент", "Доска", "Шпаклевка", "Пенопласт", "Клей", "Плитка", "Краска", "Фанера", "Гипсокартон", "Ламинат", "Линолеум", "Гипс", "Обои" };
            string[] descriptionsMaterials = { "Защита", "Сцепление", "Декор", "Утепление", "Покрытие" };
            string[] nameTypes = { "Покраска стен", "Штрукатурка стен", "Утепление стен", "Укладка половой доски", "Укладка пола", "Поклейка обоев" };

            string[] descriptionsTypes = { "Покраска стен", "Штрукатурка стен", "Утепление стен", "Укладка половой доски", "Укладка пола", "Поклейка обоев" };

            string[] streetNames = { "Садовая", "Ленина", "Первомайская", "Гагарина", "Советская", "Пушкина" };

            string[] Positions = { "Обойщик", "Подсобный рабочий", "Маляр", "Штукатур", "Укладчик ", "Шпаклевщик" }; 
            
            for (int i = 0; i < teemsNumber; i++)
            {
                StringBuilder name = new StringBuilder();
                name.Append("Бригада ").Append(random.Next(1, 100));

                db.Teams.Add(new Team
                {
                    TeamName = name.ToString()
                }
                );
            }
            db.SaveChanges();

            for (int i = 0; i < positionNumber; i++)
            {
                StringBuilder name = new StringBuilder();
                name.Append("Бригада ").Append(random.Next(1, 100));

                db.Positions.Add(new Position
                {
                    PositionName = Positions[i]
                }
                );
            }
            db.SaveChanges();

            for (int i = 0; i < workerNumber; i++)
            {
                StringBuilder name = new StringBuilder();
                name.Append("ул. ").Append(getRandomString(streetNames, random)).Append(", ").Append(random.Next(1, 100));

                string male = (random.Next(0, 2) == 1 ? "м" : "ж");
                db.Workers.Add(new Worker
                {
                    Surname = getRandomString(customersSurnames, random).ToString(),
                    Name = getRandomString(customersNames, random).ToString(),
                    MiddleName = getRandomString(customersMiddleName, random).ToString(),
                    Age = Convert.ToInt32(random.Next(18, 55)),
                    Sex = male,
                    Adress = name.ToString(),
                    Phone = (random.Next(1000000, 9999999)).ToString(),
                    Passport = getRandomString(passportSeries, random).ToString() + Convert.ToInt32(random.Next(1000000, 9999999)).ToString(),
                    PositionId = Convert.ToInt32(random.Next(1, positionNumber)),
                    TeamId = Convert.ToInt32(random.Next(1, teemsNumber - 1)),
                }
                );
            }
            db.SaveChanges();


            for (int i = 0; i < materialsNumber; i++)
            {
                StringBuilder name = new StringBuilder();
                name.Append(getRandomString(materialNames, random));
                db.Materials.Add(new Material {
                    MaterialName = name.ToString(),
                    Description = getRandomString(descriptionsMaterials, random),
                    Price = random.Next(1000, 2000) });
            }
            db.SaveChanges();

            for (int i = 0; i < typeOfworkNumber; i++)
            {
                db.TypeOfWorks.Add(new TypeOfWork
                {
                    WorkName = getRandomString(nameTypes, random).ToString(),
                    Description = getRandomString(nameTypes, random),
                    Price = random.Next(1000, 2000)
                });
            }
            db.SaveChanges();

            for (int i = 0; i < listMatNumber; i++)
            {
                db.ListMaterials.Add(new ListMaterial
                {
                    MaterialId = Convert.ToInt32(random.Next(1, materialsNumber)),
                    TypeOfWorkId = Convert.ToInt32(random.Next(1, typeOfworkNumber))
                });
            }
            db.SaveChanges();

            for (int i = 0; i < customersNumber; i++)
            {
                StringBuilder name = new StringBuilder();
                name.Append("ул. ").Append(getRandomString(streetNames, random)).Append(", ").Append(random.Next(1, 100));

                db.Customers.Add(new Customer
                {
                    Surname = getRandomString(customersSurnames, random).ToString(),
                    Name = getRandomString(customersNames, random).ToString(),
                    MiddleName = getRandomString(customersMiddleName, random).ToString(),
                    Adress = name.ToString(),
                    Phone = Convert.ToInt32(random.Next(1000000, 9999999)).ToString(),
                    Passport = getRandomString(passportSeries, random).ToString() + Convert.ToInt32(random.Next(1000000, 9999999)).ToString()
                }
                );
            }
            db.SaveChanges();

            for (int i = 0; i < orderNumber; i++)
            {
                DateTime date1 = new DateTime(2015, 7, 20);
                int start = Convert.ToInt32(random.Next(-30, 28));
                int finish = Convert.ToInt32(random.Next(start, 30));

                bool status = true;
                bool statuspay = true;

                int s1 = Convert.ToInt32(random.Next(0, 2));
                int s2 = Convert.ToInt32(random.Next(0, 2));
                if ( s1 == 0)
                {
                    status = false;
                }
                if (s2 == 0) statuspay = false;


                db.Orders.Add(new Order
                {
                    CustomerId = Convert.ToInt32(random.Next(1, customersNumber)),
                    TypeOfWorkId = Convert.ToInt32(random.Next(1, customersNumber)),
                    TeamId = Convert.ToInt32(random.Next(1, customersNumber)),
                    Price = random.Next(1000, 2000),
                    StartDate = date1.AddDays(start),
                    FinishDate = date1.AddDays(finish),
                    ComplectionStatus = status,
                    PayStatus = statuspay
                }
                );
            }
            db.SaveChanges();
        }

        private static string getRandomString(string[] array, Random random)
        {
            return array[random.Next(0, array.Length)];
        }
    }
}