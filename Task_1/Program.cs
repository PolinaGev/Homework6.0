int PositiveNumbers()
{
System.Console.WriteLine("Введите числа: ");
int count = 0;
for(int i = 0; ; i++)
{
    string a = Console.ReadLine();
    if(a=="stop")
    break;
    else
{
    int b = Convert.ToInt32(a);
    if(b>0)
    count++;
}
}
System.Console.WriteLine($"кол-во положительных чисел = {count}");
return count;
}
PositiveNumbers();