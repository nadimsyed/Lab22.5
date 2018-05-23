using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab22._5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string userName, string color, string favoriteFood)
        {
            ViewBag.UserName = userName;
            ViewBag.Color = color;
            ViewBag.FavoriteFood = favoriteFood;

            return View();
        }

        public ActionResult LogIn(string userName, string color, string favoriteFood)
        {
            if (Session["UserName"] == null)
            {
                Session.Add("UserName", userName);
            }
            if (Session["Color"] == null)
            {
                Session.Add("Color", color);
            }
            if (Session["FavoriteFood"] == null)
            {
                Session.Add("FavoriteFood", favoriteFood);
            }
            return View();
        }

        public ActionResult Welcome()
        {
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Clear();
            return View();
        }
    }
}