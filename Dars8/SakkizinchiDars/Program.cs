namespace SakkizinchiDars;

internal class Program
{
    static List<string> IdSeries = new List<string>();

    static void Main(string[] args)
    {
        //-----------------------Pasport Serie With CRUD-----------------------

        //while (true)
        //{
        //    Console.WriteLine("1. create");
        //    Console.WriteLine("2. read");
        //    Console.WriteLine("3. update");
        //    Console.WriteLine("4. delete");

        //firstif:
        //    Console.Write("tanlang: ");
        //    int.TryParse(Console.ReadLine(), out int c);
        //    if (c == 1)
        //    {
        //    secondstart:
        //        Console.Write("Pasport seriyangizni kiriting: ");
        //        string text = Console.ReadLine();
        //        if (IdSeries.Contains(text))
        //        {
        //            Console.WriteLine("Bunday seriya royxatda mavjud");
        //            goto secondstart;
        //        }
        //        else
        //        {
        //            Console.WriteLine(CheckLength(text));
        //            Console.WriteLine(CheckLetter(text));
        //            Console.WriteLine(CheckDigit(text));
        //            if (CheckAll(text))
        //            {
        //                CreateId(text);
        //                Console.WriteLine("Done!");
        //                goto firstif;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Tepadagi shartlarda hatolik");
        //                goto secondstart;
        //            }
        //        }
        //    }
        //    else if (c == 2)
        //    {
        //        ReadId();
        //        goto firstif;
        //    }
        //    else if (c == 3)
        //    {
        //        Console.Write("Eski Seriani kiriting: ");
        //        var OldSeria = Console.ReadLine();
        //        Console.Write("Yangi Seriani kiriting: ");
        //        var NewSeria = Console.ReadLine();
        //        if (CheckAll(NewSeria) && CheckAll(OldSeria))
        //        {
        //            UpdateId(OldSeria, NewSeria);
        //            Console.WriteLine("Done!");
        //            goto firstif;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Seriyalarni shartlarga mos kiriting!");
        //        }
        //    }
        //    else if (c == 4)
        //    {
        //        Console.Write("Qaysi seriani ochirasiz? ");
        //        var seriatodelete = Console.ReadLine();
        //        if (CheckAll(seriatodelete))
        //        {
        //            DeleteId(seriatodelete);
        //            Console.WriteLine("Done!");
        //            goto firstif;
        //        }
        //        else
        //        {
        //            Console.WriteLine("Seriyalarni shartlarga mos kiriting!");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("tepadagilarni birini tanlang!");
        //        goto firstif;
        //    }
        //}
        //-----------------------Pasport Serie With CRUD-----------------------
        List<int> nums = new List<int> { 1323, 211, 32, 3, 222, 32, 3, 1, 321, 3, 9 };
        Task6(ref nums);

        foreach (var i in nums)
        {
            Console.WriteLine(i);
        }
    }


    //1.4.2.26-----------------------------------------------
    //static void PlusOut(ref string str, string word)
    //{
    //    var ind = str.IndexOf(word);
    //    var str2 = string.Empty;
    //    while (true)
    //    {
    //        //str2 += str.Substring(2, 2, 2);
    //    }
    //}

    //1.5.1.6------------------------------------------------
    static void Task6(ref List<int> nums)
    {
        var num1 = nums[0];
        var num2 = nums[nums.Count - 1];
        nums[0] = num2;
        nums[nums.Count - 1] = num1;
    }

    //1.5.1.5------------------------------------------------
    static int CountOfThirdRooms(List<int> nums)
    {
        var count = 0;
        foreach (var i in nums)
        {
            if (i >= 10 && i <= 99 && i % 2 != 0)
            {
                count++;
            }
        }
        return count;
    }
    static int SumOfThirdRooms(List<int> nums)
    {
        var sum = 0;
        foreach (var i in nums)
        {
            if (i >= 10 && i <= 99 && i % 2 != 0)
            {
                sum += i;
            }
        }
        return sum;
    }
    //1.5.1.4------------------------------------------------
    static int Task4(List<int> nums)
    {
        var count = 0;
        foreach (var i in nums)
        {
            if (i % 3 == 0 && i % 7 == 0)
            {
                ++count;
            }
        }
        return count;
    }

    //1.5.1.3------------------------------------------------
    static int Task3(List<int> nums)
    {
        var count = 0;
        foreach (var i in nums)
        {
            if (i % 2 != 0)
            {
                ++count;
            }
        }
        return count;
    }

    //1.5.1.2------------------------------------------------
    static int Task2(List<int> nums)
    {
        var count = 0;
        foreach (var i in nums)
        {
            if (i % 2 == 0)
            {
                ++count;
            }
        }
        return count;
    }

    //1.5.1.1------------------------------------------------
    static int Task1(List<int> nums)
    {
        var count = 0;
        foreach (var i in nums)
        {
            if (i >= 100 && i <= 999)
            {
                ++count;
            }
        }
        return count;
    }


    //-----------------------Pasport Serie With CRUD-----------------------

    static bool CheckAll(string text)
    {
        if (CheckLength(text).Length <= 15 && CheckDigit(text).Length <= 15 && CheckLetter(text).Length <= 15)
        {
            return true;
        }
        return false;
    }
    static string CheckLength(string text)
    {
        if (text.Length == 9)
        {
            return "uzunlik: togri";
        }
        return "seriyangiz uzunligi 9ta elementdan iborat bolishi kerak";
    }
    static string CheckDigit(string text)
    {
        if (text.Substring(2).All(c => char.IsDigit(c)))
        {
            return "raqamlar: togri";
        }
        return "seriyangiz raqamalri sondan iborat bolishi kk";
    }
    static string CheckLetter(string text)
    {
        if (text.Substring(0, 2).All(c => char.IsLetter(c)) && text.Substring(0, 2).All(c => char.IsUpper(c)))
        {
            return "harflar: togri";
        }
        return "seriyangiz boshidagi 2ta elementi katta harf bolishi kk";

    }
    static void CreateId(string name)
    {
        IdSeries.Add(name);

    }
    static void ReadId()
    {
        foreach (var i in IdSeries)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
    }
    static void UpdateId(string oldseria, string newseria)
    {
        int ind = IdSeries.IndexOf(oldseria);
        if (ind != -1)
        {
            IdSeries[ind] = newseria;
        }
    }
    static void DeleteId(string seria)
    {
        IdSeries.Remove(seria);
    }
    //-----------------------Pasport Serie With CRUD-----------------------




}
