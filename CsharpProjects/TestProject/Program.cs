// ------------------------------- PROJECT 1 -------------------------------
// string? input;
// int number = 0;
// bool validNumber;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     input = Console.ReadLine();
//     if (!int.TryParse(input, out number))
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//         continue;
//     }
//     else 
//         if (number < 5 || number > 10)
//         Console.WriteLine($"You entered {number}. Please enter a number between 5 and 10.");

// } while (number < 5 || number > 10);

// Console.WriteLine($"Your input value ({number}) has been accepted.");

// ------------------------------- PROJECT 2 -------------------------------
string? input;
string[] roles = {"Administrator", "Manager", "User"};
bool validRole;

do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    input = Console.ReadLine()?.Trim();
    if (roles.Contains(input))
        validRole = true;
    else
    {
        validRole = false;
        Console.WriteLine($"The role name that you entered, \"{input}\" is not valid.");
    }

} while (!validRole);

Console.WriteLine($"Your input value ({input}) has been accepted.");

// ------------------------------- PROJECT 3 -------------------------------
// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int periodLocation = 0;

// string myString;
// int myStringsCount = myStrings.Length;

// for (int i = 0; i < myStringsCount; i++)
// {
//     myString = myStrings[i].Trim();
//     periodLocation = myString.IndexOf('.');
//     while (periodLocation != -1)
//     {
//         string mySentence;

//         mySentence = myString.Remove(periodLocation);
//         myString = myString.Substring(periodLocation + 1).TrimStart();
//         Console.WriteLine(mySentence);

//         periodLocation = myString.IndexOf('.');
//     }
//     Console.WriteLine(myString);
// }
