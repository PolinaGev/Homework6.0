System.Console.WriteLine("Введите числа через пробел: ");
string[] stringArray = Console.ReadLine().Split(' ');
double b1 = double.Parse(stringArray[0]);
double k1 = double.Parse(stringArray[1]);
double b2 = double.Parse(stringArray[2]);
double k2 = double.Parse(stringArray[3]);


double[] Point(double b1, double b2, double k1, double k2)
{
    
    double[] result = new double[2];
    result[0] = (b2 - b1)/(k1 - k2);
    result[1] = k1 * result[0]+b1;

    return result;
}
System.Console.WriteLine(string.Join(" ", Point(b1, b2, k1, k2)));