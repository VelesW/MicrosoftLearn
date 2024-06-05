const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

const string openingSpan = "<span>";
const string closingSpan = "</span>";


string quantity = "";
string output = "";

// Get the quantity from input
int startingPosition = input.IndexOf(openingSpan) + openingSpan.Length;
int closingPosition = input.IndexOf(closingSpan);
int length = closingPosition - startingPosition;
quantity = input.Substring(startingPosition, length);

// Remove divs from input
const string openingDiv = "<div>";
const string closingDiv = "</div>";

output = input.Replace(openingDiv, "");
output = output.Replace(closingDiv, "");

// Replace trade with reg
const string tradeSymbol = "&trade;";
const string regSymbol = "&reg;";

output = output.Replace(tradeSymbol, regSymbol);


Console.WriteLine($"Qunatity: {quantity}");
Console.WriteLine($"Output: {output}");