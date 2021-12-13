// Методы
// Вид 1. Ничего ни принимает и ничего не возвращает
// void Method1()
// {
//     Console.WriteLine("Автор...");
// }
// Method1();

//Вид 2. Что то принимает, но ничего не возвращает
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2(msg: "Текст сообщения");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// Method21("Текст", 4);
// Method21(msg: "Текст", count: 4);
// Method21(count: 4, msg: "Новый текст");

// //Вид 3. Что то возвращает, но ничего не принимает
// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);

//Вид 4. Что то принимают и что то возвращают
string Method4(int count, string text)
{
    string result = String.Empty;
    // int i = 0;
    // while (i < count)
    // {
    //     result = result + text;
    //     i++;
    // }
    // return result;
    for(int i = 0; i< count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, " Z ");
Console.WriteLine(res);







