namespace SakkizinchiDars;

internal class Program
{
    static List<string> IdSeries = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. create");
            Console.WriteLine("2. read");
            Console.WriteLine("3. update");
            Console.WriteLine("4. delete");

        firstif:
            Console.Write("tanlang: ");
            int.TryParse(Console.ReadLine(), out int c);
            if (c == 1)
            {
            secondstart:
                Console.Write("Pasport seriyangizni kiriting: ");
                string text = Console.ReadLine();
                if (IdSeries.Contains(text))
                {
                    Console.WriteLine("Bunday seriya royxatda mavjud");
                    goto secondstart;
                }
                else
                {
                    Console.WriteLine(CheckLength(text));
                    Console.WriteLine(CheckLetter(text));
                    Console.WriteLine(CheckDigit(text));
                    if (CheckAll(text))
                    {
                        CreateId(text);
                        Console.WriteLine("Done!");
                        goto firstif;
                    }
                    else
                    {
                        Console.WriteLine("Tepadagi shartlarda hatolik");
                        goto secondstart;
                    }
                }
            }
            else if (c == 2)
            {
                ReadId();
                goto firstif;
            }
            else if (c == 3)
            {
                Console.Write("Eski Seriani kiriting: ");
                var OldSeria = Console.ReadLine();
                Console.Write("Yangi Seriani kiriting: ");
                var NewSeria = Console.ReadLine();
                if (CheckAll(NewSeria) && CheckAll(OldSeria))
                {
                    UpdateId(OldSeria, NewSeria);
                    Console.WriteLine("Done!");
                    goto firstif;
                }
                else
                {
                    Console.WriteLine("Seriyalarni shartlarga mos kiriting!");
                }
            }
            else if (c == 4)
            {
                Console.Write("Qaysi seriani ochirasiz? ");
                var seriatodelete = Console.ReadLine();
                if (CheckAll(seriatodelete))
                {
                    DeleteId(seriatodelete);
                    Console.WriteLine("Done!");
                    goto firstif;
                }
                else
                {
                    Console.WriteLine("Seriyalarni shartlarga mos kiriting!");
                }
            }
            else
            {
                Console.WriteLine("tepadagilarni birini tanlang!");
                goto firstif;
            }
            //Console.ReadKey();
            //Console.Clear();
        }
    }
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



}
