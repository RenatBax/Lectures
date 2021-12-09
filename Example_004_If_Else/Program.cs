// АЛГОРИТМ
// Начало
// Ввести имя пользователя
// Если имя пользователя совпадает с "Маша" то
// попривествовать по особенному
// Иначе попривествовать по обычному
// Конец

Console.WriteLine("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "Маша") 
{
    Console.WriteLine("Ура!!! Это Маша!");
}
else
{
        Console.WriteLine($"Привет {username}!");
}