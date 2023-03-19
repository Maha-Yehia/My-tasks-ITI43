using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CarList
    {
        public static List<Car> Cars = new List<Car>()
        {
            new Car() {Num=1 , Color="Red" , Manufacture="Toyota", Model="2002" },
            new Car() {Num=2 , Color="White" , Manufacture="Honda", Model="2022" },
            new Car() {Num=3 , Color="Blue" , Manufacture="Hunday", Model="2010" },
            new Car() {Num=4 , Color="Black" , Manufacture="Kia", Model="2012" },
            new Car() {Num=5 , Color="Silver" , Manufacture="Marcedes", Model="2015" },
            new Car() {Num=6 , Color="Dark blue" , Manufacture="Ferrari", Model="2017" },
            new Car() {Num=7 , Color="Black" , Manufacture="Seat", Model="2020" },
            new Car() {Num=8 , Color="Yellow" , Manufacture="Lancer", Model="2023" },

        };

    }
}