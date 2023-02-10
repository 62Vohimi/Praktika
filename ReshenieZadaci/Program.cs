int a = 1;
int b = 4;
int c = 7;
int d = 3;

int max = a;

if (a > max) max = a;
if (b > a) max = b;
if (c > b) max = c;
if (d > c) max = d;

Console.Write("max= ");
Console.WriteLine(max);
