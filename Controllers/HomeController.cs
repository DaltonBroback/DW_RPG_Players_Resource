using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AiTaS.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            //Default starting values
            int charP = 24;
            int skillP = 18;
            int storyP = 12;
            //Grab attribute values
            int AwarenessVal = Convert.ToInt32(HttpContext.Session.GetInt32("AwarenessVal"));
            int CoordinationVal = Convert.ToInt32(HttpContext.Session.GetInt32("CoordinationVal"));
            int IngenuityVal = Convert.ToInt32(HttpContext.Session.GetInt32("IngenuityVal"));
            int PresenceVal = Convert.ToInt32(HttpContext.Session.GetInt32("PresenceVal"));
            int ResolveVal = Convert.ToInt32(HttpContext.Session.GetInt32("ResolveVal"));
            int StrengthVal = Convert.ToInt32(HttpContext.Session.GetInt32("StrengthVal"));
            //Remove attribute values from character points
            charP = 24 - AwarenessVal - CoordinationVal - IngenuityVal - PresenceVal - ResolveVal - StrengthVal;
            ViewBag.charP = charP;
            ViewBag.skillP = skillP;
            ViewBag.storyP = storyP; 
            ViewBag.AwarenessVal = AwarenessVal;
            ViewBag.CoordinationVal = CoordinationVal;
            ViewBag.IngenuityVal = IngenuityVal;
            ViewBag.PresenceVal = PresenceVal;
            ViewBag.ResolveVal = ResolveVal;
            ViewBag.StrengthVal = StrengthVal;
            return View();
        }
        [HttpPost]
        [Route("attributes")]
        public IActionResult Attributes(int Awareness, int Coordination, int Ingenuity, int Presence, int Resolve, int Strength)
        {
            //Get value of Awareness Attribute
            int AwarenessVal = 0;
            if(Awareness != 1 || Awareness != 2 || Awareness != 3 || Awareness != 4 || Awareness != 5 ){
                AwarenessVal = Awareness;
            }
            HttpContext.Session.SetInt32("AwarenessVal", AwarenessVal);
            //Get value of Coordination Attribute
            int CoordinationVal = 0;
            if(Coordination != 1 || Coordination != 2 || Coordination != 3 || Coordination != 4 || Coordination != 5 ){
                CoordinationVal = Coordination;
            }
            HttpContext.Session.SetInt32("CoordinationVal", CoordinationVal);
            //Get value of Ingenuity Attribute
            int IngenuityVal = 0;
            if(Ingenuity != 1 || Ingenuity != 2 || Ingenuity != 3 || Ingenuity != 4 || Ingenuity != 5 ){
                IngenuityVal = Ingenuity;
            }
            HttpContext.Session.SetInt32("IngenuityVal", IngenuityVal);
            //Get value of Presence Attribute
            int PresenceVal = 0;
            if(Presence != 1 || Presence != 2 || Presence != 3 || Presence != 4 || Presence != 5 ){
                PresenceVal = Presence;
            }
            HttpContext.Session.SetInt32("PresenceVal", PresenceVal);
            //Get value of Resolve Attribute
            int ResolveVal = 0;
            if(Resolve != 1 || Resolve != 2 || Resolve != 3 || Resolve != 4 || Resolve != 5 ){
                ResolveVal = Resolve;
            }
            HttpContext.Session.SetInt32("ResolveVal", ResolveVal);
            //Get value of Strength Attribute
            int StrengthVal = 0;
            if(Strength != 1 || Strength != 2 || Strength != 3 || Strength != 4 || Strength != 5 ){
                StrengthVal = Strength;
            }
            HttpContext.Session.SetInt32("StrengthVal", StrengthVal);
            return RedirectToAction("Index");
        }
    }
}
