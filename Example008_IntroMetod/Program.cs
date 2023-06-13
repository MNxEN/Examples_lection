//int[] array = {};
//Console.Write("Введите число: ");
//array[0].add() = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число: ");
//array[1] = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число: ");
//array[2] = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число: ");
//array[3] = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число: ");
//array[4] = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число: ");
//array[5] = Convert.ToInt32(Console.ReadLine());
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 23,    b1 = 48,    c1 = 9, 
    a2 = 4896,  b2 = 98,    c2 = 594,
    a3 = 106,   b3 = 4,     c3 = 48;

int max1 = Max(a1,a2,a3);
int max2 = Max(b1,b2,b3);
int max3 = Max(c1,c2,c3);
int max = Max(max1,max2,max3);
Console.WriteLine(max);