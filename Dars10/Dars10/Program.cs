namespace Dars10;

internal class Program
{
    static void Main(string[] args)
    {
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
        //--------------------------Planets------------------------------
        Planets saturn = new Planets()
        {
            radius = 1000000000,
            color = "grey",
            placeinourgalaxy = 5,
            visiablefromearth = false,
            isbigfromearth = true
        };
        Planets merkuriy = new Planets();
        merkuriy.radius = 10000000;
        merkuriy.color = "red";
        merkuriy.placeinourgalaxy = 2;
        merkuriy.visiablefromearth= false;
        merkuriy.isbigfromearth = false;

        Planets moon = new Planets()
        {
            radius = 200000000,
            color = "white",
            placeinourgalaxy = 6,
            visiablefromearth = true,
            isbigfromearth = false
        };

        Planets sun = new Planets()
        {
            radius = 900000000000,
            color = "yellow",
            placeinourgalaxy = 1,
            visiablefromearth = true,
            isbigfromearth = true
        };

        Planets mars = new Planets()
        {
            radius = 9600000000,
            color = "brown",
            placeinourgalaxy = 7,
            visiablefromearth = false,
            isbigfromearth = true
        };
        //----------------------------Countries----------------------------------
        Countries usa = new Countries();
        usa.countofpopulation = 200000000;
        usa.mainproduct = "education";
        usa.waytosea = true;
        usa.nationalsport = "soccer";
        usa.continent = "NorthAmerika";
        usa.language = "english";

        Countries italy = new Countries()
        {
            countofpopulation = 25000000,
            mainproduct = "pizza",
            waytosea = true,
            nationalsport = "football",
            continent = "Evrope",
            language = "italian"
        };

        Countries Senegal = new Countries()
        {
            countofpopulation = 15000000,
            mainproduct = "coffee",
            waytosea = true,
            nationalsport = "wrestling",
            continent = "Afrika",
            language = "senegal"
        };
        Countries Kanada = new Countries()
        {
            countofpopulation = 55000000,
            mainproduct = "pizza",
            waytosea = true,
            nationalsport = "regby",
            continent = "NorthAmerika",
            language = "canadian"
        };
        Countries Kazahstan = new Countries()
        {
            countofpopulation = 25000000,
            mainproduct = "beshbarmak",
            waytosea = false,
            nationalsport = "kopkari",
            continent = "Asia",
            language = "kazah"
        };

        //-----------------------------Houses-------------------------------

        Houses house1 = new Houses();
        house1.locationofstreet = "Muqimiy street";
        house1.countofstages = 2;
        house1.countofrooms = 8;
        house1.typeofheating = "tyopli pol";
        house1.sizeofterritori = "12 sotix";
        house1.hasgarden = true;
        house1.haspool = false;

        Houses house2 = new Houses()
        {
            locationofstreet = "Rakat street",
            countofrooms = 12,
            countofstages = 2,
            typeofheating = "gaz",
            sizeofterritori = "15 sotix",
            hasgarden = true,
            haspool = true,
        };

        Houses house3 = new Houses()
        {
            locationofstreet = "Yangi hayot street",
            countofrooms = 14,
            countofstages = 3,
            typeofheating = "gaz",
            sizeofterritori = "13 sotix",
            hasgarden = false,
            haspool = false,
        }; 
        Houses house4 = new Houses()
        {
            locationofstreet = "Taras Shevchenko street",
            countofrooms = 18,
            countofstages = 2,
            typeofheating = "tepliy pol",
            sizeofterritori = "20 sotix",
            hasgarden = true,
            haspool = true,
        }; 
        Houses house5 = new Houses()
        {
            locationofstreet = "Shota Rustaveli street",
            countofrooms = 10,
            countofstages = 1,
            typeofheating = "gaz",
            sizeofterritori = "15 sotix",
            hasgarden = true,
            haspool = true,
        };

        //------------------------------Schools-----------------------------------

        Schools RahimovSchool = new Schools();
        RahimovSchool.street = "Mirzo Ulugbek street";
        RahimovSchool.countofpupils = 5000;
        RahimovSchool.isfree = false;
        RahimovSchool.secondforeignlanguage = "english";
        RahimovSchool.hascoworking = false;
        RahimovSchool.haskitchen = true;
        RahimovSchool.mainlanguage = "uzbek";

        Schools JahonSchool = new Schools()
        {
            street = "Xalqlar Dostligi street",
            countofpupils = 1500,
            isfree = false,
            secondforeignlanguage = "rusian, english",
            haskitchen = true,
            hascoworking = true,
            mainlanguage = "uzbek"
        };

        Schools ThompsonSchool = new Schools()
        {
            street = "Muqimiy street",
            countofpupils = 2500,
            isfree = false,
            secondforeignlanguage = "english",
            haskitchen = true,
            hascoworking = false,
            mainlanguage = "russian"
        };
        Schools EvroAsiaSchool = new Schools()
        {
            street = "Bunyodkor street",
            countofpupils = 2000,
            isfree = false,
            secondforeignlanguage = "english",
            haskitchen = true,
            hascoworking = true,
            mainlanguage = "russian"
        };
        Schools PresidentSchool = new Schools()
        {
            street = "WhiteHouse street",
            countofpupils = 1500,
            isfree = true,
            secondforeignlanguage = "rusian, english",
            haskitchen = true,
            hascoworking = true,
            mainlanguage = "uzbek"
        };
        //------------------------------Laptops-----------------------------
        Laptops laptop1 = new Laptops();
        laptop1.brand = "HP";
        laptop1.price = 500;
        laptop1.hasrgbkeyboard = false;
        laptop1.protsessor = "Intel Core I7";
        laptop1.memory = 1;
        laptop1.manufactoringyear = 2023;

        Laptops laptop2 = new Laptops()
        {
            brand = "MacBook",
            price = 1000,
            hasrgbkeyboard = false,
            protsessor = "Imd Ryzen 7",
            memory = 1,
            manufactoringyear = 2020
        };
        Laptops laptop3 = new Laptops()
        {
            brand = "Acer",
            price = 700,
            hasrgbkeyboard = true,
            protsessor = "Intel Core I5",
            memory = 560,
            manufactoringyear = 2023
        };
        Laptops laptop4 = new Laptops()
        {
            brand = "Dell",
            price = 1000,
            hasrgbkeyboard = true,
            protsessor = "Imd Ryzen 8",
            memory = 1,
            manufactoringyear = 2024
        };
        Laptops laptop5 = new Laptops()
        {
            brand = "Lenovo",
            price = 1500,
            hasrgbkeyboard = true,
            protsessor = "Intel Core I9",
            memory = 1,
            manufactoringyear = 2025
        };




    }

}
