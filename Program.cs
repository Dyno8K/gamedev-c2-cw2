using System.IO;
int energy = 100;
int money = 0;
int day = 1;

static void decisions(int health, int energy, int money, int day)
{
    // HW 1:
    //Sorry shwaya t7mst
    static void attributes(int health, int energy, int money, int day)
    {
        Console.WriteLine("Money: {1} \nHealth: {0} \nEnergy: {2} \nDay: {3}", health, money, energy, day);
    }

    static int damaged(int health)
    {
        health -= 20;
        Console.WriteLine("Health decrease to : " + health);
        return health;
    }

    static int boost(int health)
    {
        health += 10;
        Console.WriteLine("Health increasesed to: " + health);
        return health;
    }

    static int loseEnergy(int energy)
    {
        energy -= 20;
        return energy;
    }

    static int gainEnergy(int energy)
    {
        energy = 100;
        Console.WriteLine("Energy restored");

        return energy;
    }

    static int[] sleep(int health)
    {
        int energy = 100;
        health += 20;
        int[] attributes = { health, energy };
        return attributes;

    }

    static int[] cop(int health, int money, int energy)
    {
        var random = new Random();
        var list = new List<string> { "1", "0", "1", "0", "1", "0", "0", "0", "0", "0", };

        int index = random.Next(list.Count);
        string luck = (list[index]);
        if (luck == "0")
        {
            Console.WriteLine("\nOh no! You have been caught. ");
            Console.WriteLine("You have lost 30 money, 20 energy and 10 health.");
            money -= 30;
            energy -= 20;
            health -= 10;
            Console.WriteLine("\nYou now have {0} money, {1} energy and {2} health", money, energy, health);
            int[] attributes = { health, money, energy };
            return attributes;
        }
        else if (luck == "1")
        {
            Console.WriteLine("\nYou have successfully stolen from the cop!");
            Console.WriteLine("You have gained 15 money and lost 5 energy.");
            money += 15;
            energy -= 5;
            Console.WriteLine("\nYou now have {0} money, {1} energy and {2} health", money, energy, health);
            int[] attributes = { health, money, energy };
            return attributes;
        }
        else
        {
            int[] attributes = { health, money, energy };
            return attributes;
        }

    }

    static int[] begged(int health, int money, int energy)
    {
        Console.WriteLine("You have chosen to beg. ");
        var random = new Random();
        var list = new List<string> { "1", "1", "1", "1", "1", "1", "1", "0", "0", "0", };

        int index = random.Next(list.Count);
        string luck = (list[index]);
        if (luck == "0")
        {
            Console.WriteLine("Oh well..No one gave you anything :( ");
            int[] attributes = { health, money, energy };
            return attributes;

        }
        else
        {
            var randoms = new Random();
            var lists = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

            int indexs = randoms.Next(list.Count);
            int gathering = (lists[indexs]);

            Console.WriteLine("Woo-hoo you have gathered ${0}", gathering);

            money += gathering;
            energy -= 1;
            Console.WriteLine("\nYou now have {0} money, {1} energy and {2} health", money, energy, health);
            int[] attributes = { health, money, energy };
            return attributes;


        }

    }

    static int[] bankRob(int health, int money, int energy)
    {
        Console.Write("You have chosen to rob a bank!?! Good luck");
        var random = new Random();
        var list = new List<string> { "1", "0", "0", "0", "0", "0", "0", "0", "0", "0", };

        int index = random.Next(list.Count);
        string impossible = (list[index]);

        if (impossible == "0")
        {
            Console.WriteLine("\nTold ya it was hard, see ya in jail");
            Console.WriteLine("You have lost 30 energy, 50 health and have payed a $30 Fine ");
            energy -= 30;
            health -= 50;
            money -= 30;
            int[] attributes = { health, money, energy };
            return attributes;
        }
        else
        {
            Console.WriteLine("YOU HAVE SUCCESFULLY ROBBED A BANK. Give yourself a pat on the back");
            Console.WriteLine("You have gained 5 energy and 100 money!");
            energy += 5;
            money += 100;
            int[] attributes = { health, money, energy };
            return attributes;
        }
    }

    static void lemonade(int health, int money, int energy, int day)
    {
        if (day % 7 == 0 || day % 6 == 0)
        {
            //not done
            var randoms = new Random();
            var lists = new List<int> { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, };

            int indexs = randoms.Next(lists.Count);
            int weekend = (lists[indexs]);

            Console.WriteLine("You have gained {0} money and lost 10 energy");

        }
    }

    bool repeat = true;
    do
    {
        Console.WriteLine("\nHey arthur welcome to day {0} of your life", day);
        Console.WriteLine("Choose a task for today");
        Console.WriteLine("\nTo output all possible commands type 'Commands'\n");

        string taskInput = Console.ReadLine();
        taskInput = taskInput.ToLower();
        if (taskInput == "commands")
        {
            Console.WriteLine("Commands(Type Number or full sentence):\n1.Rob a house\n2.Beg\n3.Rob a bank\n" +
                "4.Sell Lemonade\n5.View player atributes\n6.Sleep\n7.Visit shop\n8.Exit");

        }
        else if (taskInput == "8" || taskInput == "exit")
        {
            break;
        }
        else if (taskInput == "1" || taskInput == "rob a house")
        {
            Console.WriteLine("You have decided to rob a house: ");
            day += 1;
            Console.WriteLine("Who do you want to rob?");
            Console.WriteLine("1. Cop James\n2. Banker Joe\n3. Poor Neighbour\n4. Billionaire Frank");
            string robInput = Console.ReadLine();
            robInput = robInput.ToLower();
            if (robInput == "cop james" || robInput == "1")
            {
                int[] robList = cop(health, money, energy);
                health = robList[0];
                money = robList[1];
                energy = robList[2];
            }





        }
        else if (taskInput == "2" || taskInput == "beg")
        {
            day++;
            int[] begList = begged(health, money, energy);
            health = begList[0];
            money = begList[1];
            energy = begList[2];
        }
        else if (taskInput == "3" || taskInput == "rob a bank")
        {
            Console.WriteLine("\nAre you sure you want to rob a bank? Only the worthy can...");
            Console.WriteLine("If you choose to continue and fail, you will lose 30 energy, 50 health and 30 money");
            Console.WriteLine("\n Type 'Yes' to continue or 'No' to go back: ");
            string riskCheck = Console.ReadLine();
            riskCheck = riskCheck.ToLower();
            if (riskCheck == "yes")
            {
                day++;
                int[] bankList = bankRob(health, money, energy);
                health = bankList[0];
                money = bankList[1];
                energy = bankList[2];
            }
            else if (riskCheck == "no")
            {
                Console.WriteLine("Good choice XD");
            }
            else
            {
                Console.WriteLine("Invalid Input, 'No' will be assumed...");
            }

        }
        else if (taskInput == "4" || taskInput == "sell lemonade")
        {
            Console.WriteLine("You have chosen to sell lemonade: ");
        }
        else if (taskInput == "5" || taskInput == "view player attributes")
        {
            attributes(health, energy, money, day);
        }
        else if (taskInput == "6" || taskInput == "sleep")
        {
            day++;
            int[] sleepList = sleep(health);
            health = sleepList[0];
            energy = sleepList[1];
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    } while (repeat == true);


}

static string playerPick(string[] player1, string[] player2, int[] player1int, int[] player2int)
{

    Console.WriteLine("Please pick Player One or Two...");
    Console.WriteLine("\n-Player 1:\n");
    Console.WriteLine("Name: {0}, Age: {3} \nPowers: {1}, {2} \nSpeed: {4}", player1[0],
        player1[1], player1[2], player1int[0], player1int[1]);
    Console.WriteLine("\n\n-Player 2:\n");
    Console.WriteLine("Name: {0}, Age: {3} \nPowers: {1}, {2} \nSpeed: {4}", player2[0],
        player2[1], player2[2], player2int[0], player2int[1]);

    bool validation = true;
    string choice = "0";
    do
    {
        Console.WriteLine("Enter 1 or 2 to choose: ");
        choice = Console.ReadLine();

        if (choice != "1" && choice != "2")
        {
            Console.WriteLine("invalid answer please re-enter");
            validation = false;
        }
        else
        {
            Console.WriteLine("Great choice!");
            validation = true;
        }
    }
    while (validation == false);
    return choice;

}

string[] player1 = { "Arthur", "strength", "charisma" };
string[] player2 = { "Jack", "super speed", "courage" };
int[] player1Stats = { 100 };
int[] player2Stats = { 100 };
int[] player1int = { 42, 1 };
int[] player2int = { 34, 2 };


string finalPick = playerPick(player1, player2, player1int, player2int);


int health = 100;
Console.WriteLine("\nDefault health set as 100");
decisions(health, energy, money, day);
