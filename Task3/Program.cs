// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Main()
{
    int m = 3, n = 3;
    System.Console.WriteLine(akkermanFun(m, n));

}

int akkermanFun(int m, int n)
{
        if (m == 0) 
            return n + 1;
        else if (m > 0 && n == 0) {
            return akkermanFun(m - 1, 1);
        } else if (m > 0 && n > 0) {
            return akkermanFun(m - 1, akkermanFun(m, n - 1));
        }
        return 0;
}

Main();