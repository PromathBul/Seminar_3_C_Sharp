/*
void GetCoordinates(int quadrant)
{
    if (quadrant == 1) Console.WriteLine("x > 0, y > 0");
    else if (quadrant == 2) Console.WriteLine("x < 0, y > 0");
    else if (quadrant == 3) Console.WriteLine("x < 0, y < 0");
    else if (quadrant == 4) Console.WriteLine("x > 0, y < 0");
    else Console.WriteLine("There is no such quadrant");
}

Console.Write("Input a number of the quadrant: ");
int quadrantPoint = Convert.ToInt32(Console.ReadLine());

GetCoordinates(quadrantPoint);
*/

/*
double Distance(double xA, double yA, double xB, double yB)
{
    double length = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));
    return Math.Round(length, 2);
}

Console.Write("Input an x-coordonate of point A: ");
double xA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an y-coordonate of point A: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an x-coordonate of point B: ");
double xB = Convert.ToDouble(Console.ReadLine());

Console.Write("Input an y-coordonate of point B: ");
double yB = Convert.ToDouble(Console.ReadLine());

double distanceBetweenAB = Distance(xA, yA, xB, yB);

Console.WriteLine($"Distance between points A and B is {distanceBetweenAB}.");
*/



void Squares(int number)
{
    int counter = 1;
    while(counter <= number)
    {
        Console.Write(Math.Pow(counter, 2));
        if(counter != number) Console.Write(", ");
        else Console.Write(".");
        counter++;
    }
}

Console.Write("Input an integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The series of squares of numbers:");
Squares(num);