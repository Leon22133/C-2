Console.Write("Введи число ");
int i = int.Parse(Console.ReadLine());
for (int a = 1; a <= i; a++)
{
    if (i % a == 0) { Console.Write("{0} ", a); break; }
}