using System.Data;

Console.WriteLine("Welcome to Power Table Lab!");

bool Program = true;
do
{
    Console.WriteLine("Please enter a integer.");
    int numb1 = int.Parse(Console.ReadLine());

    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "Number", "Squared", "Cubed"));
    for (int numb2 = 1; numb2 <= numb1; numb2++)
    {
        Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", numb2, numb2 * numb2, numb2 * numb2 * numb2));
    }
    Console.WriteLine("Do you want to start over? y/n?");
    string choice = Console.ReadLine();
    if (choice == "y")
    {
        Program = true;
    }
    else if (choice == "n")
    {
        Program = false;
        Console.WriteLine("Goodbye");
    }


} while (Program == true);

  