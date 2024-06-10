string ReverseWord(string text)
{
    string result = "";
    for (int i = text.Length - 1; i >= 0; i--)
    {
        result += text[i];
    }
    return result;
}

string ReverseSentence(string input) 
{
    string result = "";
    string[] words = input.Split(" ");
    foreach (string word in words)
    {
        result += ReverseWord(word) + " ";
    }
    return result.Trim();
}

string input = "there are snakes at the zoo";

Console.WriteLine(input);
Console.WriteLine(ReverseSentence(input));
