using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using weather_app_crewin.Models;

namespace weather_app_crewin.Controllers
{
    public class WeatherController : Controller
    {
        weather_info info = new weather_info();
        Context context = new Context();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(weather_info wi)
        {
            if (ModelState.IsValid)
            {
                //context.weather_infos.Add(wi);
                info.city_name = wi.city_name;
                //context.weather_infos.Add(wi);
               

                string api = "87bd1dc2556a82a07ecb41c6cd02cd97";

                string sehir = info.city_name.ToString();
                ViewBag.v2 = sehir;
                string secnd = "&mode=xml&lang=tr&units=metric&appid=" + api;
                string path = "https://api.openweathermap.org/data/2.5/weather?q=" + sehir + secnd;
                XDocument shr = XDocument.Load(path);
                ViewBag.v1 = shr.Descendants("temperature").ElementAt(0).Attribute("value").Value;


                string yl = "&mode=xml&appid=87bd1dc2556a82a07ecb41c6cd02cd97";
                string path2 = "https://api.openweathermap.org/data/2.5/forecast?q=" + sehir + yl;
                XDocument pat2 = XDocument.Load(path2);

                ViewBag.v3 = pat2.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                ViewBag.v4 = pat2.Descendants("temperature").ElementAt(1).Attribute("value").Value;
                ViewBag.v5 = pat2.Descendants("temperature").ElementAt(2).Attribute("value").Value;
                ViewBag.v6= pat2.Descendants("temperature").ElementAt(3).Attribute("value").Value;
                ViewBag.v7= pat2.Descendants("temperature").ElementAt(4).Attribute("value").Value;




                //ViewBag.v3 = pat2.Descendants("temperature").ElementAt(0).Attribute("value").Value;

                return View();
            }
            else
            {
                return View();
            }
            
            


            //string api = "d9c532abada5d1ea71d00f9be75c07bf";
            //string istanbul = "https://api.openweathermap.org/data/2.5/weather?q=istanbul&mode=xml&lang=tr&units=metric&appid=" + api;
            //string izmir = "https://api.openweathermap.org/data/2.5/weather?q=izmir&mode=xml&lang=tr&units=metric&appid=" + api;
            //string duzce = "https://api.openweathermap.org/data/2.5/weather?q=duzce&mode=xml&lang=tr&units=metric&appid=" + api;
            //string ankara = "https://api.openweathermap.org/data/2.5/weather?q=ankara&mode=xml&lang=tr&units=metric&appid=" + api;
            //string konya = "https://api.openweathermap.org/data/2.5/weather?q=konya&mode=xml&lang=tr&units=metric&appid=" + api;


            //XDocument ist = XDocument.Load(istanbul);
            //XDocument izr = XDocument.Load(izmir);
            //XDocument dzc = XDocument.Load(duzce);
            //XDocument ankr = XDocument.Load(ankara);
            //XDocument kny = XDocument.Load(konya);

            

            //ViewBag.v1 = ist.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //ViewBag.v2 = izr.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //ViewBag.v3 = dzc.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //ViewBag.v4 = ankr.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            //ViewBag.v5 = kny.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //return View();
        }
        public IActionResult Details()
        {
            
            return View();
        }
    }
}
