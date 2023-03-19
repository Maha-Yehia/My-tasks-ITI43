namespace Task1.Model
{
    public class CarList
    {
        public static List<Car> Cars = new List<Car>()
       {
            new Car() { Num = 1, Color = "red", Model = "2002", Manufacture = "Kia" },
            new Car() { Num= 2, Color= "white", Model = "2015", Manufacture = "Seat" },
            new Car() { Num= 3, Color= "black", Model = "2004", Manufacture = "Toyota" },
            new Car() { Num= 4, Color= "silver", Model = "2022", Manufacture = "Marcedes" },
            new Car() { Num= 5, Color= "blue", Model = "2023", Manufacture = "Kia" }
       };

    }
}
