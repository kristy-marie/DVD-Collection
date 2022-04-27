/*PROGRAM: A USER HAS A DVD COLLECTION. GIVE THE USER THE OPTION TO ADD A DVD, CHOOSE A DVD, UPDATE A DVD'S INFORMATION
 *  OR DELETE A DVD.
 * 
 */



using System;
using System.Collections;


//bool keepGoing = true;


// create new list and list object
List<string> DVD = new List<string>();
// add hard coded items to the list
DVD.Add("Titanic");
DVD.Add("Finding Nemo");
DVD.Add("Saw");
DVD.Add("The Lion King");
DVD.Add("Old Yeller");

// create a do while loop to ask the user what they would like to do

do
{
    System.Threading.Thread.Sleep(2000);
    Console.WriteLine("My list of DVDs include:"); // show the list of DVDs
    Console.WriteLine();
    foreach (var item in DVD) // foreach loop to display DVDs
    {

        Console.WriteLine("*{0}", item);
    }
    Console.WriteLine();
    Console.WriteLine("Press 1 to add a DVD, press 2 to choose a DVD, press 3 to update a DVD's information" +
        ",press 4 to delete a DVD, or 5 to end the program.");
    int userChoice = Convert.ToInt32(Console.ReadLine());


    switch (userChoice)
    {
        case 1:
            do
            {
                Console.WriteLine("You would like to add a DVD.");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine();
                Console.WriteLine("What is the title you would like to add?");
                DVD.Add(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("{0} has been added to the list.", DVD.Last());
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Would you like to add another?");
                string continueOn = Convert.ToString(Console.ReadLine());
                if (continueOn != "no")
                {
                    Console.WriteLine("What is the title you would like to add?");
                    DVD.Add(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("{0} has been added to the list.", DVD.Last());
                    

                    Console.WriteLine("Would you like to add another?");
                    continueOn = Convert.ToString(Console.ReadLine());
                    
                }
                else
                {
                    break;
                }
               

            } while (true);
            break;
        case 2:
            Console.WriteLine("You would like to choose a DVD.");
            Console.WriteLine();
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Which DVD would you like to choose from the list? (choose 0, 1, 2, 3, etc. for the DVD");
            foreach(var item in DVD)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            string DVDchosen = Convert.ToString(Console.ReadLine());
            Console.WriteLine("You chose {0}", DVDchosen);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine();
            


            break;
        case 3:
            Console.WriteLine("You would like to update a DVD's information.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Which DVD would you like you like to update?");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Chose one of the following: ");
            foreach(var item in DVD)
            {
                Console.WriteLine(item);
            }
            string DVDchosen2 = Convert.ToString(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("What would you like to update? Choose 'move' to move to the back of the list or 'adjust' " +
                "to adjust the title.");
            string updateDvd = Convert.ToString(Console.ReadLine());
            System.Threading.Thread.Sleep(2000);
            if(updateDvd == "move")
            {
                DVD.Append(DVDchosen2);
                Console.WriteLine("{0} has been added to the end of the list.", DVDchosen2);
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("Here is the updated list: ");
                foreach(var item in DVD)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
                System.Threading.Thread.Sleep(2000);
            }
            break;

        case 4:
            Console.WriteLine("You would like to delete a DVD.");
            Console.WriteLine("What DVD would you like to delete?");
            string deleteDvd = Convert.ToString(Console.ReadLine());
            DVD.RemoveAt(deleteDvd);
            foreach (var item in DVD)
                Console.WriteLine(item);
            break;
        case 5:
            Console.WriteLine("You would like to end this program. Goodbye.");
            break;
        default:
            Console.WriteLine("Invalid input.");
            break;
    }
} while (true);

