//что то принимают и что то возвращают

// // string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;
//     while(i < count)
//     {
//         result = result+text;
//          i++;
//          return result;
//     }
// }
// string rec = Method4(12,"acab");
// Console.WriteLine(rec);

string Metod4(int count, string text)
{
int i = 0;
string result = String.Empty;
while (i<count)
{
result = result + text;
i++;
}
return result;
}
string res = Metod4(12, "acab");
Console.WriteLine(res);
