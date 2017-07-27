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
            //Get attribute values from session data, default to 3 if none exists.
            //3 is the recommended starting attribute value when creating characters because it leaves 6 points for skills
            //Afterwards, determines what the attribute value is and automatically checks the box denoting the current value

            //Awareness
            int Awareness = Convert.ToInt32(HttpContext.Session.GetInt32("Awareness"));
            if(Awareness == 0){
                Awareness = 3;
            }
            ViewBag.AwarenessButtons += "<br><input type='radio' name='Awareness' value='1'";
            if(Awareness == 1){
                ViewBag.AwarenessButtons += " checked";
            }
            ViewBag.AwarenessButtons += "> 1 <input type='radio' name='Awareness' value='2'";
            if(Awareness == 2){
                ViewBag.AwarenessButtons += " checked";
            } 
            ViewBag.AwarenessButtons += "> 2 <input type='radio' name='Awareness' value='3'";
            if(Awareness == 3){
                ViewBag.AwarenessButtons += " checked";
            } 
            ViewBag.AwarenessButtons += "> 3 <input type='radio' name='Awareness' value='4'";
            if(Awareness == 4){
                ViewBag.AwarenessButtons += " checked";
            } 
            ViewBag.AwarenessButtons += "> 4 <input type='radio' name='Awareness' value='5'";
            if(Awareness == 5){
                ViewBag.AwarenessButtons += " checked";
            } 
            ViewBag.AwarenessButtons += "> 5 <input type='radio' name='Awareness' value='6'";
            if(Awareness == 6){
                ViewBag.AwarenessButtons += " checked";
            } 
            ViewBag.AwarenessButtons += "> 6 <input type='radio' name='Awareness' value='7'";
            if(Awareness == 7){
                ViewBag.AwarenessButtons += " checked";
            } 
            ViewBag.AwarenessButtons += "> 7 <input type='radio' name='Awareness' value='8'";
            if(Awareness == 8){
                ViewBag.AwarenessButtons += " checked";
            } 
            ViewBag.AwarenessButtons += "> 8 <input type='radio' name='Awareness' value='9'";
            if(Awareness == 9){
                ViewBag.AwarenessButtons += " checked";
            } 
            ViewBag.AwarenessButtons += "> 9 <br>";

            //Coordination
            int Coordination = Convert.ToInt32(HttpContext.Session.GetInt32("Coordination"));
            if(Coordination == 0){
                Coordination = 3;
            }
            ViewBag.CoordinationButtons += "<br><input type='radio' name='Coordination' value='1'";
            if(Coordination == 1){
                ViewBag.CoordinationButtons += " checked";
            }
            ViewBag.CoordinationButtons += "> 1 <input type='radio' name='Coordination' value='2'";
            if(Coordination == 2){
                ViewBag.CoordinationButtons += " checked";
            } 
            ViewBag.CoordinationButtons += "> 2 <input type='radio' name='Coordination' value='3'";
            if(Coordination == 3){
                ViewBag.CoordinationButtons += " checked";
            } 
            ViewBag.CoordinationButtons += "> 3 <input type='radio' name='Coordination' value='4'";
            if(Coordination == 4){
                ViewBag.CoordinationButtons += " checked";
            } 
            ViewBag.CoordinationButtons += "> 4 <input type='radio' name='Coordination' value='5'";
            if(Coordination == 5){
                ViewBag.CoordinationButtons += " checked";
            } 
            ViewBag.CoordinationButtons += "> 5 <input type='radio' name='Coordination' value='6'";
            if(Coordination == 6){
                ViewBag.CoordinationButtons += " checked";
            } 
            ViewBag.CoordinationButtons += "> 6 <input type='radio' name='Coordination' value='7'";
            if(Coordination == 7){
                ViewBag.CoordinationButtons += " checked";
            } 
            ViewBag.CoordinationButtons += "> 7 <input type='radio' name='Coordination' value='8'";
            if(Coordination == 8){
                ViewBag.CoordinationButtons += " checked";
            } 
            ViewBag.CoordinationButtons += "> 8 <input type='radio' name='Coordination' value='9'";
            if(Coordination == 9){
                ViewBag.CoordinationButtons += " checked";
            } 
            ViewBag.CoordinationButtons += "> 9 <br>";

            //Ingenuity
            int Ingenuity = Convert.ToInt32(HttpContext.Session.GetInt32("Ingenuity"));
            if(Ingenuity == 0){
                Ingenuity = 3;
            }

            ViewBag.IngenuityButtons += "<br><input type='radio' name='Ingenuity' value='1'";
            if(Ingenuity == 1){
                ViewBag.IngenuityButtons += " checked";
            }
            ViewBag.IngenuityButtons += "> 1 <input type='radio' name='Ingenuity' value='2'";
            if(Ingenuity == 2){
                ViewBag.IngenuityButtons += " checked";
            } 
            ViewBag.IngenuityButtons += "> 2 <input type='radio' name='Ingenuity' value='3'";
            if(Ingenuity == 3){
                ViewBag.IngenuityButtons += " checked";
            } 
            ViewBag.IngenuityButtons += "> 3 <input type='radio' name='Ingenuity' value='4'";
            if(Ingenuity == 4){
                ViewBag.IngenuityButtons += " checked";
            } 
            ViewBag.IngenuityButtons += "> 4 <input type='radio' name='Ingenuity' value='5'";
            if(Ingenuity == 5){
                ViewBag.IngenuityButtons += " checked";
            } 
            ViewBag.IngenuityButtons += "> 5 <input type='radio' name='Ingenuity' value='6'";
            if(Ingenuity == 6){
                ViewBag.IngenuityButtons += " checked";
            } 
            ViewBag.IngenuityButtons += "> 6 <input type='radio' name='Ingenuity' value='7'";
            if(Ingenuity == 7){
                ViewBag.IngenuityButtons += " checked";
            } 
            ViewBag.IngenuityButtons += "> 7 <input type='radio' name='Ingenuity' value='8'";
            if(Ingenuity == 8){
                ViewBag.IngenuityButtons += " checked";
            } 
            ViewBag.IngenuityButtons += "> 8 <input type='radio' name='Ingenuity' value='9'";
            if(Ingenuity == 9){
                ViewBag.IngenuityButtons += " checked";
            } 
            ViewBag.IngenuityButtons += "> 9 <br>";

            //Presence
            int Presence = Convert.ToInt32(HttpContext.Session.GetInt32("Presence"));
            if(Presence == 0){
                Presence = 3;
            }
            ViewBag.PresenceButtons += "<br><input type='radio' name='Presence' value='1'";
            if(Presence == 1){
                ViewBag.PresenceButtons += " checked";
            }
            ViewBag.PresenceButtons += "> 1 <input type='radio' name='Presence' value='2'";
            if(Presence == 2){
                ViewBag.PresenceButtons += " checked";
            } 
            ViewBag.PresenceButtons += "> 2 <input type='radio' name='Presence' value='3'";
            if(Presence == 3){
                ViewBag.PresenceButtons += " checked";
            } 
            ViewBag.PresenceButtons += "> 3 <input type='radio' name='Presence' value='4'";
            if(Presence == 4){
                ViewBag.PresenceButtons += " checked";
            } 
            ViewBag.PresenceButtons += "> 4 <input type='radio' name='Presence' value='5'";
            if(Presence == 5){
                ViewBag.PresenceButtons += " checked";
            } 
            ViewBag.PresenceButtons += "> 5 <input type='radio' name='Presence' value='6'";
            if(Presence == 6){
                ViewBag.PresenceButtons += " checked";
            } 
            ViewBag.PresenceButtons += "> 6 <input type='radio' name='Presence' value='7'";
            if(Presence == 7){
                ViewBag.PresenceButtons += " checked";
            } 
            ViewBag.PresenceButtons += "> 7 <input type='radio' name='Presence' value='8'";
            if(Presence == 8){
                ViewBag.PresenceButtons += " checked";
            } 
            ViewBag.PresenceButtons += "> 8 <input type='radio' name='Presence' value='9'";
            if(Presence == 9){
                ViewBag.Presence += " checked";
            } 
            ViewBag.PresenceButtons += "> 9 <br>";

            //Resolve
            int Resolve = Convert.ToInt32(HttpContext.Session.GetInt32("Resolve"));
            if(Resolve == 0){
                Resolve = 3;
            }
            ViewBag.ResolveButtons += "<br><input type='radio' name='Resolve' value='1'";
            if(Resolve == 1){
                ViewBag.ResolveButtons += " checked";
            }
            ViewBag.ResolveButtons += "> 1 <input type='radio' name='Resolve' value='2'";
            if(Resolve == 2){
                ViewBag.ResolveButtons += " checked";
            } 
            ViewBag.ResolveButtons += "> 2 <input type='radio' name='Resolve' value='3'";
            if(Resolve == 3){
                ViewBag.ResolveButtons += " checked";
            } 
            ViewBag.ResolveButtons += "> 3 <input type='radio' name='Resolve' value='4'";
            if(Resolve == 4){
                ViewBag.ResolveButtons += " checked";
            } 
            ViewBag.ResolveButtons += "> 4 <input type='radio' name='Resolve' value='5'";
            if(Resolve == 5){
                ViewBag.ResolveButtons += " checked";
            } 
            ViewBag.ResolveButtons += "> 5 <input type='radio' name='Resolve' value='6'";
            if(Resolve == 6){
                ViewBag.ResolveButtons += " checked";
            } 
            ViewBag.ResolveButtons += "> 6 <input type='radio' name='Resolve' value='7'";
            if(Resolve == 7){
                ViewBag.ResolveButtons += " checked";
            } 
            ViewBag.ResolveButtons += "> 7 <input type='radio' name='Resolve' value='8'";
            if(Resolve == 8){
                ViewBag.ResolveButtons += " checked";
            } 
            ViewBag.ResolveButtons += "> 8 <input type='radio' name='Resolve' value='9'";
            if(Resolve == 9){
                ViewBag.Resolve += " checked";
            } 
            ViewBag.ResolveButtons += "> 9 <br>";

            ///Strength
            int Strength = Convert.ToInt32(HttpContext.Session.GetInt32("Strength"));
            if(Strength == 0){
                Strength = 3;
            }
            ViewBag.StrengthButtons += "<br><input type='radio' name='Strength' value='1'";
            if(Strength == 1){
                ViewBag.StrengthButtons += " checked";
            }
            ViewBag.StrengthButtons += "> 1 <input type='radio' name='Strength' value='2'";
            if(Strength == 2){
                ViewBag.StrengthButtons += " checked";
            } 
            ViewBag.StrengthButtons += "> 2 <input type='radio' name='Strength' value='3'";
            if(Strength == 3){
                ViewBag.StrengthButtons += " checked";
            } 
            ViewBag.StrengthButtons += "> 3 <input type='radio' name='Strength' value='4'";
            if(Strength == 4){
                ViewBag.StrengthButtons += " checked";
            } 
            ViewBag.StrengthButtons += "> 4 <input type='radio' name='Strength' value='5'";
            if(Strength == 5){
                ViewBag.StrengthButtons += " checked";
            } 
            ViewBag.StrengthButtons += "> 5 <input type='radio' name='Strength' value='6'";
            if(Strength == 6){
                ViewBag.StrengthButtons += " checked";
            } 
            ViewBag.StrengthButtons += "> 6 <input type='radio' name='Strength' value='7'";
            if(Strength == 7){
                ViewBag.StrengthButtons += " checked";
            } 
            ViewBag.StrengthButtons += "> 7 <input type='radio' name='Strength' value='8'";
            if(Strength == 8){
                ViewBag.StrengthButtons += " checked";
            } 
            ViewBag.StrengthButtons += "> 8 <input type='radio' name='Strength' value='9'";
            if(Strength == 9){
                ViewBag.StrengthButtons += " checked";
            } 
            ViewBag.StrengthButtons += "> 9 <br>";
            //Remove attribute values from character points
            charP = 24 - Awareness - Coordination - Ingenuity - Presence - Resolve - Strength;
            ViewBag.charP = charP;
            ViewBag.skillP = skillP;
            ViewBag.storyP = storyP; 
            ViewBag.Awareness = Awareness;
            ViewBag.Coordination = Coordination;
            ViewBag.Ingenuity = Ingenuity;
            ViewBag.Presence = Presence;
            ViewBag.Resolve = Resolve;
            ViewBag.Strength = Strength;
            return View();
        }

        //Save selected values to session upon submitting attributes
        [HttpPost]
        [Route("attributes")]
        public IActionResult Attributes(int Awareness, int Coordination, int Ingenuity, int Presence, int Resolve, int Strength)
        {
            HttpContext.Session.SetInt32("Awareness", Awareness);
            HttpContext.Session.SetInt32("Coordination", Coordination);
            HttpContext.Session.SetInt32("Ingenuity", Ingenuity);
            HttpContext.Session.SetInt32("Presence", Presence);
            HttpContext.Session.SetInt32("Resolve", Resolve);
            HttpContext.Session.SetInt32("Strength", Strength);
            return RedirectToAction("Index");
        }
    }
}
