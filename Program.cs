Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 8;
int ya = 1;

int xb = 1;
int yb = 10;

int xc = 16;
int yc = 10;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++;
}



// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;

// int max = a;

// if (a > max) max = a;
// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;

// Console.Write("max = ");
// Console.WriteLine(max);










// Console.Write("Enter username: ");
// string username = Console.ReadLine();

// if (username.ToLower() == "masha"){
//     Console.WriteLine("Hooray! it's Masha");
// }
// else{
//     Console.Write("Hello, ");
//     Console.WriteLine(username);
// }



// double num1 = new Random().Next(1, 10);
// double num2 = new Random().Next(1, 10);
// Console.WriteLine(num1 + num2);





// int num1 = 3;
// int num2 = 5;
// Console.WriteLine(num1 + num2);



// Console.Write("Введите Ваше имя: ");
// string username = Console.ReadLine();
// Console.Write("Привет, ");
// Console.Write(username);