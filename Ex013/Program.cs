// Рекурсия, пример с факториалом
// 5! = 5*4*3*2*1
// 5! = 5 * 4! = 5 * 4 * 3! и т.д

double Factorial(int n)
{
    if (n == 1) // 0! тоже = 1 если что
    {
        return 1;
    }
    else
    {
        return n * Factorial(n-1);
    }
}

// Console.WriteLine(Factorial(5)); // если ее запустим в цикле - рано или поздно получим отрицательные числа 

for (int i = 1; i < 30; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}"); //17! - переполнение, инт не вытаскивает, поэтому ставим double Factorial
}

// Задача чисел Фибоначчи, где f(1) = 1, f(2) = 1, f(n) = f(n-1) + f(n-2)
int Febonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Febonacci(n-1) + Febonacci(n-2);
}
for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"{i}: {Febonacci(i)}");
}