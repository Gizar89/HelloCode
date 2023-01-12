Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маркиза!")
{
    Console.WriteLine ("Ура - это же Маркиза");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}