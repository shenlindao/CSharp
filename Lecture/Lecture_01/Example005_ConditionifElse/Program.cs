using static Library;

Console.Clear();
string? name = GetName("Введите ваше имя: ");
if (name != null)
{
    if (name == "маша")
    {
        Console.WriteLine("Ура, это же МАША!");
    }
    else
    {
        Console.WriteLine("Привет, " + name);
    }
}

