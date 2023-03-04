using static Library;

Console.Clear();
string? username = GetName("Введите ваше имя: ");

if (username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.WriteLine("Привет, " + username);
}