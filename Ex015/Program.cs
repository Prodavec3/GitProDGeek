// Собрать строку с числами от a до b, a<=b
Console.WriteLine("Cтрока с числами от a до b, a<=b");
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for(int i = a; i <= b; i++)
    {
        result += $"{i} ";
    }
    return result;
}

string NumbersRec(int a, int b)
{
    if (a < b) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{b}";
}

Console.WriteLine(NumbersFor(1,20));
Console.WriteLine(NumbersRec(1,20));

// Сумма чисел от 1 до N
Console.WriteLine("Сумма чисел от 1 до N");
int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++) result += 1;
        return result;
}
int SumRec(int n)
{
    if (n==0) return 0;
    else return n + SumRec(n-1);
}
Console.WriteLine(SumFor(20));
Console.WriteLine(SumRec(20));

// Факториал числа
Console.WriteLine("Факториал числа");
int FactorialFor(int n)
{
    int result = 1;
    for(int i = 1; i <= n; i++) result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n==1) return 1;
    else return n * FactorialFor(n-1);
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));

// Вычислить а в степени n
Console.WriteLine("A в степени n");

int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *=a;
    return result;
}

int PowerRec(int a, int n)
{
    if (n==0) return 1;
    else return PowerRec(a, n-1) * a;
    //return n == 0 ? 1 : PowerRec(a, n-1) * a;
}
// Уменьшение количества итераций 
int PowerRecMath(int a, int n)
{
    if (n==0) return 1;
    else if (n%2 == 0) return PowerRecMath(a*a, n / 2); // a*a = a^2
    // Если степень делится на 2, то можно число просто умножить само на себя
    // и степень уменьшить в 2 раза
    else return PowerRecMath(a, n-1) * a;
}

Console.WriteLine("2 в степени 10");
Console.WriteLine(PowerFor(2,10));
Console.WriteLine(PowerRec(2,10));
Console.WriteLine(PowerRecMath(2,10));