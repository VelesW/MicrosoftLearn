using System.Xml.XPath;
using Microsoft.VisualBasic;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        var target = GetTarget();
        var roll = RollDice();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(roll, target));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay()
{
    string yesOrNo = "";
    while (yesOrNo == "")
    {
        string? result = Console.ReadLine();
        if (result != null)
        {
            yesOrNo = result.ToLower();
            if (yesOrNo == "y" || yesOrNo == "yes")
                return true;
            else if (yesOrNo == "n" || yesOrNo == "no")
                return false;
            else
                yesOrNo = "";
        }
    }
    return false;
}

string WinOrLose(int roll, int target)
{
    return (roll > target) ? "You win!" : "You lose!";
}


int GetTarget() 
{
    return random.Next(1, 6);
}

int RollDice() 
{
    return random.Next(1, 7);
}
