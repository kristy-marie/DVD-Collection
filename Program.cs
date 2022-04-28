using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// CREATE A FILE PATH TO READ LIST TO AND FROM FILE
string filePath = @"C:\demo\DVD.txt";


List<string> Dvd = new List<string>(); // create list
Dvd = File.ReadAllLines(filePath).ToList(); // assign file to read list DvdCollection to

// hard code items to the list
Dvd.Add("Finding Nemo");
Dvd.Add("Airbud");

// end hard coded items to list
Console.WriteLine("Welcome to my program!");
Console.WriteLine("*********************");
Console.WriteLine();
System.Threading.Thread.Sleep(2000);
Console.WriteLine("Here is your current list:");
Console.WriteLine("-------------------------");
Console.WriteLine();
foreach (string dvd in Dvd)
{
    Console.WriteLine("*{0}", dvd);
}
Console.WriteLine();
System.Threading.Thread.Sleep(2000);

do
{
    
    
    Console.WriteLine("Please select one of the following:");
    Console.WriteLine("**********************************");
    Console.WriteLine();
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("1) Type 'add' if you would like to add a DVD");
    System.Threading.Thread.Sleep(1000);
    Console.WriteLine("2) Type 'choose' if you would like to choose a DVD");
    System.Threading.Thread.Sleep(1000);
    Console.WriteLine("3) Type 'update' if you would like to update a DVD list to a file.");
    System.Threading.Thread.Sleep(1000);
    Console.WriteLine("4) Type 'delete' if you would like to delete a DVD from your list");
    System.Threading.Thread.Sleep(1000);
    Console.WriteLine("5) Press 0 to exit the program.");
    System.Threading.Thread.Sleep(2000);
    string userChoice = Convert.ToString(Console.ReadLine());


    // SWITCH STATEMENTS FOR USERS CHOICE
    switch (userChoice)
    {
        case "add":
            Console.WriteLine("You would like to add a movie to your list!");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("What is the name of the movie you would like to add to your collection?");
            System.Threading.Thread.Sleep(2000);
            string addMovie = (Console.ReadLine());
            Dvd.Add(addMovie);
            Console.WriteLine();
            Console.WriteLine("{0} has been added to your list.", addMovie);
            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
            break;
        case "choose":
            Console.WriteLine("You would like a choose a DVD to watch!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Which movie would you like to watch? Please choose one of the following:");
            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
            foreach (string dvd in Dvd)
            {
                Console.WriteLine("*{0}",dvd);
            }
            string dvdChosen = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Get ready to watch {0}!", dvdChosen);
            System.Threading.Thread.Sleep(1000);
            break;
        case "update":
            Console.WriteLine("You would like to show your updated list");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();
            Console.WriteLine("Before I show an updated list, would you like to add a dvd? Press Y or N.");
            string updateNewDvd = Convert.ToString(Console.ReadLine());
            switch (updateNewDvd)
            {
                case "y":
                    Console.WriteLine("Ok, let's add another movie!");
                    Console.WriteLine();
                    Console.WriteLine("What is the name of the movie you'd like to add?");
                    dvdChosen = Convert.ToString(Console.ReadLine());
                    Dvd.Add(dvdChosen);
                    Console.WriteLine();
                    Console.WriteLine("Would you like to add another DVD? Press 'y' for yes and 'n' for no");
                    updateNewDvd = Convert.ToString(Console.ReadLine());
                    if(updateNewDvd == "y")
                    {
                        Console.WriteLine("Ok, let's add another movie!");
                        Console.WriteLine();
                        Console.WriteLine("What is the name of the movie you'd like to add?");
                        dvdChosen = Convert.ToString(Console.ReadLine());
                        Dvd.Add(dvdChosen);
                        Console.WriteLine();
                        Console.WriteLine("Would you like to add another DVD?");
                        updateNewDvd = Convert.ToString(Console.ReadLine());
                    }
                    else if(updateNewDvd != "y")
                    {
                        Console.WriteLine("Here's your updated list:");
                        Console.WriteLine("*************************");
                        foreach (string dvd in Dvd)
                        {
                            Console.WriteLine("*{0}",dvd);
                        }
                        Console.WriteLine();
                    }

                    break;

                case "n":
                    Console.WriteLine("Here's your updated list:");
                    Console.WriteLine("*************************");
                    Console.WriteLine();
                    foreach(string dvd in Dvd)
                    {
                        Console.WriteLine("*{0}",dvd);
                    }
                    Console.WriteLine();
                    System.Threading.Thread.Sleep(1000);
                    break;
            }
            
            break;
            
        case "delete":
            Console.WriteLine("You would like to delete a DVD");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine();
            Console.WriteLine("Which DVD would you like to delete? Choose from your collection:");
            System.Threading.Thread.Sleep(2000);
            foreach (string dvd in Dvd)
                Console.WriteLine("*{0}",dvd);
            string dvdDeleted = Convert.ToString(Console.ReadLine());
            Dvd.Remove(dvdDeleted);
            Console.WriteLine();
            Console.WriteLine("{0} has been deleted.", dvdDeleted);
            Console.WriteLine();
            Console.WriteLine("Here is your updated list:");
            Console.WriteLine("*************************");
            Console.WriteLine();
            System.Threading.Thread.Sleep(1000);
            foreach (string dvd in Dvd)
                Console.WriteLine("*{0}",dvd);
            break;
        case "0":
            Console.WriteLine("Good-Bye!");
            break;
        default:
            Console.WriteLine("Incorrect value entered.");
            break;
    }

    if(userChoice == "0")
    {
        break;
    }
    

} while (true);
Console.WriteLine();
