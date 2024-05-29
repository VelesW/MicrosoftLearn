string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(',', valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (var item in items)
{
    Console.WriteLine(item);
}