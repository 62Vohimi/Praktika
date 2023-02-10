Console.WriteLine("Введите меня пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
  Console.WriteLine("Это же Маша");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}