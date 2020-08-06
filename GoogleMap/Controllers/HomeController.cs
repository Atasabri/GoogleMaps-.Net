using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GoogleMap.Models;
using System.Device.Location;

namespace GoogleMap.Controllers
{
    public class HomeController : Controller
    {
        DB db = new DB();
        public ActionResult Index()
        {
            List<Country> list = new List<Country>();
            City city = new City {ID = 1 ,Lat = 30.0596185,Log = 31.1884234,Name = "Cairo",Name_en ="Cairo" };
            City city1 = new City {ID = 2, Lat = 30.0179962,Log = 31.4174191,Name = "New Cairo", Name_en = "New Cairo" };
            City city2 = new City {ID = 3, Lat = 29.9421804,Log = 30.7424803 , Name = "October", Name_en = "October" };
            City city3 = new City {  ID = 4, Lat = 31.041455,Log = 31.34782 , Name = "Mansoora", Name_en = "Mansoora" };



            Country country = new Country { ID = 12, Lat = 29.924631, Log = 31.181634 ,Name="Egypt",Name_en="Egypt",History="Hi From Egypt History"};
            country.Cities.Add(city);
            country.Cities.Add(city1);
            country.Cities.Add(city2);
            country.Cities.Add(city3);
            list.Add(country);
            
            return View(list);
        }
        public ActionResult GetCurrentLatAndLog()
        {
            return View();
        }
    }
}