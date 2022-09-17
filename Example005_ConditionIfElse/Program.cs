Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "ваня")
{
    Console.WriteLine("Рады Вас видеть, господин Иван!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}