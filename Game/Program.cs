using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string weapon;
            int health = 5;
            
            Console.WriteLine("Введите имя игрока");

            name = Console.ReadLine();

            Console.WriteLine($"Приветствую тебя, {name}, в моей первой консольной игре! " +
                $"\nВ дальнейшем кликай Enter, когда строка пустая, чтобы продолжить");

            Console.ReadLine();

            Console.WriteLine("Для начала выбери тип оружия:\n1.Меч \n2.Лук \n3.Булава \n4.Маг");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                weapon = "Меч";
                Console.WriteLine("Меч? Смелый выбор!");
            }
            else if (userInput == "2")
            {
                weapon = "Лук";
                Console.WriteLine("Оооо любишь валить издалека, красава!");
            }
            else if (userInput == "3")
            {
                weapon = "Булава";
                Console.WriteLine("Булава? Человек месиво? То, что надо!");
            }
            else if (userInput == "4")
            {
                weapon = "Маг";
                Console.WriteLine("Опа! Рэйден это ты?!");
            }
            else
            {
                weapon = "Лесная фея";
                Console.WriteLine("Сегодня ты лесная фея");
            }
            Console.WriteLine("Ну что, теперь ты вооружен и можно валить гоблинов:)");

            Console.ReadLine();

            Console.WriteLine("Куда идем? 1.Север 2.Юг 3.Запад 4.Восток");

            string userInput2 = Console.ReadLine();
            string side;

            if (userInput2 == "1")
            {
                side = "Север";
                Console.WriteLine("Ну погнали на север!");
            }
            else if (userInput2 == "2")
            {
                side = "Юг";
                Console.WriteLine("Ну погнали на Юг!");
            }
            else if (userInput2 == "3")
            {
                side = "Запад";
                Console.WriteLine("Ну погнали на Запад!");
            }
            else if (userInput2 == "4")
            {
                side = "Восток";

                Console.WriteLine("О ужас, ты наткнулся на хижину гоблина и он запирает тебя в ней!... " +
                    "Но что это там? Ты видишь рассвет через дырочку в хижине и думаешь ...");

                Console.WriteLine("1. Надо что-то делать! 2. Просто постоять, может пройдет");

                string userInput3 = Console.ReadLine();

                if (userInput3 == "1")
                {
                    if (weapon == "Меч" | weapon == "Булава")
                    {
                        Console.WriteLine("Ты решаешь раздолбать дырочку своим устрашающим оружием, но" +
                            "стена оказалась куда прочнее и твое оружие ломается пополам");

                        weapon = null;
                    }
                    else if (weapon == "Маг")
                    {
                        Console.WriteLine("Ты пытаешься растянуть эту дырочку своими чародейскими " +
                            "способностями, но маг из тебя никакой и дырочка просто исчезла. Развернувшись, " +
                            "ты обнаруживаешь открытую дверь и выходишь (-1 к самооценке(здоровье))");

                        health = health - 1;
                    }
                    else if (weapon == "Лук")
                    {
                        Console.WriteLine("Ты решаешь выстрелить в это миниатюрное отверстие, промахиваешься " +
                            "и стрела рикошетит тебе прямо в левый глаз. Одним работающим глазом" +
                            "ты обнаруживаешь открытую дверь и выходишь забыв лук в хижине (-1 к здоровью");

                        health = health - 1;
                        weapon = null;
                    }
                }
                else if (userInput3 == "2")
                {
                    Console.WriteLine("Печалька, бедушка.. с тобой:(");
                }
            }
            Console.WriteLine("Идя себе спокойно вперед в поиске приключений, ты натыкаешься на разьяренного гоблина!");
            Console.ReadLine();
            Console.WriteLine("В недоумении, ты пытаешься сообразить: 1.Попробовать поговорить 2.Замочить грешного ");

            string userInput4 = Console.ReadLine();

            if (userInput4== "1")
            {
                Console.WriteLine("Ты решаешь поболтать немного о жизни с милым гоблиночком и: " +
                    "1. Рассказываешь анекдот 2. Спрашиваешь как пройти на вокзал птеродактелей");

                string userInput5 = Console.ReadLine();

                if (userInput5 == "1")
                {
                    Console.WriteLine("Не понимаю тебя дружок... как можно было решить поболтать.. ну ты умер((");
                }
                else if(userInput5 == "2")
                {
                    Console.WriteLine("Не понимаю тебя дружок... как можно было решить поболтать.. ну ты умер((");
                }
            }
            else if (userInput4 == "2")
            {
                Console.WriteLine("Ты решаешь атаковать жалкого!!! Спартааааааа!!");
                
                if (weapon == "Маг")
                {
                    Console.WriteLine("Ты наносишь невероятные любовные чары и гоблин улетает на лапах любви искать самку");
                    Console.ReadLine();
                    Console.WriteLine("Ты победил:) Иди купи пивка!");
                }
                else if( weapon == null )
                {
                    Console.WriteLine("У тебя же нет оружия... ну ты умер((");
                }
                else if ( weapon=="Лесная фея")
                {
                    Console.WriteLine("Ты взмахиваешь палочкой, превращаешься в птерадактеля и улетаешь пить вкусное пивко");
                }
            }
        }
    }
}
