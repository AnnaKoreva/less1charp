Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "mars")
{
   Console.WriteLine("УРА ЭТО ЖЕ MARS"); 
}
else
{
    Console.Write("привет, ");
    Console.WriteLine(username);
}