namespace Dars11;

internal class Program
{
    static List<Employee> workers = new List<Employee>();
    static List<Books> books = new List<Books>();
    static List<Courses> courses = new List<Courses>();
    static List<Flights> flights = new List<Flights>();
    static List<Games> games = new List<Games>();
    static List<Hotels> hotels = new List<Hotels>();
    static List<Movies> movies = new List<Movies>();
    static List<Orders> orders = new List<Orders>();
    static List<Restaurants> restaurants = new List<Restaurants>();
    static void Main(string[] args)
    {
        //School school = CreateSchool1();
        //FillSchoolObject(school);
        //Display(school);
        //Console.WriteLine(GetAvailablePlaces(school));


        //-------------------------EmployeeCRUD------------------------------------------------

        //Employee employee1 = new Employee()
        //{
        //    GuidId = Guid.NewGuid(),
        //    FirstName = "John",
        //    LastName = "Thompson",
        //    Position = "SWE",
        //    Salary = 150000,
        //    Age = 34
        //};
        //Employee employee2 = new Employee();
        //employee2.GuidId = Guid.NewGuid();
        //employee2.FirstName = "Shokhrukh";
        //employee2.LastName = "Khan";
        //employee2.Position = "Actor";
        //employee2.Salary = 12000000;
        //employee2.Age = 30;

        //AddEmployee(employee1);
        //AddEmployee(employee2);

        //DisplayEmployees();
        //-------------------------EmployeeCRUD------------------------------------------------

    }



    //-------------------------Start--------RestaurantsCRUD-------------------------------
    static void AddRestaurant(Restaurants restaurant)
    {
        restaurants.Add(restaurant);
    }
    static void UpdateRestaurant(Guid restaurantId, Restaurants newRestaurant)
    {
        for (var i = 0; i < restaurants.Count; i++)
        {
            if (restaurants[i].RestaurantId == restaurantId)
            {
                newRestaurant.RestaurantId = restaurants[i].RestaurantId;
                restaurants[i] = newRestaurant;
                break;
            }
        }
    }
    static void RemoveRestaurant(Guid restaurantId)
    {
        foreach (var res in restaurants)
        {
            if(res.RestaurantId == restaurantId)
            {
                restaurants.Remove(res);
                break;
            }
        }
    }
    static void DisplayRestaurants()
    {
        foreach (var res in restaurants)
        {
            Console.WriteLine(res.RestaurantId);
            Console.WriteLine(res.Name);
            Console.WriteLine(res.Cuisine);
            Console.WriteLine(res.City);
            Console.WriteLine(res.a);
        }
    }
    //-------------------------End--------RestaurantsCRUD-------------------------------



    //-------------------------Start--------OrdersCRUD-------------------------------
    static void AddOrder(Orders order)
    {
        orders.Add(order);
    }
    static void UpdateOrder(Guid orderId, Orders newOrder)
    {
        for (var i = 0; i < orders.Count; i++)
        {
            if (orders[i].OrderId == orderId)
            {
                newOrder.OrderId = orders[i].OrderId;
                orders.[i] = newOrder;
                break;
            }
        }
    }
    static void RemoveOrder(Guid orderId)
    {
        foreach (var ord in orders)
        {
            if(ord.OrderId == orderId)
            {
                orders.Remove(ord);
                break;
            }
        }
    }
    static void DisplayOrders()
    {
        foreach (var or in orders)
        {
            Console.WriteLine(or.OrderId);
            Console.WriteLine(or.CustomerName);
            Console.WriteLine(or.OrderDate);
            Console.WriteLine(or.TotalPrice);
            Console.WriteLine(or.IsDelivered);
        }
    }
    //-------------------------End--------OrdersCRUD-------------------------------



    //-------------------------Start--------MoviesCRUD-------------------------------
    static void AddMovie(Movies movie)
    {
        movies.Add(movie);
    }
    static void UpdateMovie(Guid movieId, Movies newMovie)
    {
        for (var i = 0; i < movies.Count; i++)
        {
            if (movies[i].MovieId == movieId)
            {
                newMovie.MovieId = movies[i].MovieId;
                movies[i] = newMovie;
                break;
            }
        }
    }
    static void RemoveMovie(Guid movieId)
    {
        foreach (var mov in movies)
        {
            if(mov.MovieId == movieId)
            {
                movies.Remove(mov);
            }
        }
    }
    static void DisplayMovies()
    {
        foreach (var mov in movies)
        {
            Console.WriteLine(mov.MovieId);
            Console.WriteLine(mov.Title);
            Console.WriteLine(mov.Genre);
            Console.WriteLine(mov.Duration);
            Console.WriteLine(mov.Rating);
            Console.WriteLine(mov.ReleaseYear);
        }
    }
    //-------------------------End--------MoviesCRUD-------------------------------



    //-------------------------Start--------HotelsCRUD-------------------------------
    static void AddHotel(Hotels hotel)
    {
        hotels.Add(hotel);
    }
    static void UpdateHotel(Guid hotelId, Hotels newHotel)
    {
        for (var i = 0; i < hotels.Count; i++)
        {
            if (hotels[i].HotelId == hotelId)
            {
                newHotel.HotelId = hotels[i].HotelId;
                hotels[i] = newHotel;
                break;
            }
        }
    }
    static void RemoveHotel(Guid hotelId)
    {
        foreach (var hotel in hotels)
        {
            if(hotel.HotelId == hotelId)
            {
                hotels.Remove(hotel);
            }
        }
    }
    static void DisplayHotels()
    {
        foreach (var hot in hotels)
        {
            Console.WriteLine(hot.HotelId);
            Console.WriteLine(hot.Name);
            Console.WriteLine(hot.City);
            Console.WriteLine(hot.Stars);
            Console.WriteLine(hot.PricePerNight);
        }
    }
    //-------------------------End--------HotelsCRUD-------------------------------




    //-------------------------Start--------GamesCRUD-------------------------------
    static void AddGame(Games game)
    {
        games.Add(game);
    }
    static void UpdateGame(Guid gameId, Games newGame)
    {
        for (var i = 0; i < games.Count; i++)
        {
            if(games[i].GameId == gameId)
            {
                newGame.GameId = games[i].GameId;
                games[i] = newGame;
                break;
            }
        }
    }
    static void RemoveGame(Guid gameId)
    {
        foreach (var game in games)
        {
            if(game.GameId == gameId)
            {
                games.Remove(game);
            }
        }
    }
    static void DisplayGames()
    {
        foreach (var game in games)
        {
            Console.WriteLine(game.GameId);
            Console.WriteLine(game.Title);
            Console.WriteLine(game.Genre);
            Console.WriteLine(game.Platform);
            Console.WriteLine(game.Rating);
        }
    }
    //-------------------------End--------GamesCRUD-------------------------------





    //-------------------------Start--------FlightsCRUD-------------------------------
    static void AddFlight(Flights flight)
    {
        flights.Add(flight);
    }
    static void UpdateFlight(Guid flightId, Flights newFlight)
    {
        for (var i = 0; i < flights.Count; i++)
        {
            if (flights[i].FlightId == flightId)
            {
                newFlight.FlightId = flights[i].FlightId;
                flights[i] = newFlight;
                break;
            }
        }
    }
    static void RemoveFlight(Guid flightId)
    {
        foreach (var flight in flights)
        {
            if(flight.FlightId == flightId)
            {
                flights.Remove(flight);
                break;
            }
        }
    }
    static void DisplayFlights()
    {
        foreach (var flight in flights)
        {
            Console.WriteLine(flight.FlightId);
            Console.WriteLine(flight.From);
            Console.WriteLine(flight.To);
            Console.WriteLine(flight.Duration);
            Console.WriteLine(flight.Price);
        }
    }
    //-------------------------End--------FlightsCRUD-------------------------------




    //-------------------------Start--------CoursesCRUD-------------------------------
    static void AddCourse(Courses course)
    {
        courses.Add(course);
    }
    static void UpdateCourse(Guid courseId, Courses newCourse)
    {
        for (var i = 0; i < courses.Count; i++)
        {
            if (courses[i].CouseId == courseId)
            {
                newCourse.CouseId = courses[i].CouseId;
                courses[i] = newCourse;
                break;

            }
        }
    }
    static void RemoveCourse(Guid courseId)
    {
        foreach (var course in courses)
        {
            if(course.CouseId == courseId)
            {
                courses.Remove(course);
                break;
            }
        }
    }
    static void DisplayCourses()
    {
        foreach (var course in courses)
        {
            Console.WriteLine(course.CouseId);
            Console.WriteLine(course.Title);
            Console.WriteLine(course.Level);
            Console.WriteLine(course.DurationHours);
            Console.WriteLine(course.Price);
        }
    }
    //-------------------------End--------CoursesCRUD-------------------------------




    //-----------------------------Start---BookCRUD----------------------------------------
    static void AddBook(Books book)
    {
        books.Add(book);
    }
    static void UpdateBook(Guid bookId, Books newBook)
    {
        for(var i = 0; i < books.Count; i++)
        {
            if (books[i].BookId == bookId)
            {
                newBook.BookId = books[i].BookId;
                books[i] = newBook;
                break;
            }
        }
    }
    static void RemoveBook(Guid bookId)
    {
        for (var i = 0; i < books.Count; i++)
        {
            if (books[i].BookId == bookId)
            {
                books.Remove(books[i]);
                break;
            }
        }
    }
    static void DisplayBooks()
    {
        foreach (var book in books)
        {
            Console.WriteLine(book.BookId);
            Console.WriteLine(book.Title);
            Console.WriteLine(book.Author);
            Console.WriteLine(book.Pages);
            Console.WriteLine(book.Year);
            Console.WriteLine(book.IsAvailable);
        }
    }
    //-----------------------------End----BookCRUD----------------------------------------




    //-------------------------Start--------EmployeeCRUD-------------------------------
    static void AddEmployee(Employee employee)
    {
        workers.Add(employee);
    }
    static void UpdateEmployee(Guid guidId, Employee newEmployee)
    {
        for (var i = 0; i < workers.Count; i++)
        {
            if (workers[i].GuidId == guidId)
            {
                newEmployee.GuidId = guidId;
                workers[i] = newEmployee;
                break;
            }
        }
    }
    static void RemoveEmployee(Guid guidId)
    {
        foreach (var empl in workers)
        {
            if (empl.GuidId == guidId)
            {
                workers.Remove(empl);
                break;
            }
        }
    }
    static void DisplayEmployees()
    {
        foreach (var empl in workers)
        {
            Console.WriteLine(empl.GuidId);
            Console.WriteLine(empl.FirstName);
            Console.WriteLine(empl.LastName);
            Console.WriteLine(empl.Position);
            Console.WriteLine(empl.Salary);
            Console.WriteLine(empl.Age);
        }
    }
    //-------------------------End---------EmployeeCRUD------------------------------------------------




    //----------------------------Start---------SchoolCRUD------------------------------------------------
    static School CreateSchool1()
    {
        return new School();
    }
    static School CreateSchool2()
    {
        School school = new School();
        return school;
    }
    static void FillSchoolObject(School school)
    {
        Console.Write("maktab raqami: ");
        school.Number = int.Parse(Console.ReadLine());
        Console.Write("maktab nomi: ");
        school.Name = Console.ReadLine();
        Console.Write("maktab manzili: ");
        school.Location = Console.ReadLine();
        Console.Write("maktab sigimi: ");
        school.Capacity = int.Parse(Console.ReadLine());
        Console.Write("talabalar soni: ");
        school.CurrentStudentCount = int.Parse(Console.ReadLine());
    }
    static void Display(School school)
    {
        Console.WriteLine(school.Number);
        Console.WriteLine(school.Name);
        Console.WriteLine(school.Location);
        Console.WriteLine(school.Capacity);
        Console.WriteLine(school.CurrentStudentCount);
    }

    static int GetAvailablePlaces(School school)
    {
        return school.Capacity - school.CurrentStudentCount;
    }
    //----------------------------End------SchoolCRUD------------------------------------------------

}
