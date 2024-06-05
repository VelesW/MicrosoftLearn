const string openingSpan = "<span>";
const string closingSpan = "</span>";

string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf(openingSpan);
int closingPosition = message.IndexOf(closingSpan);

openingPosition += openingSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));