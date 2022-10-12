/*Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/
int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    while (result == 0)
    {
        Console.Write(userInformation);
        string userLine = Console.ReadLine();
        int.TryParse(userLine, out result);
        if(result == 0 && userLine != "0")
        {
            Console.WriteLine($"Введите целое число, вы ввели {userLine}");
        }
        else
        {
            break;

        }
    }
    return result;
}
int userCoorX1 = getCoordinateFromUser("X1 = ");
int userCoorY1 = getCoordinateFromUser("Y1 = ");
int userCoorZ1 = getCoordinateFromUser("Z1 = ");
int userCoorX2 = getCoordinateFromUser("X2 = ");
int userCoorY2 = getCoordinateFromUser("Y2 = ");
int userCoorZ2 = getCoordinateFromUser("Z2 = ");


double findRangeBetweenTwoPoints(int X1, int Y1, int Z1, int X2, int Y2, int Z2)
{
    double result = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));
    return result;
}
double Result = findRangeBetweenTwoPoints(userCoorX1, userCoorY1, userCoorZ1, userCoorX2, userCoorY2, userCoorZ2);
Console.WriteLine(Result);