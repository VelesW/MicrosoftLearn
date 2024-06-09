string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

void DisplayEmails(string[,] name, bool iscorporate = false)
{
    if (iscorporate)
    {
        for (int i = 0; i < corporate.GetLength(0); i++)
        {
            char[] nameArray = name[i, 0].Trim().ToLower().ToCharArray();
            Console.WriteLine($"{nameArray[0]}{nameArray[1]}{name[i,1].Trim().ToLower()}@contoso.com");
        }
    }
    else
    {
        for (int i = 0; i < external.GetLength(0); i++)
        {
            char[] nameArray = name[i, 0].Trim().ToLower().ToCharArray();
            Console.WriteLine($"{nameArray[0]}{nameArray[1]}{name[i, 1].Trim().ToLower()}@{externalDomain}");
        }
    }
}

DisplayEmails(name: corporate, iscorporate: true);
DisplayEmails(external);
