Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "снежана")
{
    Console.WriteLine("Это же любимая жонка!");
}
else
{
     Console.Write("Здарова, ");
     Console.WriteLine(username);
}