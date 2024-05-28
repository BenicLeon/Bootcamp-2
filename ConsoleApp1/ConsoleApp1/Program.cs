using ConsoleApp1;
using System.Collections.Generic;

FootballClub club = new FootballClub();

do
{
    Console.WriteLine("Enter player's name:");
    string playerName;
    do
    {
        playerName = Console.ReadLine();
        if (string.IsNullOrEmpty(playerName))
        {
            Console.WriteLine("Name cannot be empty. Please enter a valid name:");
        }
    } while (string.IsNullOrEmpty(playerName));

    Console.WriteLine("Enter player's age:");
    int playerAge;
    while (!int.TryParse(Console.ReadLine(), out playerAge))
    {
        Console.WriteLine("Invalid input. Please enter a valid age:");
    }

    Console.WriteLine("Enter player's position:");
    string playerPosition;
    do
    {
        playerPosition = Console.ReadLine();
        if (string.IsNullOrEmpty(playerPosition))
        {
            Console.WriteLine("Position cannot be empty. Please enter a valid position:");
        }
    } while (string.IsNullOrEmpty(playerPosition));

    Console.WriteLine("Enter player's new jersey number:");
    int playerJerseyNumber;
    while (!int.TryParse(Console.ReadLine(), out playerJerseyNumber))
    {
        Console.WriteLine("Invalid input. Please enter a valid jersey number:");
    }

    Console.WriteLine("Do you want to sign this player (Y/N)?");
    string playerChoice = Console.ReadLine();
    Contract playerContract;

    if (playerChoice.Equals("Y", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Enter contract signing date (YYYY-MM-DD):");
        DateTime contractSigningDate;
        while (!DateTime.TryParse(Console.ReadLine(), out contractSigningDate))
        {
            Console.WriteLine("Invalid input. Please enter a valid date in YYYY-MM-DD format:");
        }

        Console.WriteLine("Enter player's salary:");
        int playerSalary;
        while (!int.TryParse(Console.ReadLine(), out playerSalary))
        {
            Console.WriteLine("Invalid input. Please enter a valid salary:");
        }

         playerContract = new Contract(contractSigningDate, playerSalary);
        Player player = new Player(playerName, playerAge, playerPosition, playerJerseyNumber, playerContract);

        club.AddPlayer(player);
        playerContract.SignContract();

        
    }
    club.DisplayPlayers();

    if (club.HasPlayers())
    {
        Console.WriteLine("Do you want to terminate a player's contract (Y/N)?");
        string contractChoice = Console.ReadLine();
        if (contractChoice.Equals("Y", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Enter player's ID to terminate contract:");
            int playerToTerminate;
            while (!int.TryParse(Console.ReadLine(), out playerToTerminate))
            {
                Console.WriteLine("Invalid input. Enter a valid ID:");
            }
            club.TerminateContract(playerToTerminate);
            if (club.Terminated == true)
            {
                club.DisplayPlayers();
            }
        }
    }
    else
    {
        Console.WriteLine("No players available to terminate. Please add a player first.");
    }
   
    

    Console.WriteLine("Press Enter to continue signing players or type 'exit' to exit...");
} while (Console.ReadLine() != "exit");

