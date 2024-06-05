// string data = "12345John Smith          5000  3  ";
// string removed = data.Remove(5, 20);
// Console.WriteLine(removed);

string message = "This--is--ex-amp-le--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);