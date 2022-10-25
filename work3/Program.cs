// ничего не принимает, что то возвращает
 int Method3()
 {
    return DateTime.Now.Year;
 }

int year = Method3();
Console.WriteLine(year);