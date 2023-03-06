Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "дина")
{
  Console.WriteLine("Привет малышка");
}
else
{
  Console.Write("И снова чижик, ");
  Console.WriteLine(username);
}
