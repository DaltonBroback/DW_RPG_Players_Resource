using System.Collections.Generic;

namespace AiTaS.Controllers
{
    public class Traits 
    {
        public static Dictionary<string, string[]> PlayerTraits = new Dictionary<string, string[]>
        {
            
        };

        public static Dictionary<string, string[]> TraitsList = new Dictionary<string, string[]>
        {
            // Trait:
            //0: Good or Bad
            //1: Minor, Major, or Special
            //2: Location (ex. Core Book, Second Doctor Sourcebook, Aliens, etc)
            //3: Whether the trait can only be taken once or stacked
            //4: Description of trait
            //5: Effects

            //CORE BOOK TRAITS
            //Minor Traits (with a few exceptions)
            { "Animal Friendship", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "Some people just have a natural affinity for animals – creatures seem to like them for no apparent reason. Maybe they just smell friendly or give off the right signals, but animals are put at ease and may even go against their training to greet their new friend.",
                "When encountering an animal for the first time, the character may attempt to show it that they mean no harm and calm any aggressive tendencies. This trait gives them a +2 modifier to a Presence and Convince skill roll to calm an animal. With a Fantastic result, the animal, even a trained guard dog, may adopt the character as their new master!" } },

            { "Arrogant", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "While it doesn’t make them very easy to get along with, some individuals have a powerful confidence that allow them to deal with any situation.",
                "The character gains +2 to resisting fear and feelings of hopelessness, but suffer –1 to social interactions with those they consider to be inferior."} },

            { "Attractive", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "For every horrible beastie the Doctor encounters, there’s a pretty face. Of course, a lot of this is subjective, and can depend upon personal taste or even species! After all, Chantho was kinda pretty for a big bug lady, even to us humans, so imagine how pretty she would be to another of the Malmooth on Malcassairo. Having the Attractive trait means the character is attractive and pleasant on the eye.",
                "The Attractive trait comes into play whenever the character is doing something that their looks can influence. As a Good Trait, the character will get a +2 bonus to any rolls that involve their stunning Good looks, from charming their way past guards to getting information out of someone. Note: Cannot be taken with the Unattractive Bad trait." } },

            { "Biochemical Genius", new [] { 
                "Good", 
                "Major", 
                "core book",
                "one time",
                "Some people are a dab hand with chemistry and biology and have a natural ‘feel’ for the way the two combine.",
                "The character gains Areas of Expertise for the Science skill in Biology and Chemistry and may create biological or chemical ‘Gadgets’ using the Jiggery-Pokery rules, using the Science skill instead of Technology for all relevant rolls."} },

            { "Boffin", new [] { 
                "Good", 
                "Major", 
                "core book",
                "one time",
                "Boffin is a term that originated in WWII to describe those who constantly tinkered and experimented with equipment and technology to create futuristic devices. Having the Boffin trait means that you’re a genius when it comes to tweaking with electronics and machinery to cobble together the most useful gadgets and gizmos.",
                "This trait allows the character to create Gadgets through the fine art of ‘Jiggery-Pokery’. Your average Joe can try to open their household appliances and wire them together to try to make something – though they’ll probably only gain an electric shock or worse. Only a Boffin can create a useful device that can scan DNA, crack a safe or disable Dalek forcefields. More details on creating Gadgets can be found in the Jiggery-Pokery rules on pg. 113. Note: Cannot be taken with the Technically Inept Bad trait."} },

            { "Brave", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "Facing the invading monsters, bloodthirsty aliens and the many threats that companions encounter will mean that the characters are usually fairly courageous to even get involved. However, some people are more fearless, and can stare down a Sontaran in the face without flinching or shout at the Cybermen without worrying about the imminent reprisal.",
                "The Brave trait provides a +2 bonus to any Resolve roll when the character could get scared or need to show their courage. Note: Cannot be taken with the Cowardly Bad Trait, though individual Phobia Bad Traits can still be purchased."} },
                
            { "Charming", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "Robin Hood could probably charm his way through an entire adventure, just by smiling at the people he meets and carousing his way. Some people are naturally charming, and can make people swoon; very handy if you need to get people to do something for you, or to let you into a facility. The Charming trait reflects this additional seductive quality, and gives them an edge when trying to schmooze their way through any situation.",
                "Charming is a Minor Good Trait, and when the character is trying to charm their way through an encounter, they receive a +2 bonus to the roll. Useful for talking your way out of being killed, but not always suitable for every social situation."} },
 
            { "Empathic", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "People naturally hide their true emotions unless they are really upset or stressed, and it takes training or a natural gift to be able to read the tiny signals that give away what they’re really thinking or feeling. Some people have an empathy with how others are feeling and can use this gift to aid them when trying to get information or to calm someone down.",
                "Empathic is a Minor Good Trait that provides the character with a +2 bonus on any rolls when they are trying to empathise or read another person. This could be a simple Presence + Convince roll to reassure someone who’s panicking in the middle of a battle, or an Awareness + Ingenuity roll to try to read another’s actions and speech to see if they’re lying."} },
 
            { "Face in the Crowd", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "Some people can be unremarkable in manner or appearance, or are so comfortable in foreign places and with alien creatures that they can fade into the background and not be too noticeable. This means that despite wearing something that might not be authentic to the time period, you fit in and people seem to ignore your ‘alien-ness’.",
                "As long as they’re not dressing like a clown or anything too weird, and not doing anything that’ll attract their attention, people will leave the character to go about what they’re doing. If the Gamemaster asks for a roll to ‘blend in’, the trait provides a bonus of +2 to any Subterfuge skill roll when they’re trying to sneak about and not get noticed when in a crowd of people. Note: Cannot be taken with the Distinctive Bad Trait."} },
 
            { "Fast Healing (Major)", new [] { 
                "Good", 
                "Major", 
                "core book",
                "one time",
                "The ability to recover quickly from an injury is bound to be useful in your daily attempts to fend off alien invasion. Some people simply recover quicker than others, halting the bleeding and managing to carry on. Some very Special individuals can heal Major injuries, even regrowing limbs, within moments! This doesn’t make them immortal (they can still be killed if they receive too much damage) but if they survive, the injuries they sustain heal themselves at a remarkable rate.",
                "Fast Healing is either a Major Trait or a Special Trait, depending upon the speed of recovery. As a Major Good Trait, the character will heal any damage they have sustained quicker than a normal person. Any Attribute Points they have lost due to injury are regained at a rate of 1 point per hour, though the Gamemaster may decide that broken bones will take longer to heal. They might not be able to regrow lost limbs or compete in athletic events with a gunshot wound, but they’ll still be up on their feet faster than most. The player may still have to rationalise why the character can heal quickly with the Gamemaster before taking this trait. However, as a Special Good Trait, the Attribute Points lost are recovered at a rate of 1 point per minute! Bullet wounds heal over before your eyes and lost limbs are regrown. This is a very rare trait, though some creatures have been known to recover this quickly thanks to healing nanobots or a fast alien metabolism. They can still be killed as normal if three or more of their attributes are reduced to zero or lower, or if they are hit by a Lethal attack, but they will quickly recover from most damage that isn’t fatal. As a Special Trait, this costs 6 Character Points as well as 6 Story Points. Having a character recover this quickly is certainly not natural, and the reason for their ability should be discussed with the Gamemaster before players are allowed to purchase this trait."} },
 
            { "Fast Healing (Special)", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "The ability to recover quickly from an injury is bound to be useful in your daily attempts to fend off alien invasion. Some people simply recover quicker than others, halting the bleeding and managing to carry on. Some very Special individuals can heal Major injuries, even regrowing limbs, within moments! This doesn’t make them immortal (they can still be killed if they receive too much damage) but if they survive, the injuries they sustain heal themselves at a remarkable rate.",
                "Fast Healing is either a Major Trait or a Special Trait, depending upon the speed of recovery. As a Major Good Trait, the character will heal any damage they have sustained quicker than a normal person. Any Attribute Points they have lost due to injury are regained at a rate of 1 point per hour, though the Gamemaster may decide that broken bones will take longer to heal. They might not be able to regrow lost limbs or compete in athletic events with a gunshot wound, but they’ll still be up on their feet faster than most. The player may still have to rationalise why the character can heal quickly with the Gamemaster before taking this trait. However, as a Special Good Trait, the Attribute Points lost are recovered at a rate of 1 point per minute! Bullet wounds heal over before your eyes and lost limbs are regrown. This is a very rare trait, though some creatures have been known to recover this quickly thanks to healing nanobots or a fast alien metabolism. They can still be killed as normal if three or more of their attributes are reduced to zero or lower, or if they are hit by a Lethal attack, but they will quickly recover from most damage that isn’t fatal. As a Special Trait, this costs 6 Character Points as well as 6 Story Points. Having a character recover this quickly is certainly not natural, and the reason for their ability should be discussed with the Gamemaster before players are allowed to purchase this trait."} },
 
            { "Friends (Minor)", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "The character has people they can call upon for information or help. They may have reliable friends who can help them out (maybe they know someone who has some political pull or is well respected in the community), contacts within an institution (do they know someone who works in UNIT, Torchwood or even the White House?), or someone who can supply information (a shady guy who keeps finding out things that the public aren’t meant to know). Friends can be either a Minor or a Major Trait, depending upon how informative or helpful the friend in question is! The trait will not replace investigating something yourself. After all, where’s the fun if you get other people to do all the sneaking around and research for you? However, these friends are a great source of information on the background of a place or person that may otherwise take a while to uncover, while your character is busy doing something else. This can also be an excellent source of fresh and new adventures as the friend tips you off when something is happening.",
                "As a Minor Trait, they know someone who knows someone – a ‘friend of a friend’, but the source (and their information) is usually reliable. It may be that they know a friend who works in the local newspaper or council office who hears things as they’re reported and can steer the character in the direction of strange events. As a Major Trait, the person in the know is far more reliable, the information is accurate, or their contact may be leaking information from somewhere like UNIT or may even be someone of some power like Winston Churchill or the Queen of England! Their contact may be putting themselves at risk to get the information to the character, but it’s unlikely to be discovered. It should be noted that away from their home planet, unless their Friends are time and space travellers, this trait cannot be used where the friends cannot help them."} },
 
            { "Friends (Major)", new [] { 
                "Good", 
                "Major", 
                "core book",
                "one time",
                "The character has people they can call upon for information or help. They may have reliable friends who can help them out (maybe they know someone who has some political pull or is well respected in the community), contacts within an institution (do they know someone who works in UNIT, Torchwood or even the White House?), or someone who can supply information (a shady guy who keeps finding out things that the public aren’t meant to know). Friends can be either a Minor or a Major Trait, depending upon how informative or helpful the friend in question is! The trait will not replace investigating something yourself. After all, where’s the fun if you get other people to do all the sneaking around and research for you? However, these friends are a great source of information on the background of a place or person that may otherwise take a while to uncover, while your character is busy doing something else. This can also be an excellent source of fresh and new adventures as the friend tips you off when something is happening.",
                "As a Minor Trait, they know someone who knows someone – a ‘friend of a friend’, but the source (and their information) is usually reliable. It may be that they know a friend who works in the local newspaper or council office who hears things as they’re reported and can steer the character in the direction of strange events. As a Major Trait, the person in the know is far more reliable, the information is accurate, or their contact may be leaking information from somewhere like UNIT or may even be someone of some power like Winston Churchill or the Queen of England! Their contact may be putting themselves at risk to get the information to the character, but it’s unlikely to be discovered. It should be noted that away from their home planet, unless their Friends are time and space travellers, this trait cannot be used where the friends cannot help them."} },
 
            { "Hot Shot", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "Some people are a natural when it comes to most forms of transport. They can fly planes through the harshest of thunderstorms or drive cars at high speeds without crashing. They are the best of the best when it comes to piloting vehicles.",
                "Hot Shot is a Minor Good Trait providing the character with a +2 bonus to all Transport rolls. This bonus is eSpecially effective when used to push the speed of a vehicle, as they can get the best performance from the craft."} },
 
            { "Hypnosis (Minor)", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "The Doctor has been known to use a bit of hypnotism to calm a savage beast and to help people to remember things, putting them in a calm and relaxed state. Hypnosis as a Minor Good Trait means the character can put people into a mild hypnotic state. We’re not talking mind control here, just some basic hypnotic techniques – a tone of voice, a calm way of talking – that can calm people down and possibly influence them to do what you want. The Major Good Trait verges on mind control, and not the sort of thing a companion would do. The Special version of this trait allows complete possession, and is best left to the Master and other Villains.",
                "As a Minor Trait, Hypnosis adds a +2 bonus to any social interaction where you’re trying to either calm someone down or to get them to do what you’d like. It’s dependent upon the situation of course; the Gamemaster may not allow in the middle of a battlefield, for instance. Usually, there should be few distractions, and the target and the hypnotist should be able to hear and see each other, unless there is some advanced or alien technology involved. The target can resist using Ingenuity + Resolve (see ‘Being Possessed’, p.97). The Major Trait works the same way, but if the character succeeds in hypnotising the subject (using Presence + Convince), they can make them do anything not intrinsically against their nature (such as harm a friend or themselves) – in this case, the target can make another roll to resist (with a +3 bonus) to snap out of their hypnotic state, waking to wonder what they were doing. No matter what, they cannot be hypnotised into killing themselves – their survival instinct is too strong. The Special version of this trait costs 3 points and effectively allows the character to possess another person. This can be full-on mind control, or actually leaving their body to inhabit someone else’s. This level is reserved for alien or Special characters, not for normal player characters."} },
 
            { "Hypnosis (Special)", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "The Doctor has been known to use a bit of hypnotism to calm a savage beast and to help people to remember things, putting them in a calm and relaxed state. Hypnosis as a Minor Good Trait means the character can put people into a mild hypnotic state. We’re not talking mind control here, just some basic hypnotic techniques – a tone of voice, a calm way of talking – that can calm people down and possibly influence them to do what you want. The Major Good Trait verges on mind control, and not the sort of thing a companion would do. The Special version of this trait allows complete possession, and is best left to the Master and other Villains.",
                "As a Minor Trait, Hypnosis adds a +2 bonus to any social interaction where you’re trying to either calm someone down or to get them to do what you’d like. It’s dependent upon the situation of course; the Gamemaster may not allow in the middle of a battlefield, for instance. Usually, there should be few distractions, and the target and the hypnotist should be able to hear and see each other, unless there is some advanced or alien technology involved. The target can resist using Ingenuity + Resolve (see ‘Being Possessed’, p.97). The Major Trait works the same way, but if the character succeeds in hypnotising the subject (using Presence + Convince), they can make them do anything not intrinsically against their nature (such as harm a friend or themselves) – in this case, the target can make another roll to resist (with a +3 bonus) to snap out of their hypnotic state, waking to wonder what they were doing. No matter what, they cannot be hypnotised into killing themselves – their survival instinct is too strong. The Special version of this trait costs 3 points and effectively allows the character to possess another person. This can be full-on mind control, or actually leaving their body to inhabit someone else’s. This level is reserved for alien or Special characters, not for normal player characters."} },

            { "Indomitable", new [] { 
                "Good", 
                "Major", 
                "core book",
                "one time",
                "That’s the human race all round… indomitable. The character has determination and an iron will, meaning they are better at resisting mind control and hypnosis. They have something that grounds them, reassures them of who they are and protects their minds against invasion or hypnotic control.",
                "The Indomitable trait gives the character a +4 bonus to any rolls to resist becoming possessed, hypnotised, psychically controlled or similar. In many ways, this trait can also be used to avoid being dissuaded from their course of action – for example, River Song is usually determined to go off by herself despite the Doctor’s warnings. If the Doctor tried to convince her to stay, her Indomitable nature would help her to remain single-minded and determined to do as she wants, even if it isn’t the best idea in the world."} },
 
            { "Keen Senses (Minor)", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "The character is very aware of their surroundings. Whether they have a keen eye for detail and noticing when something is wrong, or a nose for a particular scent, they are particularly perceptive – always a Good thing when tracking or encountering alien intruders.",
                "As a Minor Trait you should specify which of the character’s senses is particularly keen. A +2 bonus only applies to Awareness rolls that use that sense, whether it is sight, hearing, smell, touch, taste or that elusive sixth sense. Only one sense can be chosen – more than one, and it’s a Major Trait. The Major Trait, a +2 bonus applies in any instance when using Awareness to notice or spot something, no matter what sense is being used. Note: Cannot be taken with the Impaired Senses Bad Trait in the same sense, although different ones can be taken. For example, you could have keen vision, but be hard of hearing. The Impaired Senses Bad trait should not be taken with the Keen Senses Major Trait, unless all of the character’s other senses are compensating for a single impaired sense."} },
 
            { "Keen Senses (Major)", new [] { 
                "Good", 
                "Major", 
                "core book",
                "one time",
                "The character is very aware of their surroundings. Whether they have a keen eye for detail and noticing when something is wrong, or a nose for a particular scent, they are particularly perceptive – always a Good thing when tracking or encountering alien intruders.",
                "As a Minor Trait you should specify which of the character’s senses is particularly keen. A +2 bonus only applies to Awareness rolls that use that sense, whether it is sight, hearing, smell, touch, taste or that elusive sixth sense. Only one sense can be chosen – more than one, and it’s a Major Trait. The Major Trait, a +2 bonus applies in any instance when using Awareness to notice or spot something, no matter what sense is being used. Note: Cannot be taken with the Impaired Senses Bad Trait in the same sense, although different ones can be taken. For example, you could have keen vision, but be hard of hearing. The Impaired Senses Bad trait should not be taken with the Keen Senses Major Trait, unless all of the character’s other senses are compensating for a single impaired sense."} },
 
            { "Lucky", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "Lady Luck is on their side. Call it a fluke, call it chance, but fortune is smiling on the character. The traffic lights changed just at the right moment to give them a chance to get through, they just managed to roll under the blast doors before they closed and they flicked the right switch to restart the ship’s engines. Every day is their lucky day!",
                "The character is lucky! Simple as that. If you roll two ‘1’s on your dice – ‘snake-eyes’ as they call ’em in Vegas – you’re probably going to fail. At least normally. Characters with the Lucky trait get a second chance when double ‘1’s are rolled, and you can reroll both dice, trying for something better. If you get double ‘1’s again, well, your luck obviously doesn’t run that far, and you must keep the second result."} },
 
            { "Military Rank (Minor)", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "stackable",
                "The character has a military rank, with all the privileges and responsibilities that entails. If they belong to UNIT but do not have this trait they are considered to be regular enlisted soldiers (Privates or Corporals).",
                "As a Minor Trait, the character is a Sergeant. As a Major Trait, they are a Lieutenant. With the permission of the Gamemaster, a player may begin higher than a Lieutenant, with Good back story justification and by purchasing the trait additional times. The table below summarises ranks. The Special version of this trait also gives the Friends (Government and Military) trait to represent the officer’s political and military connections."} },
 
            { "Military Rank (Major)", new [] { 
                "Good", 
                "Major", 
                "core book",
                "stackable",
                "The character has a military rank, with all the privileges and responsibilities that entails. If they belong to UNIT but do not have this trait they are considered to be regular enlisted soldiers (Privates or Corporals).",
                "As a Minor Trait, the character is a Sergeant. As a Major Trait, they are a Lieutenant. With the permission of the Gamemaster, a player may begin higher than a Lieutenant, with Good back story justification and by purchasing the trait additional times. The table below summarises ranks. The Special version of this trait also gives the Friends (Government and Military) trait to represent the officer’s political and military connections."} },
 
            { "Military Rank (Special)", new [] { 
                "Good", 
                "Special", 
                "core book",
                "stackable",
                "The character has a military rank, with all the privileges and responsibilities that entails. If they belong to UNIT but do not have this trait they are considered to be regular enlisted soldiers (Privates or Corporals).",
                "As a Minor Trait, the character is a Sergeant. As a Major Trait, they are a Lieutenant. With the permission of the Gamemaster, a player may begin higher than a Lieutenant, with Good back story justification and by purchasing the trait additional times. The table below summarises ranks. The Special version of this trait also gives the Friends (Government and Military) trait to represent the officer’s political and military connections."} },
 
            { "Noble", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "Some people are born into the highest levels of society and are used to entertaining dignitaries, ambassadors and even kings and queens.",
                "The character’s experience gives them a +2 bonus whenever they deal socially with the cream of society, eSpecially when you are in a formal environment."} },

            { "Owed Favour (Minor)", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "stackable",
                "Someone out there owes the character a favour. It can be anything from a sum of money, repayment for introducing them to their future wife or even saving their life. Whatever it was, they’re not going to forget it, and in the character’s moment of need they can be called upon to help out in a dire situation.",
                "As a Minor Trait, the favour is something relatively small – a small amount of money (only £1000 or so), introducing someone to them at a party who later became a valuable business client or romantic partner, or you bailed them out when they were in trouble. As a Major Trait, the favour is more important, from a large amount of money (over £10,000) to saving their life. If appropriate, you may opt to call in the favour and seek assistance in the current adventure. Of course, if you ask for a favour bigger than the original debt, they may walk off afterwards saying “we’re quits, don’t call on me again”, or you could even end up owing them a favour, and gain the Owes Favour Bad Trait (see pg. 46)."} },
 
            { "Owed Favour (Major)", new [] { 
                "Good", 
                "Major", 
                "core book",
                "stackable",
                "Someone out there owes the character a favour. It can be anything from a sum of money, repayment for introducing them to their future wife or even saving their life. Whatever it was, they’re not going to forget it, and in the character’s moment of need they can be called upon to help out in a dire situation.",
                "As a Minor Trait, the favour is something relatively small – a small amount of money (only £1000 or so), introducing someone to them at a party who later became a valuable business client or romantic partner, or you bailed them out when they were in trouble. As a Major Trait, the favour is more important, from a large amount of money (over £10,000) to saving their life. If appropriate, you may opt to call in the favour and seek assistance in the current adventure. Of course, if you ask for a favour bigger than the original debt, they may walk off afterwards saying “we’re quits, don’t call on me again”, or you could even end up owing them a favour, and gain the Owes Favour Bad Trait (see pg. 46)."} },
 
            { "Percussive Maintenance", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "There are some people (mad scientists, leather jacketed greasers from the 1950s, etc.) who have a rather peculiar innate understanding of machines that allows them to activate malfunctioning machinery with a single well placed blow to the appropriate area.",
                "Whenever the character fails a roll to repair some sort of technology, they may immediately whack it with their fist or some other object and may roll again, replacing Ingenuity with Strength. They may only attempt this once per repair. In addition, if they don’t have time to make a proper repair, they may use Percussive Maintenance to get a piece of technology temporarily working by making a Strength + Technology roll. On a Success, the tech will work for one use, on a Good Success, it will work for D6 uses, and on a Fantastic Success it will continue to function until the Gamemaster decides otherwise."} },
 
            { "Photographic Memory", new [] { 
                "Good", 
                "Major", 
                "core book",
                "one time",
                "With just a few seconds of concentration, the character can commit something to memory to be instantly recalled when needed. People with this trait rarely have problems passing exams, and can remember exact lines from books.",
                "The Photographic Memory trait can be used in a couple of different ways. If the character knows they’re going to have to remember something at a later time, such as the combination to a lock or the instructions to program a computer, they can spend a moment to take the information in and commit it to memory. If they want to recall the information, they can without having to roll, but they must have declared that they’ve taken the time to concentrate and remember it at the time. Similarly, if they want to remember something that they haven’t actively committed to memory, there’s a chance it may be stored in there somewhere along with last week’s shopping list or what time that film is on they wanted to watch. To recall something vital that they may have only glanced at or possibly missed altogether, you can spend a Story Point. Note: Cannot be taken with the Forgetful Bad Trait."} },
 
            { "Psychic Training", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "Don’t you just hate it when you wave your Psychic Paper at someone and they don’t see anything? Psychic Training means they are able to protect themselves from mental coercion or deception and are aware of psychic attack or memory alteration. They can put up basic defences to protect themselves, which can be as simple as imagining a plain white wall to repeating a Beatles tune in their head.",
                "This Minor Trait gives the character a +2 bonus to Resolve rolls when trying to resist psychic attack or deception. It doesn’t always work, but it is strong enough to resist a low level telepathic field such as that of Psychic Paper."} },
 
            { "Quick Reflexes", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "The character is fast to act when things happen, reacting to situations almost instinctively. It doesn’t mean they cannot be surprised – if they don’t know something’s coming they can’t react to it – but when something attacks or Bad happens, they’re often the first to react to it.",
                "In a conflict situation, when they haven’t been taken completely by surprise, the character is assumed to always go first when acting at the same time as others. They won’t always go first in a round, but if two or more people are acting in a single phase (such as Talkers, Runners, etc.), the person with Quick Reflexes goes first. If more than one person in a phase has the Quick Reflexes trait, the character with the higher relative attribute goes first. For more information on Conflicts, Actions and Rounds, see pg. 80. Note: Cannot be taken with the Slow Reflexes Bad Trait."} },

            { "Resourceful Pockets", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "The Doctor has said that he has pockets like the TARDIS, and he does seem to carry some strange things around in them. Sometimes people just have that knack of accumulating things – nothing terribly important or bulky, but little things that can be useful when you have to MacGyver something together at a time of peril. If you have the Resourceful Pockets trait there’s a chance, albeit a slim one, that you may have something useful in them that could get you out of a sticky situation. Remember, Resourceful Pockets doesn’t have to mean ‘pockets’ – you could have an excellent utility belt, and who knows what can be found in a handbag.",
                "The player can either spend a Story Point and find the thing they need, or roll a couple of dice. If they get a ‘double’, for example rolling two ‘1’s or two ‘3’s, then they find something helpful in their pocket, from a cricket ball to a clockwork mouse. Of course it may not be exactly what you were expecting, but it may still be useful in some way."} },
 
            { "Reverse The Polarity of the Neutron Flow", new [] { 
                "Good", 
                "Major", 
                "core book",
                "one time",
                "Those with a particular genius for science have an innate understanding of the ebb and flow of energy and can make intuitive leaps that allow them to solve scientific and technological problems through unusual applications of that energy.",
                "This trait may be used once per adventure. After the character has failed a roll using the Science or Technology skill, the player may declare they are “Reversing the polarity of the neutron flow” and turn the result into an automatic Fantastic Success."} },

            { "Run for your Life!", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "There are many times when the opposing forces are too numerous or just too powerful to take down. The best thing you can do is to flee, run for your life and regroup to plan a new angle of attack. The character with this trait has obviously got this running thing down to a fine art and when danger is close behind there is that extra motivation to simply scarper!",
                "The character is better at running away from danger, usually due to all the practice they’ve had! When being chased (see pg. 98), you receive a +1 bonus to your Speed when fleeing."} },
 
            { "Screamer!", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "The character has been known to scream in the face of terror on many occasion, and this ear-splitting sound will penetrate miles of corridor to alert others to their location and the imminent threat.",
                "At times when they are scared or threatened, the character can scream their lungs out. No roll is necessary, though using this trait will cost a Story Point. Anything or anyone else in the room will be stunned and will be unable to act for their next action. The Screamer should take their next action running away while the enemy is stunned – they are rarely brave enough to do anything else. The scream also alerts their companions, and the rest of the group will automatically know the direction they are in. Note: Screamers usually gain this trait from being easily scared. The Screamer trait cannot be taken with Brave and the character will never receive any bonuses when trying resist getting scared (see ‘Getting Scared’ on pg. 94)."} },
 
            { "Sense of Direction", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "There are some people who instinctively know the easiest way to get from one place to the next. It may be a labyrinthine maze of streets and identical houses, but characters with the Sense of Direction trait rarely seem to get lost, or can usually find their bearings if they do.",
                "This trait gives the character a +2 bonus to any roll (usually Awareness and Ingenuity) to regain their direction when lost, or to simply work out how to get from A to B. This can be map reading, running through a miles of similar corridors, or simply knowing which way is up while spinning in zero gravity."} },
 
            { "Technically Adept", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "The character has an innate connection to technology, and can sometimes fix things just by hitting them! They’re skilled enough to operate and repair most things with limited tools, taking half the time it normally takes. Often, if the device stopped working within thirty minutes, it can be restarted just by thumping it. It may not last long, but long enough…",
                "The Technically Adept trait provides the character with +2 to any Technology roll to fix a broken or faulty device, and to use complex gadgets or equipment. The bonus also applies to any gadgetcreating jiggery-pokery, and can be combined with the Boffin trait. Note: Cannot be taken with the Technically Inept Bad Trait."} },

 
            { "Time Traveller (Minor)", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "stackable",
                "The character is experienced with the technology and society of time periods different to their own. The Time Traveller trait also reflects how much travelling in time the character has done, and can be used as a rough indicator of how much background Artron Radiation they have picked up from travelling the Vortex. While this isn’t actually harmful, some alien races have been known to target individuals that have high Artron levels to fuel or activate their technology.",
                "Players define the character’s home Technology Level (see pg. 66), and using technology from outside of the character’s experience may impose penalties as they’re unfamiliar with the way it works. The Time Traveller trait means that they’re used to some time periods and can operate the technology with little or no penalty. The character automatically has a familiarity with their home Tech Level, but the Time Traveller trait records additional Tech Levels levels they’re comfortable with. Lower Technology Levels to their home are Minor Good Traits, whereas more advanced Technology Levels are Major Good Traits. Technology Levels do not come into play all of the time – after all a gun is a gun and a socket wrench is a socket wrench, but there are times when technology is so advanced or primitive that your character may feel out of place or unable to recognise the technology for what it is. More information on interacting with technology out of the character’s experience can be found on pg. 110. This trait can be purchased more than once, and the Gamemaster may award this trait during play if the character becomes particularly familiar with a certain Tech Level."} },

            { "Time Traveller (Major)", new [] { 
                "Good", 
                "Major", 
                "core book",
                "stackable",
                "The character is experienced with the technology and society of time periods different to their own. The Time Traveller trait also reflects how much travelling in time the character has done, and can be used as a rough indicator of how much background Artron Radiation they have picked up from travelling the Vortex. While this isn’t actually harmful, some alien races have been known to target individuals that have high Artron levels to fuel or activate their technology.",
                "Players define the character’s home Technology Level (see pg. 66), and using technology from outside of the character’s experience may impose penalties as they’re unfamiliar with the way it works. The Time Traveller trait means that they’re used to some time periods and can operate the technology with little or no penalty. The character automatically has a familiarity with their home Tech Level, but the Time Traveller trait records additional Tech Levels levels they’re comfortable with. Lower Technology Levels to their home are Minor Good Traits, whereas more advanced Technology Levels are Major Good Traits. Technology Levels do not come into play all of the time – after all a gun is a gun and a socket wrench is a socket wrench, but there are times when technology is so advanced or primitive that your character may feel out of place or unable to recognise the technology for what it is. More information on interacting with technology out of the character’s experience can be found on pg. 110. This trait can be purchased more than once, and the Gamemaster may award this trait during play if the character becomes particularly familiar with a certain Tech Level."} },
 
            { "Tough", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "Not everyone can take a punch on the nose and brush it off as if nothing had happened. Few people can take getting shot or starved, tortured or wounded in the course of their everyday lives. However, people with the Tough trait are used to the adventure, can take the knocks and brush them off.",
                "Tough reduces the amount of damage that would normally be deducted from the character’s attributes by 2. This is after any other effects, such as armour, are taken into account. For example, Danny Pink had to face many hostiles when he was a soldier, which has made him more resilient. He fails during a Conflict with a Dalek, but not Badly enough to kill him. He’d normally be told to knock 4 points off one or more of his attributes to reflect his injury, but his Tough trait reduces the damage by 2. Now he only has to take 2 points off his attributes. A wound all the same, but not as Bad as it could have been."} },
 
 
            { "Voice of Authority", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "The character has the air of command about them, possibly from being a figure of authority – a doctor, politician, military commander or a police constable – or they may have an aura of intelligence or experience that inspires people to listen and trust their judgement. This is eSpecially handy when trying to clear an area because of some approaching danger, to order people about or simply try to gain their trust.",
                "This trait provides a +2 bonus to Presence and Convince rolls to try to get people to do as you wish or to gain their trust. The Gamemaster may modify this to suit the situation."} },

            //Major Traits (with a few exceptions)
            { "Adversary (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "stackable",
                "The Doctor has made many enemies in his travels, but a few of them recur enough to warrant a whole trait to themselves. The Adversary trait means that the character has made an enemy in the past who is actively trying to hinder them whenever possible. The key word here is ‘actively’. For example, the Daleks have gone to great lengths to battle the Doctor, chasing him through time and space, laying traps, and even luring him to WWII London to trick him into aiding the rebirth of their race.",
                "Adversary can be a Minor or a Major Bad Trait depending upon the power and frequency of the Adversary’s appearance. For example, the Doctor scuppered the plans of Fenric and the Haemovores, but they haven’t resurfaced. If another colony of the Haemovores heard of the fate of their Northumbrian counterparts and decided to try to track down the Doctor for revenge, they’d count as a Minor Adversary Trait. They’re not too powerful, unlikely to appear in every campaign, but may appear as recurring villains. A fairly powerful Villain that makes an appearance every campaign such as the Daleks would count as a Major Adversary. They just keep surviving and coming back again and again, and consider the Doctor their greatest enemy."} },
 
            { "Adversary (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "stackable",
                "The Doctor has made many enemies in his travels, but a few of them recur enough to warrant a whole trait to themselves. The Adversary trait means that the character has made an enemy in the past who is actively trying to hinder them whenever possible. The key word here is ‘actively’. For example, the Daleks have gone to great lengths to battle the Doctor, chasing him through time and space, laying traps, and even luring him to WWII London to trick him into aiding the rebirth of their race.",
                "Adversary can be a Minor or a Major Bad Trait depending upon the power and frequency of the Adversary’s appearance. For example, the Doctor scuppered the plans of Fenric and the Haemovores, but they haven’t resurfaced. If another colony of the Haemovores heard of the fate of their Northumbrian counterparts and decided to try to track down the Doctor for revenge, they’d count as a Minor Adversary Trait. They’re not too powerful, unlikely to appear in every campaign, but may appear as recurring villains. A fairly powerful Villain that makes an appearance every campaign such as the Daleks would count as a Major Adversary. They just keep surviving and coming back again and again, and consider the Doctor their greatest enemy."} },
 
            { "Amnesia (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "Memory is a fragile thing that can easily be manipulated or lost entirely. The Amnesia trait means that some or even all of the character’s memories are missing and they have ‘holes’ in their past. These memories may return in time, with the right triggers, but for the time being there are periods in their past that they know nothing about. This could be deliberate, the result of mind-wiping technology, psychic powers or Torchwood’s amnesia drug Retcon, or due to mental or physical damage.",
                "As a Minor Bad Trait, the character has lost a portion of their memory. It could be as small as a couple of days, weeks or even a couple of years, but the character will have no idea of what happened to them in that time. As a Major Bad Trait, this Amnesia is total, the character having no memory of their past, or even who they really are. Events, sights, sounds or even smells can trigger memories of their lost time, and this is a great source of adventure ideas for the Gamemaster – over many adventures the character can uncover more and more of their ‘lost time’. Of course, this adds to the work the Gamemaster has to do, coming up with the character’s lost memories, so the Amnesia trait should be approved by the Gamemaster before purchasing it."} },

            { "Amnesia (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "one time",
                "Memory is a fragile thing that can easily be manipulated or lost entirely. The Amnesia trait means that some or even all of the character’s memories are missing and they have ‘holes’ in their past. These memories may return in time, with the right triggers, but for the time being there are periods in their past that they know nothing about. This could be deliberate, the result of mind-wiping technology, psychic powers or Torchwood’s amnesia drug Retcon, or due to mental or physical damage.",
                "As a Minor Bad Trait, the character has lost a portion of their memory. It could be as small as a couple of days, weeks or even a couple of years, but the character will have no idea of what happened to them in that time. As a Major Bad Trait, this Amnesia is total, the character having no memory of their past, or even who they really are. Events, sights, sounds or even smells can trigger memories of their lost time, and this is a great source of adventure ideas for the Gamemaster – over many adventures the character can uncover more and more of their ‘lost time’. Of course, this adds to the work the Gamemaster has to do, coming up with the character’s lost memories, so the Amnesia trait should be approved by the Gamemaster before purchasing it."} },
 
            { "Argumentative", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "Some people just think they’re right all the time, even when they’re not. Some even provoke an argument just for arguing’s sake. Characters with the Argumentative trait are like this and will argue their point of view even if it is with their teammates or with the leader of an invading alien fleet. However, they don’t start arguments all the time – that would make the character impossible to be around, but when someone contradicts their opinion or knowledge, they will actively try to correct them.",
                "Argumentative is a Minor Trait, so it shouldn’t get in the way too much of their normal behaviour. However, they will find it difficult to hold their tongue when their opinion or knowledge is contradicted. If this situation arises, the Gamemaster will reward ‘playing in character’ with Story Points. If the argument may end in a fight, the character may try to back down for their own safety, but the player will have to make an Ingenuity and Resolve roll, with a -2 modifier, to try to hold their tongue."} },
 
            { "By the Book", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "I’m sorry, I can’t let you do that. Protocol clearly states that you must follow the correct procedure when you are opening a dialogue with a potentially hostile species. I really shouldn’t let you do that at all. Look, if you want to go that way and ignore the signs, then be my guest. I, however, will be following the arrows to the nearest escape hatch while putting on my lifejacket.",
                "The character will follow instructions, advice or correct procedure to the letter without deviating.  Soldiers with intensive military training often have this trait, following the orders of the commanding officer without question. It doesn’t mean the character is a mindless drone, but it does mean that it may take some serious convincing to get them to go against their training or orders. If someone tries to convince them otherwise, they will usually make an Ingenuity and Resolve roll, and the trait gives them a +2 bonus to the roll. This is a bonus, despite it being a Bad Trait, as most of the time failing to show initiative and going against orders will result in putting themselves in danger or annoying their teammates. The bonus does, however, also apply when trying to resist Hypnosis or Possession if the mental control is trying to get them to do something they’d normally refuse to do."} },
 
            { "Clumsy", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "It seems as if the character is unable to keep hold   of things, keeps tripping over the smallest hazard, and shouldn’t be trusted with that pocket universe suspended in a glass chamber.",
                "Clumsy is a Minor Bad Trait, but it doesn’t mean the character will pratfall every five minutes. It does mean that in times of stress, eSpecially when being chased, the player will have to make additional Awareness and Coordination rolls to avoid knocking vital things over, dropping the vial of toxic chemicals or tripping up and landing on their face."} },
 
            { "Code of Conduct (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "The Code of Conduct trait means that the character adheres to a strict moral standing or self-imposed set of rules they follow at all times. Depending upon whether it’s a Minor or Major rait, this can be purely guidelines or a deep-seated way of life. The Doctor has a strict Major Code of Conduct, as he believes all life is precious and would even offer his hand of forgiveness and help to a Dalek or Missy. While this is listed as a Bad Trait, it doesn’t mean that having a code is Bad; just that it can restrict your actions and limit your choices. Being Good is often the harder option, but it means you’re a better person for it.",
                "As a Minor Trait, Code of Conduct means that the character should try to do Good at most times, and are unable to harm another being unless it is absolutely necessary and for the greater Good. As a Major Trait, their limits their actions dramatically, meaning they need to strive to do their best at every moment, almost verging on the saintly! Discuss the character’s own unique Code of Conduct with the Gamemaster when you take this trait. Breaking it may be very costly, resulting in the loss of Story Points!"} },
 
            { "Code of Conduct (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "one time",
                "The Code of Conduct trait means that the character adheres to a strict moral standing or self-imposed set of rules they follow at all times. Depending upon whether it’s a Minor or Major rait, this can be purely guidelines or a deep-seated way of life. The Doctor has a strict Major Code of Conduct, as he believes all life is precious and would even offer his hand of forgiveness and help to a Dalek or Missy. While this is listed as a Bad Trait, it doesn’t mean that having a code is Bad; just that it can restrict your actions and limit your choices. Being Good is often the harder option, but it means you’re a better person for it.",
                "As a Minor Trait, Code of Conduct means that the character should try to do Good at most times, and are unable to harm another being unless it is absolutely necessary and for the greater Good. As a Major Trait, their limits their actions dramatically, meaning they need to strive to do their best at every moment, almost verging on the saintly! Discuss the character’s own unique Code of Conduct with the Gamemaster when you take this trait. Breaking it may be very costly, resulting in the loss of Story Points!"} },
 
            { "Cowardly", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "Facing those monsters, some people become nervous wrecks rather than becoming hardened to it. Cowardly is a Bad Trait reflecting the character’s lack of natural courage, and means they will usually avoid dangerous situations unless it means that staying where they are is even more life-threatening!",
                "The Cowardly Trait reduces the character’s chance to resist getting scared, suffering a -2 penalty to any roll when they need to resist running away screaming! (See “Getting Scared” on pg. 94). Note: Cannot be taken with the Brave Good Trait."} },
 
            { "Dark Secret (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "The character has a skeleton in the closet and if it’s revealed it could change the way people think about them. It could be something mundane, such as a criminal record that they’re trying to gloss over after turning their back on a life of crime. Or it could be something more extreme, that the character is actually an alien (though the Alien trait should be taken as well, see pg. 49) or the result of some strange genetic experiments conducted by the US Government. It’s probably best to discuss with the Gamemaster what the Dark Secret actually is possibly before creating the character with your friends, just so you really do have a secret to keep from the other players.",
                "Dark Secret can be either a Minor or a Major Bad Trait, depending upon the severity of the reaction should the secret be revealed. Something that would change the way people think about you is a Minor Trait. For example, having a criminal record would usually be a Minor Trait. If people found out about it, they might not like you any more, or certainly act more cautiously around you. If a more hostile reaction would result, not necessarily from your companions but certainly from others, it would be a Major Trait – for example, being an escaped criminal like River Song has been during any of her encounters with the Doctor. If people discovered the secret the character could be arrested and imprisoned again, or shot at by law enforcement agents. Your companions may be sympathetic, knowing you’ve changed your ways, but it doesn’t stop the Judoon or the local police from hunting you once you’ve been discovered. Remember, for it to warrant being a Major Bad Trait, the secret should still have some ramifications even away from your home planet."} },

            { "Dark Secret (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "one time",
                "The character has a skeleton in the closet and if it’s revealed it could change the way people think about them. It could be something mundane, such as a criminal record that they’re trying to gloss over after turning their back on a life of crime. Or it could be something more extreme, that the character is actually an alien (though the Alien trait should be taken as well, see pg. 49) or the result of some strange genetic experiments conducted by the US Government. It’s probably best to discuss with the Gamemaster what the Dark Secret actually is possibly before creating the character with your friends, just so you really do have a secret to keep from the other players.",
                "Dark Secret can be either a Minor or a Major Bad Trait, depending upon the severity of the reaction should the secret be revealed. Something that would change the way people think about you is a Minor Trait. For example, having a criminal record would usually be a Minor Trait. If people found out about it, they might not like you any more, or certainly act more cautiously around you. If a more hostile reaction would result, not necessarily from your companions but certainly from others, it would be a Major Trait – for example, being an escaped criminal like River Song has been during any of her encounters with the Doctor. If people discovered the secret the character could be arrested and imprisoned again, or shot at by law enforcement agents. Your companions may be sympathetic, knowing you’ve changed your ways, but it doesn’t stop the Judoon or the local police from hunting you once you’ve been discovered. Remember, for it to warrant being a Major Bad Trait, the secret should still have some ramifications even away from your home planet."} },

            { "Dependency (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "Sometimes you just rely on others. It could be said that the Doctor’s companions are all dependent upon him, but there have been many times when they’ve shown that they are easily his equals, so they’re far from dependent. Having the Dependency trait means they are dependent upon something or someone to survive. Maybe this is blood like a Plasmavore or the support of others, like Lady Cassandra. The level of the trait determines how desperate they will get, and how Bad the effects will be, if they can’t get their fix. Players should be careful not to take such a high Dependency that their character becomes too difficult to play.",
                "As a Minor Bad Trait, they can go for extended periods without their dependency getting in the way. If the Gamemaster decides their need is urgent, the character may suffer a -2 penalty to their actions until they fulfil their need. As a Major Trait, they are unable to survive without their dependency. It could be that they need something to survive like blood or moisture. If they go without it for any period of time (defined by the Gamemaster and the player) they suffer a -4 penalty to every action. This could be because they’re unable to think of anything else, or because they’re unable to act properly without help."} },

            { "Dependency (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "one time",
                "Sometimes you just rely on others. It could be said that the Doctor’s companions are all dependent upon him, but there have been many times when they’ve shown that they are easily his equals, so they’re far from dependent. Having the Dependency trait means they are dependent upon something or someone to survive. Maybe this is blood like a Plasmavore or the support of others, like Lady Cassandra. The level of the trait determines how desperate they will get, and how Bad the effects will be, if they can’t get their fix. Players should be careful not to take such a high Dependency that their character becomes too difficult to play.",
                "As a Minor Bad Trait, they can go for extended periods without their dependency getting in the way. If the Gamemaster decides their need is urgent, the character may suffer a -2 penalty to their actions until they fulfil their need. As a Major Trait, they are unable to survive without their dependency. It could be that they need something to survive like blood or moisture. If they go without it for any period of time (defined by the Gamemaster and the player) they suffer a -4 penalty to every action. This could be because they’re unable to think of anything else, or because they’re unable to act properly without help."} },

            { "Distinctive", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "There is something very striking or obvious about your character that makes them stand out in the crowd. Whether they are just tall, short, have coloured hair or are striking in the way they dress or act, they get noticed and people seem to remember them. They’re not going to provoke people pointing and staring, but they’ll certainly be remembered and recognised if encountered again. This doesn’t mean ‘Alien’ in appearance – for example, if Bannakaffalatta walked around on modern Earth he’d provoke a far more extreme reaction than the Distinctive trait; he’d have the Alien Appearance Trait (see pg. 49).",
                "Effect: This trait works in a couple of ways. If the character is trying to ‘blend in’ or go unnoticed in a crowd, they suffer a -2 penalty to the roll. Also, Chapter Two: Old-Fashioned Heroes from Ol d-Fashioned Story Books if they’re seen doing something, or if another character or NPC is asked to describe or remember the distinctive character, they will receive a +2 bonus to remember or recognise them after their initial encounter. Note: Cannot be taken with the Face in the Crowd trait."} },

            { "Eccentric (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "Some people behave rather oddly. The Doctor acts in ways that baffles his companions and throws his opponents off their game, switching from excited schoolboy to dark and imposing in a moment. The Eccentric trait means the character has a behaviour that makes them stand out, or sometimes makes it more difficult when interacting with others. As a Minor Bad trait, their behaviour isn’t too upsetting. It could be an odd mannerism during times of stress, out-of-place reactions to everyday events, or even talking to themselves. The Major Bad Trait, is probably too unpredictable to be purchased by a player character. We’re getting into seriously wacky territory, sometimes a little dangerous to be around. Missy is a prime example of someone with the Major Eccentric Trait, straying into unpredictable behaviour with little provocation. But just because the character has a Major Eccentric Trait, it doesn’t mean they’re homicidal (except it does in Missy’s case, of course).",
                "The specifics of the character’s Eccentric trait should be discussed with the Gamemaster at character creation. Just how does this behaviour manifest? Are they aloof, a loner, irrational, tangential, a natural clown, a sour-puss? Once their odd behaviour is defined, the Gamemaster will help to decide how this behaviour is triggered. Is it when they’re stressed, cross, happy, jealous, or tired? It is then down to the player to act in character when the situation arises, which will gain them Story Points for Good roleplaying."} },

            { "Eccentric (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "one time",
                "Some people behave rather oddly. The Doctor acts in ways that baffles his companions and throws his opponents off their game, switching from excited schoolboy to dark and imposing in a moment. The Eccentric trait means the character has a behaviour that makes them stand out, or sometimes makes it more difficult when interacting with others. As a Minor Bad trait, their behaviour isn’t too upsetting. It could be an odd mannerism during times of stress, out-of-place reactions to everyday events, or even talking to themselves. The Major Bad Trait, is probably too unpredictable to be purchased by a player character. We’re getting into seriously wacky territory, sometimes a little dangerous to be around. Missy is a prime example of someone with the Major Eccentric Trait, straying into unpredictable behaviour with little provocation. But just because the character has a Major Eccentric Trait, it doesn’t mean they’re homicidal (except it does in Missy’s case, of course).",
                "The specifics of the character’s Eccentric trait should be discussed with the Gamemaster at character creation. Just how does this behaviour manifest? Are they aloof, a loner, irrational, tangential, a natural clown, a sour-puss? Once their odd behaviour is defined, the Gamemaster will help to decide how this behaviour is triggered. Is it when they’re stressed, cross, happy, jealous, or tired? It is then down to the player to act in character when the situation arises, which will gain them Story Points for Good roleplaying."} },
                
            { "Forgetful", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "The character’s memory is less than reliable. It usually isn’t too drastic if they don’t remember everything on the shopping list when they’re standing in the supermarket, but if they’ve got to they’re which wire to cut to stop a bomb, or the precise words to use to halt a curse, there’s a Good chance you’re going to forget and cause a disaster.",
                "When the character needs to remember something vital, an Ingenuity + Resolve roll is required with a -2 penalty. If the information is particularly complicated, such as an entire monologue from Shakespeare, the Gamemaster may increase the penalty. Note: Cannot be taken with the Photographic Memory trait."} },
                
            { "Impaired Senses (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "stackable",
                "The Impaired Senses trait means that one of the character’s senses is not at its best. Whether this is the need for glasses, a hearing aid or being colour blind, the sense is less sensitive than the average person’s. When selecting this trait, the player should choose which sense is affected.",
                "Players should discuss with the Gamemaster which sense is affected, as well as the severity of the impairment. Minor Bad Traits would be: no sense of smell, colour blind, no sense of taste, needing to wear glasses or needing a hearing aid. Awareness rolls using these senses suffer a -2 penalty if the sense isn’t aided. The penalties don’t affect the character all of the time, only when there’s something to detect such as a strange gas leak, needing to rewire a device with differentcoloured wires or losing their glasses. Major Bad Traits would be losing a sense that impacts on their everyday actions, such as blindness or deafness. Note: Cannot be taken with Keen Senses, unless the Keen Sense is Minor and then in a Sense that isn’t Impaired."} },
                
            { "Impaired Senses (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "stackable",
                "The Impaired Senses trait means that one of the character’s senses is not at its best. Whether this is the need for glasses, a hearing aid or being colour blind, the sense is less sensitive than the average person’s. When selecting this trait, the player should choose which sense is affected.",
                "Players should discuss with the Gamemaster which sense is affected, as well as the severity of the impairment. Minor Bad Traits would be: no sense of smell, colour blind, no sense of taste, needing to wear glasses or needing a hearing aid. Awareness rolls using these senses suffer a -2 penalty if the sense isn’t aided. The penalties don’t affect the character all of the time, only when there’s something to detect such as a strange gas leak, needing to rewire a device with differen coloured wires or losing their glasses. Major Bad Traits would be losing a sense that impacts on their everyday actions, such as blindness or deafness. Note: Cannot be taken with Keen Senses, unless the Keen Sense is Minor and then in a Sense that isn’t Impaired."} },
                
            { "Impulsive", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "“Why worry, it’ll be fine, let’s go!” Impulsive people do not think things through before acting and are likely to leap before they look. It doesn’t mean they have a death wish – far from it – it’s just that they do things on a whim and sometimes come to regret it.",
                "There are no penalties or modifiers for this Minor Bad Trait, but the player should remember the impulsive nature of the character and bring it into play when possible. It doesn’t force them to take unnecessary risks, but they will leap into a situation before they have all of the facts, thinking they’re doing Good. Playing up to the trait should be rewarded by the Gamemaster if the situation and roleplaying is suitable for the plot and the game. At times the Gamemaster can make it a dramatic struggle, trying to resist the urge to be impulsive (in which case, a -2 modifier is applied to Ingenuity and Resolve)."} },
                
            { "Insatiable Curiosity", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "The character has a thirst for knowing what’s going on and investigating, even when it may not be Good for them to do so. What was that down that hole? Where does that corridor go, and what are those aliens up to? In many cases, Insatiable Curiosity has been the cause of many adventures (eSpecially in Clara’s case).",
                "This is a Minor Bad Trait that rewards playing in character and remembering their curious nature. It is usually unhelpful, but the character simply has to know what is going on, why something is happening or how it works. It may put their life at risk, but it doesn’t make them suicidal. If the character tries to fight the urge to press that button or open that door, the player can make an Ingenuity + Resolve roll, with a -2 modifier to resist. Note: Cannot be taken with the Unadventurous Bad Trait. If the character gains the Unadventurous trait (see pg. 46), the character loses the Insatiable Curiosity trait."} },
                
            { "Obligation (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "The character has a duty to a group or organisation and responsibilities that need to be upheld. They may be member of a government agency, such as UNIT, Torchwood, part of the government, a teacher at a school or even a secret order.",
                "Obligation is a Minor or Major Bad Trait, depending upon the responsibilities and the size of the organisation the character is associated with. As a Minor Trait, Obligation means the character belongs to a ‘normal’ organisation. They will not betray their allies and other members, and will be willing to risk a lot for what they believe in. As a Major Trait, Obligation means the organisation is more important than the character. They are always ‘on call’ and may not have time for a personal life. Their dedication is such that they’d be willing to lay down their life for the organisation, and penalties for disobedience or betrayal are severe. The Gamemaster should determine the ramifications of betraying their obligation - from disciplinary action to making a dangerous enemy (see the Adversary trait, pg. 39)."} },

            { "Obligation (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "one time",
                "The character has a duty to a group or organisation and responsibilities that need to be upheld. They may be member of a government agency, such as UNIT, Torchwood, part of the government, a teacher at a school or even a secret order.",
                "Obligation is a Minor or Major Bad Trait, depending upon the responsibilities and the size of the organisation the character is associated with. As a Minor Trait, Obligation means the character belongs to a ‘normal’ organisation. They will not betray their allies and other members, and will be willing to risk a lot for what they believe in. As a Major Trait, Obligation means the organisation is more important than the character. They are always ‘on call’ and may not have time for a personal life. Their dedication is such that they’d be willing to lay down their life for the organisation, and penalties for disobedience or betrayal are severe. The Gamemaster should determine the ramifications of betraying their obligation - from disciplinary action to making a dangerous enemy (see the Adversary trait, pg. 39)."} },

            { "Obsession (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "Someone, something, or some goal constantly weighs on the character’s mind. It may be just keeping track of time, doing things in threes, or it could be something as strong as the need for revenge or the love of a Special someone. Having the Obsession trait is rarely something helpful, and this Bad Trait is uncommon in player characters. This sort of fanaticism is best suited to people like Missy or the Half-Face Man.",
                "As a Minor Bad Trait, it means the character has a mild obsession, a bit like Clive and his investigation into the Doctor. It doesn’t creep into every part of their lives, but it’s always there, itching at the back of their minds. Their obsession isn’t strong enough to be too troublesome, but there are times when they simply have to do something because of their compulsion. Often, this isn’t anything too drastic, like switching the gas on and off again before leaving a house, checking their emails every hour or needing to wear a certain pair of underwear on Wednesdays. They can try to resist acting upon their obsessive nature with an Ingenuity and Resolve roll, suffering a -2 penalty. As a Major Bad Trait, the character is crazed with determination to do something. Almost every action or plan is designed to get them closer to achieving their aim, whether this is galactic domination or acquiring vast amounts of wealth. At this level, it is not usually suitable for player characters."} },

            { "Obsession (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "one time",
                "Someone, something, or some goal constantly weighs on the character’s mind. It may be just keeping track of time, doing things in threes, or it could be something as strong as the need for revenge or the love of a Special someone. Having the Obsession trait is rarely something helpful, and this Bad Trait is uncommon in player characters. This sort of fanaticism is best suited to people like Missy or the Half-Face Man.",
                "As a Minor Bad Trait, it means the character has a mild obsession, a bit like Clive and his investigation into the Doctor. It doesn’t creep into every part of their lives, but it’s always there, itching at the back of their minds. Their obsession isn’t strong enough to be too troublesome, but there are times when they simply have to do something because of their compulsion. Often, this isn’t anything too drastic, like switching the gas on and off again before leaving a house, checking their emails every hour or needing to wear a certain pair of underwear on Wednesdays. They can try to resist acting upon their obsessive nature with an Ingenuity and Resolve roll, suffering a -2 penalty. As a Major Bad Trait, the character is crazed with determination to do something. Almost every action or plan is designed to get them closer to achieving their aim, whether this is galactic domination or acquiring vast amounts of wealth. At this level, it is not usually suitable for player characters."} },

            { "Outcast", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "The character has done something that has led to a section of society, or an entire race or planet, shunning them or viewing them with fear, dread or loathing. It could be that they’ve offended someone’s beliefs, or committed a crime, or even just made such a fool of themselves that people regard them with complete disdain. They could have spoken out about their extreme scientific belief in aliens and been ridiculed in academic circles, or shunned by the government agency they work for and given an office in the basement.",
                "Players should discuss with the Gamemaster what the character has done and who regards them with such dislike or dismissal. When anyone that would react negatively to their presence encounters the character, they should make an Awareness + Ingenuity roll to recognise them. If the character is recognised, they’ll suffer a -2 penalty on all social rolls (such as trying to Convince or to even share their knowledge). If the ‘something’ they’ve done is more severe than this, they should take a Major Dark Secret Bad Trait instead."} },
              
            { "Outsider", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "You aren’t very Good at making friends and fitting in with groups. Somehow you just don’t seem to connect to other people very well",
                "You suffer a -2 penalty to social rolls with strangers and may not take the ‘Friends’ trait at character creation."} },

            { "Owes Favour (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "stackable",
                "In the past, someone did the character a favour. It could be anything from a sum of money, repaying them for getting a great job, or even saving the character’s life. Whatever it was, they’re not going to forget it, and they can call on the character to repay the favour.",
                "As a Minor Trait, the favour is something relatively small – a small amount of money (up to £1000 or so), an introduction to someone important, or bailed the character out when in trouble. As a Major Trait, the favour is more important, a large amount of money (over £10,000) to saving the character’s life. If the Gamemaster chooses, and if it suits the plot, they may opt to call in the favour, possibly even becoming an adventure in itself. Of course, if the favour called in is bigger than the first debt, it may be quits and this trait may be lost, or even gain the Owed Favour Good Trait!"} },

            { "Owes Favour (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "stackable",
                "In the past, someone did the character a favour. It could be anything from a sum of money, repaying them for getting a great job, or even saving the character’s life. Whatever it was, they’re not going to forget it, and they can call on the character to repay the favour.",
                "As a Minor Trait, the favour is something relatively small – a small amount of money (up to £1000 or so), an introduction to someone important, or bailed the character out when in trouble. As a Major Trait, the favour is more important, a large amount of money (over £10,000) to saving the character’s life. If the Gamemaster chooses, and if it suits the plot, they may opt to call in the favour, possibly even becoming an adventure in itself. Of course, if the favour called in is bigger than the first debt, it may be quits and this trait may be lost, or even gain the Owed Favour Good Trait!"} },
                
            { "Phobia", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "stackable",
                "Some people just don’t like spiders. Others, it’s cats. Or heights, flying, llamas or cheese. Having a Phobia trait means that there is something (that the player will define, usually with the Gamemaster’s help) that they are afraid of. A Phobia ignores the Brave trait – the character can be brave and courageous most of the time but crumble in the face of their biggest fear! Phobias can sometimes be gained during the course of an adventure if the character encounters something particularly scary that’ll leave a lasting impression like giant rats or clowns.",
                "The character will receive a -2 penalty to any attempt to approach the subject of their phobia or stay calm in its vicinity (see ‘Getting Scared’ on pg. 94). The Brave trait does not help with this roll."} },
                
            { "Selfish", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "stackable",
                "“But what’s in it for me?” It’s all about me. Me, me, me, me, me. The character may go along with the rest of the group, helping civilisations out of trouble or rescuing people in danger, but at the back of their mind is always the thought that they may be able to get something out of it: a reward, riches, hidden treasure, technological knowledge, or just information about the future that they can exploit.",
                "Selfish doesn’t interfere too much with the way the character acts – they’ll help and join in as usual – but there may be times when they sneak off to see what they can plunder or gain. The Gamemaster may reward this action with Story Points for playing in character if it moves the adventure in an exciting or unexpected direction at the character’s expense."} },
                
            { "Slow Reflexes (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "A character with this trait is constantly surprised by events, unable to get a word into a conversation, last to react in a confrontation and often hit in the face when a ball is thrown to them.",
                "As a Minor Bad Trait, the character always goes last when multiple people are acting at the same time in a round. Others will always go first. However, as a Major Bad Trait, the character always goes last in a round (see pg. 80), going after everyone else, as they try to take in all the information and work out what is the best course of action. Note: Cannot be taken with the Quick Reflexes Good trait."} },
                
            { "Slow Reflexes (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "one time",
                "A character with this trait is constantly surprised by events, unable to get a word into a conversation, last to react in a confrontation and often hit in the face when a ball is thrown to them.",
                "As a Minor Bad Trait, the character always goes last when multiple people are acting at the same time in a round. Others will always go first. However, as a Major Bad Trait, the character always goes last in a round (see pg. 80), going after everyone else, as they try to take in all the information and work out what is the best course of action. Note: Cannot be taken with the Quick Reflexes Good trait."} },
                
            { "Technically Inept", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "Technology seems to hate the character. Things break when touched, using advanced technology is frustrating and annoying, trying to fix technology presents the character with a mass of wires and welding that is so completely confusing that they hardly know where to start.",
                "Technically Inept means that any attempt to fix technology or devices, or use particularly complex technology, suffers a -2 penalty to the roll. If the Gamemaster thinks it is suitable to the story, an electronic device being used by the character can fuse or fail at a dramatic moment. Note: Cannot be taken with the Boffin or Technically Adept traits."} },
                
            { "Unadventurous (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "The idea of exploring or seeing the world and the universe just doesn’t seem to appeal. Why spend money travelling across the world when you don’t have anything to show for your expense afterwards except some trinkets and fading photographs? Sometimes, it’s just laziness, fatigue or Bad experience, but either way the excitement and thrill of travelling or experiencing the new just isn’t there, or has faded.",
                "It is rare that characters have this trait at creation but it can be gained during play due to repetitive injuries, being captured too many times, or just growing tired of the constant peril and relentless danger. If the Gamemaster thinks the character is getting captured or injured too often, they may gain Unadventurous as a Minor Bad Trait. They can try to buy this off with Good roleplaying (see pg. 109), but in the meantime they are disinterested in some of the wonders of the universe, and can even dread the experiences a life of adventure can bring. This can increase to a Major Bad Trait if they continue to have Bad experiences. Again, the player can try to fuel the character’s interest and buy off the trait, but it’ll become obvious that the character is really unhappy to be involved in the travels. The Gamemaster may apply a -2 penalty to rolls during the game – not every roll, but certainly those where a level of enthusiasm is needed. If the Bad experiences continue still, the character can get so fed up with the constant peril, danger and repeated injuries that they decide to leave. They demand that they are returned home (or to a time and place where they can be happy) and leave the TARDIS crew, usually for Good. They may return for a guest appearance, but other than that, the player should create a new character (see ‘Dying or Leaving the TARDIS’ on pg. 97). Note: Cannot be taken with the Insatiable Curiosity Bad Trait."} },

            { "Unadventurous (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "one time",
                "The idea of exploring or seeing the world and the universe just doesn’t seem to appeal. Why spend money travelling across the world when you don’t have anything to show for your expense afterwards except some trinkets and fading photographs? Sometimes, it’s just laziness, fatigue or Bad experience, but either way the excitement and thrill of travelling or experiencing the new just isn’t there, or has faded.",
                "It is rare that characters have this trait at creation but it can be gained during play due to repetitive injuries, being captured too many times, or just growing tired of the constant peril and relentless danger. If the Gamemaster thinks the character is getting captured or injured too often, they may gain Unadventurous as a Minor Bad Trait. They can try to buy this off with Good roleplaying (see pg. 109), but in the meantime they are disinterested in some of the wonders of the universe, and can even dread the experiences a life of adventure can bring. This can increase to a Major Bad Trait if they continue to have Bad experiences. Again, the player can try to fuel the character’s interest and buy off the trait, but it’ll become obvious that the character is really unhappy to be involved in the travels. The Gamemaster may apply a -2 penalty to rolls during the game – not every roll, but certainly those where a level of enthusiasm is needed. If the Bad experiences continue still, the character can get so fed up with the constant peril, danger and repeated injuries that they decide to leave. They demand that they are returned home (or to a time and place where they can be happy) and leave the TARDIS crew, usually for Good. They may return for a guest appearance, but other than that, the player should create a new character (see ‘Dying or Leaving the TARDIS’ on pg. 97). Note: Cannot be taken with the Insatiable Curiosity Bad Trait."} },
                
            { "Unattractive", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "For every stunningly gorgeous individual there are those whose faces do not launch a thousand Jathaa Sungliders or stop traffic on the New New York motorways (unless that face is the Face of Boe). They’re not necessarily ugly or hideous, but their looks may hinder when it comes to some social situations.",
                "The trait comes into play whenever doing something that their looks can influence, suffering a -2 penalty to rolls. On rare occasions, their appearance (eSpecially if it is somewhat menacing, such as scarred) can provide a +2 bonus if they are trying to intimidate someone. Note: Cannot be taken with the Attractive Good Trait."} },

            { "Unlucky", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "Call it a curse, call it chance, but fortune hasn’t smiled for a while. The traffic lights turn red whenever approached, the character pressed the wrong button on the control panel and shorted the autopilot or their attempt at being diplomatic has resulted in insulting the city’s patron and her entire family.",
                "The character is unlucky! Simple as that. If you roll two ‘6’s on your dice, you’d normally cheer as this would be a huge success. At least, normally. Characters with the Unlucky trait have to re-roll when double ‘6’s are rolled, increasing the random chance of rolling something worse. If you get double ‘6’s again, well, your unlucky streak isn’t so Bad – you can keep that result."} },

            { "Wanted (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "You are actively hunted by a group. They may believe you have committed a crime, but they might just as easily want to worship you as the chosen one. Either way, you don’t want them to catch up with you.",
                "As a Minor Bad Trait the group will sometimes come across you, but they have limited resources and are unable to send a large force to bring you in. As a Major Trait the group are very powerful, and if they catch up with you, you are as Good as captured"} },
                
            { "Wanted (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "one time",
                "You are actively hunted by a group. They may believe you have committed a crime, but they might just as easily want to worship you as the chosen one. Either way, you don’t want them to catch up with you.",
                "As a Minor Bad Trait the group will sometimes come across you, but they have limited resources and are unable to send a large force to bring you in. As a Major Trait the group are very powerful, and if they catch up with you, you are as Good as captured"} },
                
            { "Weakness (Minor)", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "stackable",
                "The Weakness trait reflects a single area where the character is susceptible to harm or temptation. This could be anything from an allergy like hay fever or wasp stings (not so Good when fighting giant wasps!), to being weak willed and susceptible to mind control, or suffering from occasional - but paralysing - drive glitches.",
                "The Weakness trait reflects a single area where the character is susceptible to harm or temptation. This could be anything from an allergy like hay fever or wasp stings (not so Good when fighting giant wasps!), to being weak willed and susceptible to mind control, or suffering from occasional - but paralysing - drive glitches. Effect: The player should discuss the chosen weakness with the Gamemaster and come to an agreement over the exact nature of this Bad Trait. In most cases, when the character encounters the thing that affects them, any rolls suffer a -2 penalty. In the case of a substance like pollen or stings, the character should suffer a -2 penalty to all actions while they’re within range or exposed to its effects. For example, being stung by a wasp (not a giant Vespiform but a normal-sized one), when allergic to wasp and bee stings will result in suffering a -2 penalty to all actions for at least eight hours (or until an anti-toxin is administered), while he’s feeling weak and groggy from the poisons. Weakness as a Major Trait is best suited for villains and aliens who need a definite exploitable weakness to give the characters a chance against them, such as weakness to acetic acid, or an extreme reaction to water or gold. Major Weaknesses actually cause injury rather than a penalty and exposure to the effective element will actually inflict 4 levels of damage, reducing their attributes (see Injuries, onpg. 85)."} },
                
            { "Weakness (Major)", new [] { 
                "Bad", 
                "Major", 
                "core book",
                "stackable",
                "The Weakness trait reflects a single area where the character is susceptible to harm or temptation. This could be anything from an allergy like hay fever or wasp stings (not so Good when fighting giant wasps!), to being weak willed and susceptible to mind control, or suffering from occasional - but paralysing - drive glitches.",
                "The Weakness trait reflects a single area where the character is susceptible to harm or temptation. This could be anything from an allergy like hay fever or wasp stings (not so Good when fighting giant wasps!), to being weak willed and susceptible to mind control, or suffering from occasional - but paralysing - drive glitches. Effect: The player should discuss the chosen weakness with the Gamemaster and come to an agreement over the exact nature of this Bad Trait. In most cases, when the character encounters the thing that affects them, any rolls suffer a -2 penalty. In the case of a substance like pollen or stings, the character should suffer a -2 penalty to all actions while they’re within range or exposed to its effects. For example, being stung by a wasp (not a giant Vespiform but a normal-sized one), when allergic to wasp and bee stings will result in suffering a -2 penalty to all actions for at least eight hours (or until an anti-toxin is administered), while he’s feeling weak and groggy from the poisons. Weakness as a Major Trait is best suited for villains and aliens who need a definite exploitable weakness to give the characters a chance against them, such as weakness to acetic acid, or an extreme reaction to water or gold. Major Weaknesses actually cause injury rather than a penalty and exposure to the effective element will actually inflict 4 levels of damage, reducing their attributes (see Injuries, onpg. 85)."} },

            //Special Traits (with a few exceptions)
            { "Alien", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "Aliens come in all shapes and sizes, but in the Majority of cases these aliens are basically humanoid in shape, with certain abilities and features that set them apart. By purchasing the Alien trait, the character is of an alien race, alien to humanity, and one of the infinite varieties of lifeforms.",
                "Alien is a ‘gateway’ trait, opening a selection of additional traits that are normally unavailable to humans, and costs 2 Character Points to purchase. The Gamemaster should approve the selection of this trait. The Alien trait means that the character is from another planet. Initially, they are of human appearance and look similar to everyone else on Earth. This trait does open up the opportunity to purchase other specifically Alien traits, and enables attributes to be above level 6. As a downside, if discovered as being an Alien, they may suffer severe consequences (such as being captured by the government and experimented upon). Additionally, some of the Alien-only traits that are now open may mean that the character will have an alien appearance. For more information on creating aliens and alien characters, and additional Alien traits, see Chapter Five: All the Strange, Strange Creatures (pg. 143)."} },
                
            { "Alien Appearance", new [] { 
                "Bad", 
                "Special", 
                "core book",
                "one time",
                "While many aliens can pass for human under some circumstances (or low lighting), the character with this trait will have an obviously alien appearance. It could be that they’re basically human but green, or have a large head to accommodate their massive brain power, or pointy ears, or obviously reptilian features. Players should feel free to be creative. This trait could also be taken by a human whose physical form has been altered by mutation or experimentation.",
                "Alien Appearance is a Bad Trait that can provide either 2 Points or 4 Points. The more severe the Alien Appearance trait, the more ‘alien’ the character looks. As a 2-point Bad Trait, Alien Appearance means the character is basically humanoid but with a distinctive alien feature. In most cases, when they encounter people who are OK with aliens there will be nothing out of the ordinary, however when meeting the inhabitants of more-primitive planets (see Technology Levels, pg. 65) who may not have met aliens before, social rolls will all suffer a -2 penalty (that is if they don’t just run away!). As a 4-point Bad Trait, the ‘alien-ness’ of the character is more extreme. The may have tentacles instead of limbs, or a face like a squid – they could look like anything! Again, on advanced planets that are used to aliens, this isn’t a problem, but if they meet less experienced peoples they will suffer a -4 penalty on social rolls (possibly even become the target of scared locals who assume the alien is a monster to be destroyed!)."} },

            { "Clairvoyance", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "(Prerequisite: Psychic) A true clairvoyant has the ability to see distant locations through intense concentration as if they were actually there. In the past, this talent was found in tribal ‘seers’ and visionaries. During the Cold War this was called ‘Remote Viewing’ as teams of intelligence psychics tried to spy on distant countries to uncover secret bases and weapons.",
                "Clairvoyance is a Special Trait, requiring the character to already have the Psychic trait. Clairvoyance costs 2 points. The character can see into other locations without actually being there or having to rely on technology. It will cost a Story Point to activate this ability and the range is limited to the character’s Resolve – the higher their Resolve, the further away they can see. Often these ‘visions’ will be flashes or mere glimpses into another place, but with practice, concentration and a high Resolve, the experience can be prolonged and immersive. Clairvoyance uses the character’s innate abilities, rather than a skill, so Awareness and Resolve are used to view distant locations. People at the spied location with the Psychic Training trait can sense they are being watched or observed and may try to resist."} },


            { "Cyborg", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "On some high tech worlds machinery can be used to replace body parts lost due to an injury, improvement or simply old age. The character is such a merging of flesh and machine. The cybernetic part is able to act like a Gadget, but it does also mean the character could be subject to discrimination in certain parts of the galaxy, where cyborgs are regarded as second class citizens.",
                "Effect: Cyborg is a Special Good Trait that costs either 1 or 3 Character Points. At the lowest level, the cybernetic parts of the character are obvious. They can be hidden, but they will have to be careful. Bannakaffalatta is like this, his cybernetic chest section is something that can be hidden, but it is bulky and is obvious if he removes his shirt. At the 3-point level, the cybernetic elements are completely disguised under fairly realistic looking, plastic skin. The Cyborg trait allows the character to have a permanent Gadget (which must be purchased separately) that will not run out of power or get lost (see Gadgets, on pg. 112). Major cybernetic overhauls, such as Max Capricorn’s or full Cyberman conversion are not suitable for a character in the game, except at the Gamemaster’s discretion. Note: Cannot be taken with the Robot trait."} },

            { "Experienced", new [] { 
                "Good", 
                "Special", 
                "core book",
                "stackable",
                "The character creation rules are suited to companions and normal heroes. Players may find it tricky to create a character as experienced or as powerful as River Song or Captain Jack Harkness. This trait provides the character with additional Character Points and Skill Points, at the cost of Story Points. This reduction in Story Points not only applies at character creation, it also reduces the number of Story Points the character can carry over between adventures.",
                "Experienced reduces the maximum Story Point pool for the character by 3 and provides the character with an additional 2 Character Points and 2 Skill Points. This trait can be purchased additional times, though no character can be reduced to zero Story Points because of this. That’s far too dangerous! Not every character should be as experienced as this, and their lower Story Points help to balance the character with their less experienced companions."} },

            { "Fear Factor", new [] { 
                "Good", 
                "Special", 
                "core book",
                "stackable",
                "The Fear Factor trait is designed for monsters, and those truly scary individuals who can send people running in terror. They don’t have to be ugly or monstrous – people cowered at the Master’s feet in fear of their lives – but sometimes just looking at the alien with the mouth full of sharp fangs that fills them with fear.",
                "Fear Factor is a Special Trait that is only suitable for Villains. It costs 1 point, but can be purchased multiple times. Each purchase of the Fear Factor trait adds +2 to any roll when actively trying to strike fear into people’s hearts. See ‘Getting Scared’ on pg. 94."} },

            { "Feel the Turn of the Universe", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "Not many people experience the clarity and the wonder that is feeling the whole universe. Knowing you’re just a small part in the vast, almost endless universe of planets and possibilities. It can drive some people mad, and others can sense when something is wrong. This trait is not available to companions, and is normally only for Time Lord characters (see pg. 56). However, a rare few aliens and even a few humans may possess this trait as the result of being exposed to the Vortex, or possibly being on the verge of madness like Vincent Van Gogh.",
                "Feel the Turn of the Universe costs 1 point and gives the character an innate ability to sense when something is amiss or unnatural and what needs to be done to set the universe right. This can be anything from sensing that a person has unnatural indestructibility, to knowing that something is disturbing nature or sense if something is tampering with time. They may not know exactly what it is, but they’ll know something isn’t right. The character will sense something is wrong with an Awareness + Ingenuity roll with a +2 bonus – the more successful they are, the clearer the problem will appear, as well as the potential solution."} },

            { "Immortal (Major)", new [] { 
                "Good", 
                "Major", 
                "core book",
                "one time",
                "(Prerequisite: Alien Trait) There are two types of Immortal being in existence. The first never gets old, never ages and will never die of old age. They simply continue on. While it’s rare for them to die from a disease, they still can, and can certainly be killed through violence or accident. Immortal at this level is a Major Good Trait and while it doesn’t affect the actual game (as they can still be killed through violence) they could have already lived a long time. The Gamemaster may allow them to recall something from their past if it suits the story, or something from their history could resurface, provoking a whole new adventure. If they have lived ‘ages’, then they should purchase the Time Traveller trait for the past eras that they were alive and active, at the Gamemaster’s discretion. The second type of Immortal cannot be killed through violence, accident or disease. This version is a Special Good Trait. They may get a little older in appearance, but their longevity is so epic that their ageing is hardly noticeable. They can be shot, electrocuted, drowned and fried, but they just don’t seem to die. They may fall down and look dead, but it isn’t long before they’re up and active again. Again, if they’ve been alive for a long time, they should also purchase the Time Traveller trait for the eras they were alive – they have time travelled, they’ve just done it the slow way.",
                "Immortal is either a Major Good Trait that costs 2 points, meaning the character never ages and will not die of natural causes, or a Special Trait, which means the character cannot be killed. Both may be unbalancing to the game and if a player intends to take either version of the Immortal trait, they should discuss it with the Gamemaster. Immortal as a Special Trait costs 5 Character Points, as well as reducing the character’s maximum Story Points by 4. If killed during the course of an adventure, the character looks dead and is unable to be revived. Without the Fast Healing trait, the character will heal at a normal rate (this is usually 1 level of attribute per day of rest). When they have healed all of the damage they have taken, and returned to their full health, they will wake and be fine. If the damage is really severe, the Gamemaster may keep track of how far into the ‘negative’ your character’s attributes go, and they will have to heal all of these before they can recover. Any extreme damage, such as loss of limb, may lead to further Bad Traits unless they also have the Fast Healing trait, though these may heal over a long period of time at the Gamemaster’s discretion. The Alien trait must have been purchased before selecting Immortal, though in rare circumstances (such as Captain Jack Harkness) Immortality may be granted to humans at the Gamemaster’s discretion."} },

            { "Immortal (Special)", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "(Prerequisite: Alien Trait) There are two types of Immortal being in existence. The first never gets old, never ages and will never die of old age. They simply continue on. While it’s rare for them to die from a disease, they still can, and can certainly be killed through violence or accident. Immortal at this level is a Major Good Trait and while it doesn’t affect the actual game (as they can still be killed through violence) they could have already lived a long time. The Gamemaster may allow them to recall something from their past if it suits the story, or something from their history could resurface, provoking a whole new adventure. If they have lived ‘ages’, then they should purchase the Time Traveller trait for the past eras that they were alive and active, at the Gamemaster’s discretion. The second type of Immortal cannot be killed through violence, accident or disease. This version is a Special Good Trait. They may get a little older in appearance, but their longevity is so epic that their ageing is hardly noticeable. They can be shot, electrocuted, drowned and fried, but they just don’t seem to die. They may fall down and look dead, but it isn’t long before they’re up and active again. Again, if they’ve been alive for a long time, they should also purchase the Time Traveller trait for the eras they were alive – they have time travelled, they’ve just done it the slow way.",
                "Immortal is either a Major Good Trait that costs 2 points, meaning the character never ages and will not die of natural causes, or a Special Trait, which means the character cannot be killed. Both may be unbalancing to the game and if a player intends to take either version of the Immortal trait, they should discuss it with the Gamemaster. Immortal as a Special Trait costs 5 Character Points, as well as reducing the character’s maximum Story Points by 4. If killed during the course of an adventure, the character looks dead and is unable to be revived. Without the Fast Healing trait, the character will heal at a normal rate (this is usually 1 level of attribute per day of rest). When they have healed all of the damage they have taken, and returned to their full health, they will wake and be fine. If the damage is really severe, the Gamemaster may keep track of how far into the ‘negative’ your character’s attributes go, and they will have to heal all of these before they can recover. Any extreme damage, such as loss of limb, may lead to further Bad Traits unless they also have the Fast Healing trait, though these may heal over a long period of time at the Gamemaster’s discretion. The Alien trait must have been purchased before selecting Immortal, though in rare circumstances (such as Captain Jack Harkness) Immortality may be granted to humans at the Gamemaster’s discretion."} },

            { "Inexperienced", new [] { 
                "Bad", 
                "Special", 
                "core book",
                "stackable",
                "The character creation rules here are suited to companions and normal heroes. Players may find, however, that this doesn’t reflect very inexperienced or young characters. Courtney would be a perfect example of this. She’s still in school, hasn’t finished growing, and is very inexperienced when it comes to adventuring through time and space. But, she is brave and keen to help the Doctor in the most dangerous situations.",
                "This trait costs 2 Character Points and 2 Skill Points. In return, the character’s maximum Story Point pool is increased by 3. These additional Story Points will help them to keep up with the more experienced character while reflecting their lack of skills. This trait can be purchased additional times for even less experienced characters, though this will have to be approved by the Gamemaster. If, however, during the game the character’s skills and total Character Points increases through experience to the levels of a normal character, the character’s maximum Story Points are reduced to their normal level."} },

            { "Last of My Kind", new [] { 
                "Bad", 
                "Minor", 
                "core book",
                "one time",
                "(Prerequisite: Alien Trait) Being the last of your kind can be a burden as well as lonely. To know that there is no one else like you out there, and that an entire race dies when you do.",
                "Last of My Kind is a Minor Bad Trait, and has the prerequisite of the ‘Alien’ Special Trait (unless, during the course of the game, every other human in the universe is wiped out… but that’s what the Doctor’s around for, to prevent things like that happening!). As the last of their kind, the character can often get moody and depressed, and needs the companionship of others to stop the weight of the responsibility and loneliness from getting too much. When travelling alone, the depression can affect everything the character does, imposing a -2 penalty on every action unless engaged in combat. At particularly Bad times, the Gamemaster may impose this penalty even when travelling with others – for example when reminded of their situation, anniversaries of the destruction of their homeworld, or similar."} },

            { "Precognition", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "(Prerequisite: Psychic Trait) Some people, such as the Sybilline Sisterhood, are gifted with the ability to see the future. In many civilisations, they become the town ‘seer’, or are outcast from society due to their strange abilities. Most of the time, these abilities manifest as visions – incomplete fragments of a potential future seen as a strange and abstract dream. The future is usually in flux, ever changing, except for certain fixed points in history, so the visions of the future are fairly vague to reflect the potential for the events to change..",
                "This trait costs 1 point to purchase and can only by taken by characters with the Psychic trait. When appropriate to the story, the Gamemaster may give the character flashes of information to help or encourage them to pursue a particular course of action to aid the adventure. If the player wants the character to actively try to sense what is to come, they should spend a Story Point, and the Gamemaster will supply as much useful information is they think necessary (without ruining the story!)."} },

            { "Psychic", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "Psychic is a Special Good Trait, costing 2 points to purchase (or 1 point if the character already has the Psychic Training trait) that allows them to reach into another person’s mind and try to access hidden information, though the target can resist. Companions or humans are rarely Psychic, but it occurs in a scarce few. The Gamemaster should approve selection of this trait.",
                "To see into a target’s mind, the player must succeed at a Resolve + Awareness test. The target must be within visual range (with the naked eye) and the trait provides the character with a +4 bonus on the roll. However, if the target is unwilling, they can resist such a mental intrusion with a Resolve and Ingenuity roll. Both sides can spend Story Points if they’re concentrating intently. Psychic also gives a +4 bonus when the character attempts to resist having their mind read, and to resist possession."} },

            { "Robot", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "Instead of flesh and bone they are made of steel, wires and plastics. Instead of an organic brain their mind is made of circuitry and a powerful computer. Robot is a Special Good Trait that costs 2 points as a robot of normal appearance – that is, they look like a robot, such as K-9, a Host, a Roboform or even Kamelion (one of the Doctor’s earlier companions). However, the trait can be purchased at a higher level, costing 4 points, which means externally you look convincingly human – most of the time people will assume you are human unless you’re injured or display inhuman abilities.",
                "Robot means the character is a robot. They have attributes, skills and traits, just like a living character. However, their attributes can be raised above level 6, and they can purchase Gadget Traits (see pg. 112). These are traits normally used only in Gadgets, but this means that traits such as Forcefield or Scan, can be built directly into the robot character! Robot also means that the character does not die from old age (though their power supply may need replacing). When a robot takes a physical injury, it loses attributes just like a person, though it will not heal itself over time – either itself or another suitably skilled technician will need to conduct repairs (using Ingenuity + Technology), with a level of injury repaired equal to the level of success. A robot character can be ‘killed’ and repaired, returning to fully operational level, though if the damage is severe enough (such as being disintegrated or dropped into a furnace or vat of molten metal) the robot is unlikely to be salvageable. Robots normally learn over time, and can increase their mental skills just as a human, however physical skills and attributes will require some form of ‘upgrading’ to take into account the increased ability. Of course, in most cases a robot does have the disadvantage of standing out in a crowd and scaring primitive civilisations! Note: Cannot be taken with the Alien or Cyborg trait."} },

            { "Telekinesis", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "(Prerequisite: Psychic Trait) Telekinesis, sometimes called psychokinesis, is the power to move something with thought alone. Just concentrating on something can make it move, bend, float or break. This power is usually limited to line-of-sight. That is, if the character cannot see it (because it is too far away or in another room) they cannot concentrate enough on the object to lift or manipulate it (though characters with Clairvoyance may be able to see the object psychically, though they will be limited to adjacent rooms). Telekinesis is a Special Trait that costs 2 points to purchase, and should only be picked with the approval of the Gamemaster. It can only be purchased if the character already has the Psychic trait (see pg. 53).",
                "The Telekinesis trait uses the character’s Resolve rather than Strength to determine how much they can lift by thought alone. For example, if the character has Resolve 1, they can lift something with their Telekinesis as if they were physically lifting it with a Strength of 1. The only difference is, they’re not using their hands – they’re using their mind. To just lift an item, the character is using their innate abilities, so the player should make a roll using their Ingenuity + Resolve. To throw an item at a target using Telekinesis, Resolve replaces Strength and the character would need to succeed at a Resolve + Marksman roll. Picking a lock, for example, would use Resolve + Subterfuge, but the character would need to be able to see the mechanism in some way (either an x-ray scanner or clairvoyance) to telekinetically manipulate it."} },

            { "Telepathy", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "(Prerequisite: Psychic Trait) Telepathy is the ability to communicate with others through the power of the mind. Telepaths can project their thoughts directly into someone else’s head and they’ll hear it as if they’re speaking to them. Usually, the person isn’t too far away, but if the character’s Resolve is high, they could communicate to someone up to a kilometre away or even further. Very handy if you need to call for help! Once a link has been established, they can hold a short conversation as long as they are not distracted or under stress. The moment they are distracted (for example being surprised by a loud noise or a sudden attack) the link is lost and the character will have to try again at a calmer moment when they can concentrate.",
                "Telepathy is a Special Trait that costs 1 point to purchase. Approval from the Gamemaster will be required before selecting this trait. The character must also have the Psychic trait before they can purchase Telepathy. Telepathy uses the character’s innate abilities, rather than a skill, so Ingenuity and Resolve are used for the roll to establish communication. If the target doesn’t want to be contacted, they can resist with a similar roll. The distance over which the character can communicate with the Telepathy trait depends upon their Resolve."} },

            { "Time Agent", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "Time Agents are Special operatives of the Time Agency, a shadowy group performing undercover espionage work involving time travel. Little is known of them, only that their operations spanned the galaxies and all of time. When Jack Harkness returned to Cardiff after the Harold Saxon encounter, he was told that there were only seven surviving operatives (including the renegade agents Captain Jack Harkness and Captain John Hart). They are usually equipped with Vortex Manipulators, and ‘bounce’ through time to their assignments.",
                "Time Agent is a Special Trait that means the character has worked (or still works) for the Time Agency. They will have familiarity with 51st Century technology (Tech Level 8 is their ‘home’ era), and usually have a Vortex Manipulator that allows them to communicate, time travel and interact with computer technology (although whether or not this still works to its full capabilities is up to the Gamemaster). They may suffer from partial amnesia, having their memory wiped after particularly secretive missions, reflected by purchasing the Amnesia trait. The Time Agent trait means they automatically gain the Vortex trait, and will (usually) have a Vortex Manipulator in their equipment. Time Agent costs 2 Character Points and 2 Story Points to purchase, and players should discuss with the Gamemaster if having a Time Agent (or former Time Agent) in the group is going to upset the game."} },

            { "Time Lord", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "The Time Lords of Gallifrey were one of the first and most powerful civilisations in the universe. Pioneers of time travel technology, they became self appointed custodians of time before their fall during the Time War with the Daleks.",
                "The rarest and the most Special of all Special Traits is ‘Time Lord’. This Special Trait costs 2 Character Points and 4 Story Points. Only two Time Lords are known to have escaped Gallifrey at the end of the Time War, so you’ll probably only use this trait when playing the Doctor. Close discussions between player and Gamemaster is essential before creating a Time Lord character. This trait gives the character all of the abilities of a Time Lord – they can regenerate, automatically gain the Code of Conduct, Feel the Turn of the Universe and Vortex traits and gain 2 levels of the Ingenuity attribute (even if this takes the attribute above 6). They also get a Gadget at no extra cost. The Gamemaster will decide if they have access to a TARDIS or not – there is no additional cost for this as it may be essential to the Gamemaster’s plans for the story. Time Lords must have a couple of Bad Traits – they can be eccentric, aloof and have superiority complexes, or be just plain crazy. Staring into the Untempered Schism can do that to you! Time Lords are usually mildly Telepathic, so players wishing to have a Time Lord character may wish to purchase Psychic and Telepathy traits. Further rules for playing a Time Lord character, their abilities, regeneration and TARDISes, see Chapter Four: Time and Time Again, and the Time Traveller’s Companion supplement. Note: Although Time Lords are alien to humanity, they look so outwardly alike that there is no need to purchase the Alien trait."} },

            { "Time Lord (Experienced)", new [] { 
                "Good", 
                "Special", 
                "core book",
                "stackable",
                "(Prerequisite: Time Lord) The experienced Time Lord has been around for centuries, gaining a vast repertoire of skills and knowledge. Although, in gaining all of this experience, they may have exhausted a regeneration or two in the process.",
                "This trait means that the character is older (and hopefully wiser) than a novice Time Lord. The player can choose any additional number of years to add to their age, between 100 and 200 years. If you’d prefer to choose this randomly, roll two dice and multiply the result by 10, and add 80 (2D6x10 +80). This will produce a figure between 100 and 200. This is the number of years added to the Time Lord’s age. By taking this trait, the Time Lord uses up one of their regenerations. The player should decide how and when this was, creating a suitably interesting and exciting background for the events that led up to his regeneration. Each regeneration can change the character’s attributes and will change their appearance. If the Gamemaster prefers, each regeneration could be handled using the regeneration rules in Chapter Four: Time and Time Again (see pg. 121). The character gains 4 additional Skill Points, and an additional Time Traveller trait for a different time period. Experienced Time Lord is a Special Trait that costs 1 Character Point to purchase and requires the character to already have the Time Lord trait. Benefits of Experienced Time Lord are cumulative with Time Lord, and Experienced Time Lord can be purchased more than once – though remember, every time it is purchased, it reduces the character’s regenerations by one…"} },

            { "Vortex (Minor)", new [] { 
                "Good", 
                "Minor", 
                "core book",
                "one time",
                "The Space-time Vortex is a swirling maelstrom that requires great knowledge and skill to navigate. The character may not have access to a TARDIS, Vortex Manipulator or another time travel device, but they have experience in travelling through the Vortex and are familiar with its dangers.",
                "Vortex is a Special Trait, costing 1 point, and is not for beginning characters (unless they have a background of using a TARDIS or other Vortex Manipulators). Selecting Vortex as a trait at character creation has to be approved by the Gamemaster. The Vortex trait adds +2 to any roll that involves piloting a time travel or Vortex-manipulating device. Controlling the TARDIS (or other such time vessels) is so tricky to the unskilled, that it is almost impossible to actually be able to succeed at the task without having the Vortex trait. An additional ‘level’ of Vortex is available to characters with the Alien trait (see pg. 49), and costs 8 points. This high level of Vortex means the character can time travel without the need of a ship or device, literally stepping through time. This is an Alien trait and is best reserved for Villains or NPCs. To step through time requires an Ingenuity and Resolve Roll to use, and the expenditure of two Story Points. The more successful the roll, the more accurate the ‘jump’."} },
            
            { "Vortex (Special)", new [] { 
                "Good", 
                "Special", 
                "core book",
                "one time",
                "The Space-time Vortex is a swirling maelstrom that requires great knowledge and skill to navigate. The character may not have access to a TARDIS, Vortex Manipulator or another time travel device, but they have experience in travelling through the Vortex and are familiar with its dangers.",
                "Vortex is a Special Trait, costing 1 point, and is not for beginning characters (unless they have a background of using a TARDIS or other Vortex Manipulators). Selecting Vortex as a trait at character creation has to be approved by the Gamemaster. The Vortex trait adds +2 to any roll that involves piloting a time travel or Vortex-manipulating device. Controlling the TARDIS (or other such time vessels) is so tricky to the unskilled, that it is almost impossible to actually be able to succeed at the task without having the Vortex trait. An additional ‘level’ of Vortex is available to characters with the Alien trait (see pg. 49), and costs 8 points. This high level of Vortex means the character can time travel without the need of a ship or device, literally stepping through time. This is an Alien trait and is best reserved for Villains or NPCs. To step through time requires an Ingenuity and Resolve Roll to use, and the expenditure of two Story Points. The more successful the roll, the more accurate the ‘jump’."} },

            //ALIEN TRAITS - For testing purposes
            //TODO: Finish adding remaining skills
            { "Additional Limbs", new [] { 
                "Good", 
                "Special", 
                "core book (aliens)",
                "stackable",
                "Many hands make light work, or so they say (though try saying that to Alexander Monro). Taking this trait means that the alien has an additional pair of limbs. This can mean arms or legs or an odd alien limb or tentacle that functions as both. Of course, taking an additional pair of limbs means that the character is usually very obviously an alien in appearance, and will automatically get the Alien Appearance Bad Trait (Minor). The Additional Limbs trait can be taken a second time, giving the alien a cumulative bonus, but their Alien Appearance trait becomes Major.",
                "Additional Limbs is a Minor Good Alien Trait, and costs just 1 point for every additional pair of limbs. If the alien has additional legs, their effective Speed (when calculating chases and alike) is increased by +2. If the limbs are arms, the first additional action in any action round receives no penalty (as they can effectively do two things at once). This trait can be taken twice to create an eight limbed alien, though they will be obviously more alien. Additional limbs can be had on top of this, but they receive no bonus and cost no extra – there comes a point when you have so many legs or arms that it just becomes confusing and you can end up tripping over your own feet."} },

            //TODO: Add traits from other expansions
        };
    }
}