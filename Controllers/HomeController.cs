using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AiTaS;

namespace AiTaS.Controllers
{
    public class HomeController : Controller
    {
        public static Traits traits = new Traits();

        // private readonly Traits Traits;

        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string name = HttpContext.Session.GetString("charName");
            string goal = HttpContext.Session.GetString("charGoal");
            string personality = HttpContext.Session.GetString("charPersonality");
            string background = HttpContext.Session.GetString("charBackground");
            string buttons = HttpContext.Session.GetString("charButtons");
            
            if(name == null){
                name = "The Doctor";
            }
            if(goal == null){
                goal = "To find out if he is a good man.";
            }
            if(personality == null){
                personality = "Quirky and not always easy to get alomg with, but never cruel or cowardly.";
            }
            if(background == null){
                background = "Not much is known about him except that he stole his TARDIS from Gallifrey";
            }
            if(buttons == null){
                buttons = "<button action = 'submit' name = 'bioOptions' value = 'edit'>Edit</button>";
            }

            ViewBag.name = name;
            ViewBag.goal = goal;
            ViewBag.personality = personality;
            ViewBag.background = background;
            ViewBag.buttons = buttons;

            HttpContext.Session.SetString("charName", name);
            HttpContext.Session.SetString("charGoal", goal);
            HttpContext.Session.SetString("charPersonality", personality);
            HttpContext.Session.SetString("charBackground", background);
            HttpContext.Session.SetString("charButtons", buttons);
    
        

            //Default starting values
            int charP = 24;
            int skillP = 18;
            int storyP = 12;

            //*************************************************
            //ATTRIBUTES
            //*************************************************
            //Get attribute values from session data, default to 3 if none exists.
            //3 is the recommended starting attribute value when creating characters because it leaves 6 points for skills
            //Afterwards, determines what the attribute value is and automatically checks the box denoting the current value

            //Awareness
            int Awareness = Convert.ToInt32(HttpContext.Session.GetInt32("Awareness"));
            if(Awareness == 0){
                Awareness = 3;
            }
            AwarenessConvert(Awareness);

            //Coordination
            int Coordination = Convert.ToInt32(HttpContext.Session.GetInt32("Coordination"));
            if(Coordination == 0){
                Coordination = 3;
            }
            CoordinationConvert(Coordination);

            //Ingenuity
            int Ingenuity = Convert.ToInt32(HttpContext.Session.GetInt32("Ingenuity"));
            if(Ingenuity == 0){
                Ingenuity = 3;
            }
            IngenuityConvert(Ingenuity);

            //Presence
            int Presence = Convert.ToInt32(HttpContext.Session.GetInt32("Presence"));
            if(Presence == 0){
                Presence = 3;
            }
            PresenceConvert(Presence);

            //Resolve
            int Resolve = Convert.ToInt32(HttpContext.Session.GetInt32("Resolve"));
            if(Resolve == 0){
                Resolve = 3;
            }
            ResolveConvert(Resolve);
            
            ///Strength
            int Strength = Convert.ToInt32(HttpContext.Session.GetInt32("Strength"));
            if(Strength == 0){
                Strength = 3;
            }
            StrengthConvert(Strength);
            
        
            //*************************************************
            //Skills
            //*************************************************
            int athletics = Convert.ToInt32(HttpContext.Session.GetInt32("Athletics"));
            int convince = Convert.ToInt32(HttpContext.Session.GetInt32("Convince"));
            int craft = Convert.ToInt32(HttpContext.Session.GetInt32("Craft"));
            int fighting = Convert.ToInt32(HttpContext.Session.GetInt32("Fighting"));
            int knowledge = Convert.ToInt32(HttpContext.Session.GetInt32("Knowledge"));
            int marksman = Convert.ToInt32(HttpContext.Session.GetInt32("Marksman"));
            int medicine = Convert.ToInt32(HttpContext.Session.GetInt32("Medicine"));
            int science = Convert.ToInt32(HttpContext.Session.GetInt32("Science"));
            int subterfuge = Convert.ToInt32(HttpContext.Session.GetInt32("Subterfuge"));
            int survival = Convert.ToInt32(HttpContext.Session.GetInt32("Survival"));
            int technology = Convert.ToInt32(HttpContext.Session.GetInt32("Technology"));
            int transport = Convert.ToInt32(HttpContext.Session.GetInt32("Transport"));

            //*************************************************
            //Traits
            //*************************************************

            string CurrentTraitName = HttpContext.Session.GetString("CurrentTrait");
            @ViewBag.TraitName = CurrentTraitName;
            try{
                @ViewBag.TraitAllign = Traits.TraitsList[CurrentTraitName][0];
                @ViewBag.TraitVal = Traits.TraitsList[CurrentTraitName][1];
                @ViewBag.TraitDesc = Traits.TraitsList[CurrentTraitName][8];
                @ViewBag.TraitEffect = "<br><b>Effects: </b>"+Traits.TraitsList[CurrentTraitName][9];
            }
            catch{
                @ViewBag.TraitAllign = "";
                @ViewBag.TraitVal = "";
                @ViewBag.TraitDesc = "";            
                @ViewBag.TraitEffect = "";            
            }

            ViewBag.Traits = "";
            ViewBag.TraitSelectors = "";
            foreach(var trait in Traits.SortedTraits){
                ViewBag.TraitSelectors += "<option value='"+trait.Key+"'>"+trait.Key+"</option>";
                Console.WriteLine(trait.Key);
            }

            int traitPool = 0;
            foreach(var trait in Traits.PlayerTraits){
                int traitP = 0;
                ViewBag.Traits += "<li>"+trait.Key+"<form action ='traitDisplay' method = 'post'> <button action = 'submit' name = 'trait' value ='"+trait.Key+"'>View Details</button></form><form action ='traitRemove' method = 'post'><button action = 'submit' name = 'trait' value ='"+trait.Key+"'>Remove</button></form></li>";
                if(trait.Value[1] == "Minor"){
                    traitP = 1;
                }
                if(trait.Value[1] == "Major"){
                    traitP = 2;
                }
                if(trait.Value[0] == "Good"){
                    traitPool += traitP;
                }
                else{
                    traitPool -= traitP;
                }
            }
            ViewBag.TraitError = HttpContext.Session.GetString("TraitError");
            HttpContext.Session.SetString("TraitError", "");

            //Remove attribute and trait values from character points
            charP = 24 - Awareness - Coordination - Ingenuity - Presence - Resolve - Strength - traitPool;
            int skillPool = athletics + convince + craft + fighting + knowledge + marksman + medicine + science + subterfuge + survival + technology + transport;

            while(charP > 0 && skillPool > 0){
                charP -= 1;
                skillPool -= 1;
            }
            if(skillPool > 0){
                while(skillPool > 0){
                    skillP -= 1;
                    skillPool -= 1;
                }
            }
            //Total Points
            ViewBag.charP = charP;
            ViewBag.skillP = skillP;
            ViewBag.storyP = storyP; 

            //Stats
            ViewBag.Awareness = Awareness;
            ViewBag.Coordination = Coordination;
            ViewBag.Ingenuity = Ingenuity;
            ViewBag.Presence = Presence;
            ViewBag.Resolve = Resolve;
            ViewBag.Strength = Strength;

            //Skills
            ViewBag.athletics = athletics;
            ViewBag.convince = convince;
            ViewBag.craft = craft;
            ViewBag.fighting = fighting;
            ViewBag.knowledge = knowledge;
            ViewBag.marksman = marksman;
            ViewBag.medicine = medicine;
            ViewBag.science = science;
            ViewBag.subterfuge = subterfuge;
            ViewBag.survival = survival;
            ViewBag.technology = technology;
            ViewBag.transport = transport;

            return View();
        }

        [HttpPost]
        [Route("biodata")]
        public IActionResult Biodata(string nameInput, string goalInput, string personalityInput, string backgroundInput, string bioOptions){
            string name = HttpContext.Session.GetString("charName");
            string goal = HttpContext.Session.GetString("charGoal");
            string personality = HttpContext.Session.GetString("charPersonality");
            string background = HttpContext.Session.GetString("charBackground");
            string buttons = HttpContext.Session.GetString("charButtons");
            if(bioOptions == "edit"){
                name = "<input type = 'text' name = 'nameInput' value = '"+name+"'>";
                goal = "<br><input type = 'textarea' name = 'nameInput' value = '"+goal+"'>";
                personality = "<br><input type = 'textarea' name = 'nameInput' value = '"+personality+"'>";
                background = "<br><input type = 'textarea' name = 'nameInput' value = '"+background+"'>";
                buttons =  "<button action = 'submit' name = 'bioOptions' value = 'save'>Save</button>";
            }
            if(bioOptions == "save"){
                name = nameInput;
                goal = goalInput;
                personality = personalityInput;
                background = backgroundInput;
                buttons = "<button action = 'submit' name = 'bioOptions' value = 'edit'>Edit</button>";
            }
            HttpContext.Session.SetString("charName", name);
            HttpContext.Session.SetString("charGoal", goal);
            HttpContext.Session.SetString("charPersonality", personality);
            HttpContext.Session.SetString("charBackground", background);
            HttpContext.Session.SetString("charButtons", buttons);
            return RedirectToAction("Index");
        }

        //Save selected values to session upon submitting attributes
        [HttpPost]
        [Route("attributes")]
        public IActionResult Attributes(int Awareness, int Coordination, int Ingenuity, int Presence, int Resolve, int Strength){
            HttpContext.Session.SetInt32("Awareness", Awareness);
            HttpContext.Session.SetInt32("Coordination", Coordination);
            HttpContext.Session.SetInt32("Ingenuity", Ingenuity);
            HttpContext.Session.SetInt32("Presence", Presence);
            HttpContext.Session.SetInt32("Resolve", Resolve);
            HttpContext.Session.SetInt32("Strength", Strength);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("athletics")]
        public IActionResult Athletics(string athletics){
            int athleticsval = Convert.ToInt32(HttpContext.Session.GetInt32("Athletics"));
            if(athletics == "minus"){
                if(athleticsval > 0){
                    athleticsval -= 1;
                }
            }
            if(athletics == "plus"){
                athleticsval += 1;
            }
            HttpContext.Session.SetInt32("Athletics", athleticsval);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("convince")]
        public IActionResult Convince(string convince){
            int convinceval = Convert.ToInt32(HttpContext.Session.GetInt32("Convince"));
            if(convince == "minus"){
                if(convinceval > 0){
                    convinceval -= 1;
                }
            }
            if(convince == "plus"){
                convinceval += 1;
            }
            HttpContext.Session.SetInt32("Convince", convinceval);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("craft")]
        public IActionResult Craft(string craft){
            int craftval = Convert.ToInt32(HttpContext.Session.GetInt32("Craft"));
            if(craft == "minus"){
                if(craftval > 0){
                    craftval -= 1;
                }
            }
            if(craft == "plus"){
                craftval += 1;
            }
            HttpContext.Session.SetInt32("Craft", craftval);
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        [Route("fighting")]
        public IActionResult Fighting(string fighting){
            int fightingval = Convert.ToInt32(HttpContext.Session.GetInt32("Fighting"));
            if(fighting == "minus"){
                if(fightingval > 0){
                    fightingval -= 1;
                }
            }
            if(fighting == "plus"){
                fightingval += 1;
            }
            HttpContext.Session.SetInt32("Fighting", fightingval);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("knowledge")]
        public IActionResult Knowledge(string knowledge){
            int knowledgeval = Convert.ToInt32(HttpContext.Session.GetInt32("Knowledge"));
            if(knowledge == "minus"){
                if(knowledgeval > 0){
                    knowledgeval -= 1;
                }
            }
            if(knowledge == "plus"){
                knowledgeval += 1;
            }
            HttpContext.Session.SetInt32("Knowledge", knowledgeval);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("marksman")]
        public IActionResult Marksman(string marksman){
            int marksmanval = Convert.ToInt32(HttpContext.Session.GetInt32("Marksman"));
            if(marksman == "minus"){
                if(marksmanval > 0){
                    marksmanval -= 1;
                }
            }
            if(marksman == "plus"){
                marksmanval += 1;
            }
            HttpContext.Session.SetInt32("Marksman", marksmanval);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("medicine")]
        public IActionResult Medicine(string medicine){
            int medicineval = Convert.ToInt32(HttpContext.Session.GetInt32("Medicine"));
            if(medicine == "minus"){
                if(medicineval > 0){
                    medicineval -= 1;
                }
            }
            if(medicine == "plus"){
                medicineval += 1;
            }
            HttpContext.Session.SetInt32("Medicine", medicineval);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("science")]
        public IActionResult Science(string science){
            int scienceval = Convert.ToInt32(HttpContext.Session.GetInt32("Science"));
            if(science == "minus"){
                if(scienceval > 0){
                    scienceval -= 1;
                }
            }
            if(science == "plus"){
                scienceval += 1;
            }
            HttpContext.Session.SetInt32("Science", scienceval);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("subterfuge")]
        public IActionResult Subterfuge(string subterfuge){
            int subterfugeval = Convert.ToInt32(HttpContext.Session.GetInt32("Subterfuge"));
            if(subterfuge == "minus"){
                if(subterfugeval > 0){
                    subterfugeval -= 1;
                }
            }
            if(subterfuge == "plus"){
                subterfugeval += 1;
            }
            HttpContext.Session.SetInt32("Subterfuge", subterfugeval);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("survival")]
        public IActionResult Survival(string survival){
            int survivalval = Convert.ToInt32(HttpContext.Session.GetInt32("Survival"));
            if(survival == "minus"){
                if(survivalval > 0){
                    survivalval -= 1;
                }
            }
            if(survival == "plus"){
                survivalval += 1;
            }
            HttpContext.Session.SetInt32("Survival", survivalval);
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        [Route("technology")]
        public IActionResult Technology(string technology){
            int technologyval = Convert.ToInt32(HttpContext.Session.GetInt32("Technology"));
            if(technology == "minus"){
                if(technologyval > 0){
                    technologyval -= 1;
                }
            }
            if(technology == "plus"){
                technologyval += 1;
            }
            HttpContext.Session.SetInt32("Technology", technologyval);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("transport")]
        public IActionResult Transport(string transport){
            int transportval = Convert.ToInt32(HttpContext.Session.GetInt32("Transport"));
            if(transport == "minus"){
                if(transportval > 0){
                    transportval -= 1;
                }
            }
            if(transport == "plus"){
                transportval += 1;
            }
            HttpContext.Session.SetInt32("Transport", transportval);
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        [Route("traitSelect")]
        public IActionResult TraitSelect(string trait){
            HttpContext.Session.SetString("CurrentTrait", trait);
            return RedirectToAction("Index");
        }
        [HttpPost]
        [Route("traitDisplay")]
        public IActionResult TraitDisplay(string trait){
            TraitSelect(trait);
            return RedirectToAction("Index");
        }

        
        [HttpPost]
        [Route("traitAdd")]
        public IActionResult TraitAdd(){
            string TraitName = HttpContext.Session.GetString("CurrentTrait");
            try{
            Traits.PlayerTraits.Add(TraitName, new [] {Traits.TraitsList[TraitName][0],Traits.TraitsList[TraitName][1],Traits.TraitsList[TraitName][2],Traits.TraitsList[TraitName][3],Traits.TraitsList[TraitName][4]});
            }
            catch{
                string traitError = "Trait '"+TraitName+"' cannot be taken more than once";
                HttpContext.Session.SetString("TraitError", traitError);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("traitRemove")]
        public IActionResult TraitRemove(string trait){
            Traits.PlayerTraits.Remove(trait);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("traitSort")]
        public IActionResult TraitSort(string alignmentAll, string good, string bad, string valueAll, string minor, string major, string special, string sourceAll, string core, string coreAlien){
            Traits.SortedTraits.Clear();
            foreach(var trait in Traits.TraitsList){
                if(alignmentAll == "checked"){
                    if(valueAll == "checked"){
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}}
                    if(minor == "checked" && trait.Value[1] == "Minor"){
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}}
                    if(major == "checked" && trait.Value[1] == "Major"){
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}
                    if(special == "checked" && trait.Value[1] == "Special"){TraitAddToSorted(trait.Key);}
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}}
                }
                if(good == "checked" && trait.Value[0] == "Good"){
                   if(valueAll == "checked"){
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}}
                    if(minor == "checked" && trait.Value[1] == "Minor"){
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}}
                    if(major == "checked" && trait.Value[1] == "Major"){
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}
                    if(special == "checked" && trait.Value[1] == "Special"){TraitAddToSorted(trait.Key);}
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}} 
                }           
                if(bad == "checked" && trait.Value[0] == "Bad"){
                   if(valueAll == "checked"){
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}}
                    if(minor == "checked" && trait.Value[1] == "Minor"){
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}}
                    if(major == "checked" && trait.Value[1] == "Major"){
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}
                    if(special == "checked" && trait.Value[1] == "Special"){TraitAddToSorted(trait.Key);}
                        if(sourceAll == "checked"){TraitAddToSorted(trait.Key);}
                        if(core == "checked" && trait.Value[2] == "core book"){TraitAddToSorted(trait.Key);}
                        if(coreAlien == "checked" && trait.Value[2] == "core book (aliens)"){TraitAddToSorted(trait.Key);}}
                }              
            }
            return RedirectToAction("Index");
        }
        
        public void TraitAddToSorted(string Name){
            var trait = Traits.TraitsList[Name];
            Traits.SortedTraits.Add(Name, new[]{trait[0],trait[1],trait[2],trait[3],trait[4],trait[5],trait[6],trait[7],trait[8],trait[9]});
        }
        public void AwarenessConvert(int Awareness){
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
        }
        public void CoordinationConvert(int Coordination){
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
        }
        public void IngenuityConvert(int Ingenuity){
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
        }
        public void PresenceConvert(int Presence){
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
                ViewBag.PresenceButtons += " checked";
            } 
            ViewBag.PresenceButtons += "> 9 <br>";
        }
        public void ResolveConvert(int Resolve){
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
                ViewBag.ResolveButtons += " checked";
            } 
            ViewBag.ResolveButtons += "> 9 <br>";
        }
        public void StrengthConvert(int Strength){
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
        }
    }
}
