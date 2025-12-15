namespace TortinchiDars;

internal class Program
{




    static void Main(string[] args)
    {

        Console.WriteLine();


    }



    //1.4.2.25
    //static string zipZap(string text)
    //{
    //    var word = string.Empty;
    //    for(var i = 0; i < text.Length; i++)
    //    {
    //        if(text[i] != 'z')
    //        {
    //            word += text[i];
    //        }
    //        if (text[i] == 'z' && text[i + 2] == 'p')
    //        {
    //            word += text[i];
    //            word += text[i + 2];
    //        }
    //        else
    //        {
    //            word += text[i];
    //        }
    //    }
    //    return word;
    //}

    //1.4.2.24
    //static bool sameStarChar(string text)
    //{
    //    for (var i = 0; i < text.Length; i++)
    //    {
    //        if (text[i] == '*' && text[i + 1] == text[i - 1])
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}

    //1.4.2.23
    //static string getSandwich(string text)
    //{
    //    var count = 0;
    //    var word = string.Empty;
    //    foreach (var i in text.Split("bread"))
    //    {
    //        if(i == "bread")
    //        {
    //            count++;
    //            word += i + 1;
    //        }
    //        if(count == 2)
    //        {
    //            return word;
    //        }
    //    }
    //    return "";
    //}

    //1.4.2.21
    //static bool prefixAgain(string text, int n)
    //{
    //    var word = text.Remove(0, n);
    //    if(word.Contains(text.Substring(0, n))){
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //1.4.2.22
    //static bool xyzMiddle(string text)
    //{
    //    if(text.Substring((text.Length - 3) / 2, 3) == "xyz")
    //    {
    //        return true;
    //    }else if(text.Substring(((text.Length - 3) / 2)-1, 3) == "xyz")
    //    {
    //        return true;
    //    }
    //    else if (text.Substring(((text.Length - 3) / 2) + 1, 3) == "xyz")
    //    {
    //        return true;
    //    }else { return false; };
    //}

    //1.4.2.20
    //static string repeatSeparator(string word, string sep, int n)
    //{
    //    var satr = string.Empty;
    //    for(var i = 0; i < n;  i++)
    //    {
    //        satr += word;
    //        if(i + 1 != n)
    //        {
    //            satr += sep;
    //        }
    //    }
    //    return satr;
    //}

    //1.4.2.19
    //static string repeatFront(string text, int n)
    //{
    //    var word = string.Empty;
    //    int ind = 0;
    //    while (true)
    //    {
    //        word += text.Substring(0, n - ind);
    //        if(ind == n)
    //        {
    //            break;
    //        }
    //        ind++;
    //    }
    //    return word;
    //}

    //1.4.2.18
    //static string repeatEnd(string text, int num)
    //{
    //    var str = string.Empty;
    //    var word = text.Substring(text.Length - num, num);
    //    for(var i = 0; i < num; i++)
    //    {
    //        str += word;
    //    }
    //    return str;
    //}

    //1.4.2.17
    //static string mixString(string a, string b)
    //{
    //    var str = string.Empty;
    //    var ind = 0;
    //    while (true)
    //    {
    //        str += a.Substring(ind, 1);
    //        str += b.Substring(ind, 1);
    //        ind++;
    //        if (a.Length + b.Length == str.Length)
    //        {
    //            break;
    //        }
    //    }
    //    return str;
    //}

    //1.4.2.16
    //static bool mixString(string text)
    //{
    //    if (text.Contains("xyz"))
    //    {
    //        if (text.Substring(text.IndexOf("xyz") - 1, 1) == ".")
    //        {
    //            return false;
    //        }
    //        else
    //        {
    //            return false;
    //        }
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //1.4.2.15
    //static bool endOther(string a, string b)
    //{
    //    var a1 = string.Empty;
    //    var b1 = string.Empty;
    //    foreach (var i in b1)
    //    {
    //        b1 += char.ToLower(i);
    //    }
    //    foreach (var i in a1)
    //    {
    //        a1 += char.ToLower(i);
    //    }
    //    if(a1 == b1.Substring(b1.Length - a1.Length))
    //    {
    //        return true;
    //    }else if(b1 == a1.Substring(a1.Length - b1.Length))
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }

    //}

    //1.4.2.14
    //static int countCode(string text)
    //{
    //    var count = 0;
    //    while (true)
    //    {

    //    }
    //}

    //1.4.2.13
    //static bool TrueStr(string text)
    //{
    //    var count = 0;
    //    if (text.Contains("cat"))
    //    {
    //        ++count;
    //    }
    //    if (text.Contains("dog"))
    //    {
    //        ++count;
    //    }
    //    if(count == 2)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //1.4.2.12
    //static string Kusok(string text)
    //{
    //    var str = string.Empty;
    //    var count = 0;
    //    foreach (var i in text)
    //    {
    //        if (char.IsWhiteSpace(i))
    //        {
    //            count++;
    //        }
    //        if(count == 1)
    //        {
    //            str += i;
    //        }if (count == 2)
    //        {
    //            return str;
    //        }
    //    }
    //    return " ";
    //}

    //1.4.2.5
    //static int CouuntStr(string s1, string s2)
    //{
    //    var count = 0;
    //    for (var i = 0; i < s1.Length; i++)
    //    {
    //        if (s1.Substring(i, s2.Length) == s2)
    //        {
    //            count++;
    //        }
    //    }
    //    return count;
    //}

    //1.4.2.4
    //static string ReturnStr(char c, string s1, string s2)
    //{
    //    var text = string.Empty;
    //    for (var i = 0; i < s1.Length; i++)
    //    {
    //        if (s1[i] == c)
    //        {
    //            text += c;
    //            text += s2;
    //        }
    //        else
    //        {
    //            text += s1[i];
    //        }
    //    }
    //    return text;
    //}

    //1.4.2.3
    //static string ReturnStr(char c, string s1, string s2)
    //{
    //    var text = string.Empty;
    //    for (var i = 0; i < s1.Length; i++)
    //    {
    //        if (s1[i] == c)
    //        {
    //            text += s2;
    //            text += c;
    //        }
    //        else
    //        {
    //            text += s1[i];
    //        }
    //    }
    //    return text;
    //}

    //1.4.2.2
    //static string CharPlus(string s, char c)
    //{
    //    var str = string.Empty;
    //    foreach (var i in s)
    //    {
    //        if(c == i){
    //            str += i;
    //            str += i;
    //        }
    //        else
    //        {
    //            str += i;
    //        }
    //    }
    //    return str;
    //}

    //1.4.2.1
    //static string AddStr(string s1, string s2, int n1, int n2)
    //{
    //    return $"{s1.Substring(0, n1)}{s2.Substring(s2.Length - n2)}";
    //}


    //-------------------------------1.4.1---------------------------------------------
    //1.4.1.25
    //static string DeleteDigits(string text)
    //{
    //    var str = string.Empty;
    //    foreach (var i in text)
    //    {
    //        if (char.IsWhiteSpace(i))
    //        {
    //            continue;
    //        }
    //        else
    //        {
    //            str += i;
    //        }
    //    }
    //    return str;
    //}

    //1.4.1.24
    //static string DeleteDigits(string text)
    //{
    //    var str = string.Empty;
    //    foreach (var i in text)
    //    {
    //        if (i != '@')
    //        {
    //            str += i;
    //        }
    //    }
    //    return str;
    //}

    //1.4.1.23/
    //static string DeleteDigits(string text)
    //{
    //    var str = string.Empty;
    //    foreach (var i in text)
    //    {
    //        if (char.IsUpper(i))
    //        {
    //            str += i;
    //        }
    //    }
    //    return str;
    //}

    //1.4.1.22
    //static string DeleteUpper(string text)
    //{
    //    var str = string.Empty;
    //    foreach (var i in text)
    //    {
    //        if (char.IsLower(i))
    //        {
    //            str += i;
    //        }
    //    }
    //    return str;
    //}

    //1.4.1.21
    //static string DeleteDigits(string text)
    //{
    //    var str = string.Empty;
    //    foreach (var i in text)
    //    {
    //        if (char.IsLetter(i))
    //        {
    //            str += i;
    //        }
    //    }
    //    return str;
    //}

    //1.4.1.20
    //static string withoutX(string text)
    //{
    //    if(text.Substring(0,1) == "x" && text.Substring(text.Length - 1,1) == "x")
    //    {
    //        return text.Substring(1, text.Length - 2);
    //    }
    //    else if(text.Substring(0, 1) == "x")
    //    {
    //        return text.Substring(1);
    //    }
    //    else if(text.Substring(text.Length - 1, 1) == "x")
    //    {
    //        return text.Substring(0, text.Length - 1);
    //    }
    //    else
    //    {
    //        return text;
    //    }
    //}

    //1.4.1.19
    //static string deFront(string text)
    //{
    //    if(text.Substring(0, 1) == "a" && text.Substring(1,1) == "b")
    //    {
    //        return text;
    //    }else if(text.Substring(0,1) == "a")
    //    {
    //        return $"{text.Substring(0,1)}{text.Substring(2)}";
    //    }else if(text.Substring(1,1) == "b")
    //    {
    //        return $"{text.Substring(1,1)}{text.Substring(2)}";
    //    }
    //    else
    //    {
    //        return text.Substring(2);
    //    }
    //}

    //1.4.1.18
    //static string minCat(string a, string b)
    //{
    //    if(a.Length > b.Length)
    //    {
    //        return $"{a.Substring(a.Length - b.Length, b.Length)}{b}";
    //    }else if(b.Length > a.Length)
    //    {
    //        return $"{b.Substring(b.Length - a.Length, a.Length)}{a}";
    //    }
    //    else
    //    {
    //        return $"{a}{b}";
    //    }
    //}

    //1.4.1.17
    //static bool frontAgain(string text)
    //{
    //    if(text.Substring(0, 2) == text.Substring(text.Length - 2, 2))
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //1.4.1.16
    //static string seeColor(string text)
    //{
    //    if(text.Substring(0, 3) == "red")
    //    {
    //        return "red";
    //    }else if(text.Substring(0, 4) == "blue")
    //    {
    //        return "blue";
    //    }
    //    else
    //    {
    //        return "";
    //    }
    //}
    //yoki StartWith qisa boladi!!!!!!!!

    //1.4.1.15
    //static string lastTwo(string text)
    //{
    //    var last = text.Substring(text.Length - 1);
    //    var last2 = text.Substring(text.Length - 2, 1);
    //    var start = text.Substring(0, text.Length - 2);
    //    return start.Insert(start.Length, last2).Insert(start.Length, last);
    //}

    //1.4.1.14
    //static string conCat(string a, string b)
    //{
    //    if (a.Substring(a.Length - 1, 1) == b.Substring(0, 1))
    //    {
    //        return $"{a.Substring(0)}{b.Substring(1)}";
    //    }
    //    else
    //    {
    //        return $"{a.Substring(0)}{b.Substring(0)}";
    //    }
    //}

    //1.4.1.13
    //static string middleThree(string text)
    //{
    //    return text.Substring((text.Length - 3) / 2, 3);
    //}

    //1.4.1.12
    //static string nTwice(string text, int n)
    //{
    //    return $"{text.Substring(0, n)}{text.Substring(text.Length - n, n)}";
    //}

    //1.4.1.11
    //static string theEnd(string text, bool front)
    //{
    //    if(front == true)
    //    {
    //        return text.Substring(0, 1);
    //    }
    //    else
    //    {
    //        return text.Substring(text.Length-1, 1);
    //    }
    //}

    //1.4.1.10
    //static string left2(string text)
    //{
    //    var matn = text.Remove(0, 2);
    //    return matn.Insert(matn.Length, text.Substring(0,2));
    //}

    //1.4.1.9
    //static string nonStart(string a,  string b)
    //{
    //    return $"{a.Remove(0, 1)}{b.Remove(0,1)}";
    //}

    //1.4.1.8
    //static string comboString(string a, string b)
    //{
    //    if(a.Length > b.Length)
    //    {
    //        return $"{b}{a}{b}";
    //    }
    //    else
    //    {
    //        return $"{a}{b}{a}";
    //    }
    //}

    //1.4.1.7
    //static string withoudEnd(string text)
    //{
    //    return text.Substring(1, text.Length - 2);
    //}

    //1.4.1.6
    //static string firstHalf(string text)
    //{
    //    return text.Substring(0, text.Length / 2);
    //}

    //1.4.1.5
    //static string firstTwo(string text)
    //{
    //    if (text.Length >= 2)
    //    {
    //        return text;
    //    }
    //    else
    //    {
    //        return text.Substring(0, 2);
    //    }
    //}

    //1.4.1.4
    //static string extraEnd(string text)
    //{
    //    return $"{text.Substring(text.Length - 2)}{text.Substring(text.Length - 2)}{text.Substring(text.Length - 2)}";
    //}

    //1.4.1.3
    //static string makeOutWord(string a,  string b)
    //{
    //    return $"{a.Insert(2, b)}";
    //}

    //1.4.1.2
    //static string MakeAbba(string a,  string b)
    //{
    //    return $"{a}{b}{b}{a}";
    //}

    //1.4.1.1
    //static string HelloName(string name)
    //{
    //    return $"Hello {name}";
    //}

    //----------------------------1.4.0---------------------------------------------/
    //1.4.0.21
    //static int CountOfChar(string text)
    //{
    //    var count = 0;
    //    foreach (char c in text)
    //    {
    //        if(c == '@')
    //        {
    //            count++;    
    //        }
    //    }
    //    return count;
    //}

    //1.4.0.19
    //static string ChangeStr(string text)
    //{
    //    var str = string.Empty;
    //    foreach (var i in text)
    //    {
    //        if (char.IsUpper(i))
    //        {
    //            str += char.IsLower(i);
    //        }
    //        else
    //        {
    //            str += i;
    //        }
    //    }
    //    return str;
    //}

    //1.4.0.18
    //static string ChangeStr(string text)
    //{
    //    var str = string.Empty;
    //    foreach (var i in text)
    //    {
    //        if (char.IsLower(i))
    //        {
    //            str += '*';
    //        }
    //        else
    //        {
    //            str += i;
    //        }
    //    }
    //    return str;
    //}

    //1.4.0.17
    //static int CountOfOK(string text)
    //{
    //    var count = 0;
    //    for(var i = 0; i < text.Length - 1; i++)
    //    {
    //        if (i == 'o' && i+1 == 'k')
    //        {
    //            ++count;
    //        }
    //    }
    //    return count;
    //}

    //1.4.0.16
    //static string SmallToUpper(string text)
    //{
    //    var str = string.Empty;
    //    foreach (char i in text)
    //    {
    //        if (char.IsLower(i))
    //        {
    //            str += char.ToUpper(i);
    //        }
    //        else
    //        {
    //            str += i;
    //        }
    //    }
    //    return str;
    //}

    //1.4.0.15
    //static bool AllSmallChar(string text)
    //{
    //    var count = 0;
    //    foreach(char i in text)
    //    {
    //        if (char.IsLower(i))
    //        {
    //            count++;
    //        }
    //        else
    //        {
    //            --count;
    //        }
    //    }
    //    if(count == text.Length)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //1.4.0.14
    //static bool AllBigChar(string text)
    //{
    //    var count = 0;
    //    foreach(char i in text)
    //    {
    //        if (char.IsUpper(i))
    //        {
    //            count++;
    //        }
    //        else
    //        {
    //            --count;
    //        }
    //    }
    //    if(count == text.Length)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //1.4.0.13
    //static int BigChar(string text)
    //{
    //    var count = 0;
    //    foreach(char i in text)
    //    {
    //        if (char.IsUpper(i))
    //        {
    //            ++count;
    //        }
    //    }
    //    return count;
    //}

    //1.4.0.12
    //static int CountNumbers(string text)
    //{
    //    var count = 0;
    //    foreach (var i in text)
    //    {
    //        if (char.IsDigit(i))
    //        {
    //            count++;
    //        }
    //    }
    //    return count;
    //}


    //1.4.0.10
    //static bool IsPalindrom(string text)
    //{
    //    var str = string.Empty;
    //    for(var i = text.Length - 1; i > 0; i--)
    //    {
    //        str += text[i];
    //    }
    //    if(str == text)
    //    {
    //        return true;
    //    }
    //    else 
    //    { 
    //        return false; 
    //    }
    //}

    //1.4.0.9
    //static int CountOfSpace(string str)
    //{
    //    var count = 0;
    //    foreach (var i in str)
    //    {
    //        if (char.IsWhiteSpace(i))
    //        {
    //            ++count;
    //        }
    //    }
    //    return count;
    //}

    //1.4.0.8
    //static string ReverseString(string str)
    //{
    //    var text = string.Empty;
    //    for (var i = str[-1]; i >= str.Length; i++)
    //    {
    //        text += str[i];
    //    }
    //    return text;
    //}

    //1.4.0.7
    //static bool IsTub(int num)
    //{
    //    var count = 0;
    //    for(var i = 1; i <= num; i++)
    //    {
    //        if(num % i == 0)
    //        {
    //            ++count;
    //        }
    //    }
    //    if(count == 2)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //1.4.0.5
    //static int CountOfRoom(int num)
    //{
    //    var count = 0;
    //    string s = num.ToString();
    //    foreach (var i in s)
    //    {
    //        if (char.IsDigit(i))
    //        {
    //            ++count;
    //        }
    //    }
    //    return count;
    //}

    //1.4.0.6
    //static bool IsDdigitAll(string text)
    //{ 
    //    var count = 0;
    //    foreach (var i in text)
    //    {
    //        if (char.IsDigit(i))
    //        {
    //            ++count;
    //        }
    //    }
    //    if(count == text.Length)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }
    //}

    //1.4.0.4
    //static int ToqSon(int num1, int num2)
    //{
    //    var count = 0;
    //    for(var i = num1; i <= num2; i++)
    //    {
    //        if(i % 2 != 0)
    //        {
    //            ++count;
    //        }
    //    }
    //    return count;
    //}

    //1.4.0.3
    //static int CountUpperCases(string text)
    //{
    //    var count = 0;
    //    foreach (var item in text)
    //    {
    //        if (char.IsLower(item))
    //        {
    //            ++count;
    //        }
    //    }
    //    return count;
    //}

    //1.4.0.2
    //static string StrReplace(string text)
    //{
    //    return text.Replace('y', 'z').Replace('x', 'y');

    //}

    //1.4.0.1
    //static int SumOfTwoNumbers(int num1, int num2)
    //{
    //    var sum = num1 + num2;
    //    return sum;
    //}
}
