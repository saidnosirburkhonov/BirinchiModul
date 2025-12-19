namespace Dars10;

internal class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        students student1 = new students();
        student1.id = 1;
        student1.name = "Petya";
        student1.age = 22;
        student1.gender = "Male";
        student1.country = "Moscow";
        student1.language = "russian";

        students student2 = new students()
        {
            id = 2,
            name = "Nina",
            age = 29,
            gender = "Female",
            country = "Columbia",
            language = "columbian"
        };
        Console.WriteLine(student1.language);
        Console.WriteLine(student2.name);
    }
   
}
