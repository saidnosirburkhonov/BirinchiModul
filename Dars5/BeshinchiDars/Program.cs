using System;
using System.Collections.Generic;

namespace BeshinchiDars
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1listni uzunligimi kiriting: ");
            var n = int.Parse(Console.ReadLine());
            List<int> value = new List<int>();
            for (var i = 0; i < n; i++)
            {
                Console.Write("1-chi Listga qiymat kiriting: ");
                var num = int.Parse(Console.ReadLine());
                value.Add(num);
            }
            //Console.Write("2listni uzunligimi kiriting: ");
            //var n2 = int.Parse(Console.ReadLine());
            //List<int> value2 = new List<int>();
            //for (var i = 0; i < n; i++)
            //{
            //    Console.Write("2-chi Listga qiymat kiriting: ");
            //    var num2 = int.Parse(Console.ReadLine());
            //    value.Add(num2);
            //}
            //var n = int.Parse(Console.ReadLine());
            //List<string> value = new List<string>();
            //for(var i = 0; i < n; i++)
            //{
            //    value.Add(Console.ReadLine());
            //}
            //CountOfElWith(value);
            //JuftIndeks(value);
            JuftCopy(value);
        }


        //1.5.1.34
        static void JuftCopy(List<int> numa)
        {
            List<int> numb = new List<int>();
            for (var i = 0; i < numa.Count; i++)
            {
                if (numa[i] % 2 == 0)
                {
                    numb.Add(numa[i]);
                }
            }
            Console.WriteLine($"b elementlar: {string.Join(",", numb)}, soni: {numb.Count}");
        }

        //1.5.1.33
        static void ThirdList(List<int> num1, List<int> num2)
        {
            List<int> num3 = new List<int>();
            for (int i = 0; i < num1.Count - 1; i++)
            {
                var res = Math.Max(num1[i], num2[i]);
                num3.Add(res);
            }
            Console.WriteLine(string.Join(",", num3));
        }

        //1.5.1.32
        static void JuftIndeks(List<int> nums)
        {

            List<int> son = new List<int>();
            for (var i = 1; i < nums.Count; i++)
            {
                if (i % 2 == 0)
                {
                    son.Add(nums[i]);
                }
            }
            Console.WriteLine(string.Join(" ", son));
        }

        //1.5.1.31
        static void Toqson(List<int> nums)
        {
            for (var i = 0; i < nums.Count - 2; i++)
            {
                if (nums[i] % 2 != 0 && nums[i + 1] % 2 != 0)
                {
                    nums[i] += nums[i + 1];
                }
                else
                {
                    nums[i] = nums[i];
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        //1.5.1.30
        static void Juftson(List<int> nums)
        {
            for (var i = 0; i < nums.Count - 2; i++)
            {
                if (nums[i] % 2 == 0 && nums[i + 1] % 2 == 0)
                {
                    nums[i] += nums[i + 1];
                }
                else
                {
                    nums[i] = nums[i];
                }
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        //1.5.1.29
        static string AllUpperCase(List<string> text)
        {
            string str = string.Empty;
            foreach (var i in text)
            {
                foreach (var j in i)
                {
                    if ((char.IsUpper(j)))
                    {
                        str += j;
                    }
                }

            }
            return str;
        }

        //1.5.1.28
        static int CountOfElWith(List<string> nums)
        {
            var count = 0;
            foreach (var i in nums)
            {
                if (i[0] == '$')
                    ++count;
            }
            return count;
        }

        //1.5.1.27
        static void SumOfTwoLists(List<int> nums, List<int> nums2)
        {
            List<int> value3 = new List<int>();
            for (var i = 0; i < nums.Count - 1; i++)
            {
                for (var j = 0; j < nums2.Count - 1; j++)
                {
                    if (nums[i] == nums2[j])
                    {
                        value3.Add(nums[i] * nums2[j]);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", value3));
        }

        //1.5.1.26


        //1.5.1.25
        static void SumOfTwoBig(List<int> nums)
        {
            var count = 0;
            var ind1 = 0;
            var ind2 = 0;
            for (var i = 0; i < nums.Count - 1; i++)
            {
                for (var j = 0; j < nums.Count - 1; j++)
                {
                    if (nums[i] + nums[j + 1] > count)
                    {
                        count = nums[i] + nums[i + 1];
                        ind1 = i;
                        ind2 = i + 1;

                    }
                }
            }
            Console.WriteLine($"eng katta elementlar: {nums[ind1]}, {nums[ind2]}");
        }

        //1.5.1.24
        static int SumOfElements(List<int> nums)
        {
            var sum = 0;
            foreach (var i in nums)
            {
                sum += i;
            }
            return sum;
        }

        //1.5.1.23
        static void ChangePlace(List<int> nums)
        {
            List<int> numscopy = new List<int>();
            for (var i = 0; i < nums.Count - 1; i++)
            {
                numscopy.Add(nums[i]);
            }
            //numscopy.Sort();
            var first = numscopy[0];
            var last = numscopy[numscopy.Count - 1];
            nums[0] = last;
            nums[numscopy.Count - 1] = first;
            Console.WriteLine(string.Join(" ", nums));
        }
        //1.5.1.22
        static bool IsSortedReverse(List<int> nums)
        {
            for (var i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }

        //1.5.1.21
        static bool IsSorted(List<int> nums)
        {
            for (var i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    return true;
                }
                else { return false; }
            }
            return false;
        }

        //1.5.1.20
        static string IsDesicionTo3And4(List<int> nums)
        {
            for (var i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 3 == 0 && nums[i] % 4 == 0)
                {
                    continue;
                }
                else { return "salom"; }
            }
            return "hello";
        }

        //1.5.1.18
        static int ElLowFromFirst(List<int> nums)
        {
            var count = 0;
            for (var i = 1; i < nums.Count; i++)
            {
                if (nums[0] > nums[i])
                {
                    ++count;
                }
            }
            return count;
        }

        //1.5.1.17
        static string MinusAndPlus(List<int> nums)
        {
            var minus = 0;
            var plus = 0;
            foreach (var i in nums)
            {
                if (i < 0)
                {
                    ++minus;
                }
                else { ++plus; }
            }
            return $"{minus}-ta manfiy, {plus}-ta musbat";
        }

        //1.5.1.16
        static void SumHundred(List<int> value)
        {
            for (var i = 0; i < value.Count; i++)
            {
                if (value[i] > 9 && value[i] < 100)
                {
                    value[i] += 100;
                }
            }
            Console.WriteLine(string.Join(",", value));
        }

        //1.5.1.15
        static string SumOfMinAndMax(List<int> nums)
        {
            nums.Sort();
            return $"{nums[0]} min,  {nums[nums.Count - 1]} max";
        }

        //1.5.1.14
        static int MinValue(List<int> nums)
        {
            nums.Sort();
            return nums[0];
        }

        //1.5.1.13
        static bool IsTrue(List<int> nums)
        {
            if (nums[0] % 2 == 0 && nums[1] % 2 == 0 && nums[nums.Count - 1] % 2 != 0 && nums[nums.Count - 2] % 2 != 0)
            {
                return true;
            }
            else return false;
        }

        //1.5.1.12
        static bool IsTwoRoomed(List<int> nums)
        {
            for (var i = 0; i < 3; i++)
            {
                if (nums[i] >= 10 && nums[i] <= 99)
                {
                    continue;
                }
                else return false;
            }
            return true;
        }

        //1.5.1.11
        static bool IsDevisionTofive(List<int> nums)
        {
            var count = 0;
            foreach (var i in nums)
            {
                if (i % 5 == 0)
                {
                    ++count;
                }
            }
            if (count == nums.Count) return true;
            return false;
        }

        //1.5.1.10
        static void MultiplyToThree(List<int> nums)
        {
            for (var i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums[i] *= 3;
                }
            }
            //nums.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(string.Join(" ", nums));
        }

        //1.5.1.9
        static bool CountOfToqOrJuft(List<int> nums)
        {
            var toq = 0;
            var juft = 0;
            foreach (var i in nums)
            {
                if (i % 2 == 0)
                {
                    ++juft;
                }
                else
                {
                    ++toq;
                }
            }
            if (toq > juft)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //1.5.1.8/
        static void SumOfThreeElReverse(List<int> nums)
        {
            var sum = 0;
            sum += nums[nums.Count - 1];
            sum += nums[nums.Count - 2];
            sum += nums[nums.Count - 3];
            Console.WriteLine(sum);
        }

        //1.5.1.7
        static void SumOfThreeEl(List<int> nums)
        {
            var sum = 0;
            sum += nums[0];
            sum += nums[1];
            sum += nums[2];
            Console.WriteLine(sum);
        }

        //1.5.1.6
        static void ChangeFirstAndLastEl(List<int> nums)
        {
            List<int> res = new List<int>
            {
                nums[nums.Count - 1]
            };
            for (var i = 1; i < nums.Count - 1; i++)
            {
                res.Add(nums[i]);
            }
            res.Add(nums[0]);
            Console.WriteLine(string.Join(",", nums));
        }

        //1.5.1.5
        static string CountOfToqAndSum(List<int> nums)
        {
            var count = 0;
            var sum = 0;
            for (var i = 0; i < nums.Count; i++)
            {
                if (nums[i] >= 10 && nums[i] <= 99 && nums[i] % 2 != 0)
                {
                    ++count;
                    sum += nums[i];
                }
            }
            return $"{count}ta element toq va ularni yigindisi: {sum}";
        }

        //1.5.1.4
        static int CountOfElDivisionTo3And7(List<int> nums)
        {
            int count = 0;
            for (var i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 3 == 0 && nums[i] % 7 == 0)
                {
                    ++count;
                }
            }
            return count;
        }

        //1.5.1.3
        static int CountOfToqEl(List<int> nums)
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

        //1.5.1.2
        static int CountOfJuftElements(List<int> son)
        {
            int count = 0;
            foreach (var i in son)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        //1.5.1.1
        static int CountOfNUmbersWithThreeRoom(List<int> num)
        {
            int count = 0;
            foreach (int i in num)
            {
                if (i >= 100 && i <= 999)
                {
                    ++count;
                }
            }
            return count;
        }
    }
}