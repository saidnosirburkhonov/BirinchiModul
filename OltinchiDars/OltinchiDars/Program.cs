namespace OltinchiDars;

internal class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine();
    }



    static int pow(int num, int degree, int res = 1)
    {
        for(var i = 1; i <= degree; i++)
        {
            res = res * num;
        }
        return res;
    }

    //1.6.1.16----------------------------------
    static char tolower(char c)
    {
        if(c >=  'A' && c <= 'Z')
        {
            return ((char)Convert.ToInt32(c + 32));
        }
        else
        {
            return c;
        }
    }

    //1.6.1.15----------------------------------
    static bool islower(char c)
    {
        if (c >= 'a' && c <= 'z')
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //1.6.1.14----------------------------------
    static bool isdigit(char c)
    {
        if (c >= '0' && c <= '9')
        {
            return true;
        }
        else { return false; }
    }

    //1.6.1.13----------------------------------
    static char toupper(char c)
    {
        if (c >= 'a' && c <= 'z')
        {
            return ((char)Convert.ToInt32(c - 32));
        }
        else
        {
            return c;
        }
    }

    //1.6.1.12----------------------------------
    static bool isupper(char ch)
    {
        if (ch >= 'A' && ch <= 'Z')
        {
            return true;
        }
        else { return false; }
    }

    //1.6.1.11----------------------------------
    static int abs(int a)
    {
        if (a >= 0)
        {
            return a;
        }
        else
        {
            return int.Parse(a.ToString().Substring(1));
        }
    }
    static double abs(double a)
    {
        if (a >= 0)
        {
            return a;
        }
        else
        {
            return double.Parse(a.ToString().Substring(1));
        }
    }
    static float abs(float a)
    {
        if (a >= 0)
        {
            return a;
        }
        else
        {
            return float.Parse(a.ToString().Substring(1));
        }
    }

    //1.6.1.10----------------------------------
    static int max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    static double max(double a, double b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    static float max(float a, float b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }


    //1.6.1.9-----------------------------------
    static int SumOfCubedN(int n)
    {
        var count = 0;
        for (var i = 1; i <= n; i++)
        {
            count += i * i * i;
        }
        return count;
    }


    //1.6.1.8-----------------------------------
    static int SumAB(int a, int b)
    {
        if (a == b + 1)
        {
            return 0;
        }
        return a + SumAB(a + 1, b);
    }

    //1.6.1.7-----------------------------------
    static int CountOfRooms(int num, int count = 0)
    {
        if (num == 0)
        {
            return 0;
        }
        return count + 1 + CountOfRooms(num / 10);
    }

    //1.6.1.5-----------------------------------
    static int findMax(int num1, int num2, int num3)
    {
        return Math.Max(Math.Max(num1, num2), num3);
    }
    static int findMax(int num1, int num2, int num3, int num4)
    {
        return Math.Max(Math.Max(num1, num2), Math.Max(num3, num4));
    }
    static int findMax(int num1, int num2, int num3, int num4, int num5)
    {
        return Math.Max(Math.Max(Math.Max(num1, num2), Math.Max(num3, num4)), num5);
    }

    //1.6.1.4-----------------------------------
    static int getAmountDigit(int num)
    {
        var count = 0;
        while (true)
        {
            if (num == 0) break;
            ++count;
            num /= 10;
        }
        return count;
    }
    static int getAmountDigit(string text)
    {
        var count = 0;
        foreach (var i in text)
        {
            if (char.IsDigit(i))
            {
                ++count;
            }
        }
        return count;
    }

    //1.6.1.2----------------------------------
    static void Repeat(int a)
    {
        for (var i = 0; i < a; i++)
        {
            Console.WriteLine(a);
        }
    }

    static void Repeat(int a, int b)
    {
        for (var i = 0; i < b; i++)
        {
            Console.WriteLine(a);
        }
    }
    static float Add(float a, float b)
    {
        return a + b;
    }
    static float Add(float a, float b, float c)
    {
        return a + b + c;
    }
    static string Add(string a, string b)
    {
        return a + b;
    }
    //------------------------------------------
    static int calculate(int a, int b)
    {
        return a + b;
    }
    static int calculate(int a, int b, int c)
    {
        return a * b * c;
    }

    //---------------------------------------------
    static int multiplication(int a)
    {
        var count = 1;
        for (var i = 1; i <= a; i++)
        {
            count *= i;
        }
        return count;
    }
    static int multiplication(int a, int b)
    {
        var count = 1;
        for (var i = a; i <= b; i++)
        {
            count *= i;
        }
        return count;
    }
    static int multiplication(int a, int b, int c)
    {
        return a * b * c;
    }
}
