Console.Clear(); 

int useramount = int.Parse(Console.ReadLine());
int xa = 1, ya = 1;
int xb = 30, yb = 20;
int xc = 1, yc = 30;

Console.SetCursorPosition (xa, ya);
Console.WriteLine("*");

Console.SetCursorPosition (xb, yb);
Console.WriteLine("*");

Console.SetCursorPosition (xc, yc);
Console.WriteLine("*");

int x = xa, y = xb;
for (int i = 0; i < useramount; i++)
{
    int PtVar = new Random().Next(1, 4);
    if (PtVar == 1)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (PtVar == 2)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (PtVar == 3)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }
    Console.SetCursorPosition (x, y);
    Console.WriteLine("*");
}