Console.Write("Введите имя пользователя: ");
string userName = Console.ReadLine()!;
if(userName.ToLower() == "маша")
{
    Console.WriteLine("Дратуйтэ, Маша!");
}
else
{
     Console.WriteLine("Доброго, " + userName + "!");
}