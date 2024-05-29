string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');

string[] newSentence = new string[words.Length];

for (int i = 0; i < words.Length; i++)
{
    char[] letters = words[i].ToCharArray();
    Array.Reverse(letters);
    newSentence[i] = new string(letters);
}
string result = String.Join(' ', newSentence);
Console.WriteLine(result);