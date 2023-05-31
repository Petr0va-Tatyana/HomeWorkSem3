// Про Чернику 

Console.Clear();
Console.WriteLine("Введите числа: ");
int[] a = new int[1000];
int i;
int n;
int s;
n = int.Parse(Console.ReadLine()!);
for (i = 0;i < n;i++)
{
a[i] = int.Parse(Console.ReadLine()!);
}
s = a[0] + a[n - 1] + ((a[1] > a[n - 2])?a[1]:a[n - 2]);
for (i = 1;i < n - 1;i++)
{
if (a[i - 1] + a[i] + a[i + 1] > s)
{
	s = a[i - 1] + a[i] + a[i + 1];
}
}
Console.Write(s);

