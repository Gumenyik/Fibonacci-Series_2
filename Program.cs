using System;

Console.Write("Кількість чисел: ");
int k = Convert.ToInt32(Console.ReadLine());

int a = 0, b = 1, c = 0;
for(int i = 0; i < k; i++)
{
    c = a + b;
    a = b;
    b = c;
    Console.WriteLine(c);
}
// change for commmit 