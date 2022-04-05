using Microsoft.EntityFrameworkCore;

namespace StarTrek.Models
{
    public class StarTrekContext : DbContext
    {
        public StarTrekContext(DbContextOptions<StarTrekContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Character>()
                .HasData(
                    new Character { Name = "James T. Kirk", Bio = "Captain of the USS Enterprise NCC-1701", CharacterId = 1 },

                    new Character { Name = "Hikaru Sulu", Bio = "Helmsman on the USS Enterprise NCC-1701", CharacterId = 2 },

                    new Character { Name = "Nyota Uhura", Bio = "Chief Communications Officer on the USS Enterprise NCC-1701", CharacterId = 3 },

                    new Character { Name = "Spock", Bio = "Chief Science Officer on the USS Enterprise NCC-1701", CharacterId = 4 },

                    new Character { Name = "Leonard McCoy", Bio = "Chief Medical Officer on the USS Enterprise NCC-1701", CharacterId = 5 },

                    new Character { Name = "Montgomery Scott", Bio = "Chief Engineer on the USS Enterprise NCC-1701", CharacterId = 6 },

                    new Character { Name = "Pavel Chekov", Bio = "First Officer on the USS Enterprise NCC-1701", CharacterId = 7 },

                    new Character { Name = "Jean Luc Picard", Bio = "Captain of the USS Enterprise C", CharacterId = 8 },

                    new Character { Name = "Geordi LeForge", Bio = "Chief Engineer on the USS Enterprise C", CharacterId = 9 },

                    new Character { Name = "Worf", Bio = "Chief of Security on the USS Enterprise C", CharacterId = 10 },

                    new Character { Name = "William Riker", Bio = "Commander on the USS Enterprise C", CharacterId = 11 },

                    new Character { Name = "Dianna Troi", Bio = "Counselor on the USS Enterprise C", CharacterId = 12 },

                    new Character { Name = "Dana Yar", Bio = "Former Chief of Security on the USS Enterprise C", CharacterId = 13 },

                    new Character { Name = "Beverly Crusher", Bio = "Chief Medical Officer on the USS Enterprise C", CharacterId = 14 },

                    new Character { Name = "Wesley Crusher", Bio = "Ensign aboard the USS Enterprise-C, training to become a Starfleet Officer.", CharacterId = 15 },
                    
                    new Character { Name = "Zefram Cochrane", Bio = "Inventor of the first Warp Drive.", CharacterId = 16 },
                    
                    new Character { Name = "Q", Bio = "Member of the Q Continuum. Q is the reason the Borg now know about humanity.", CharacterId = 17 },

                    new Character { Name = "Sarek", Bio = "Ambassador of Vulcan and father of Spock", CharacterId = 18 }
                );

            builder.Entity<TrekEvent>()
                .HasData(
                    new TrekEvent { Date = 1986, Description = "The crew of the USS Enterprise return back to Earth after their voyage to save Spock, only to find that an alien life-form probing Earth. Earth is destroyed, forcing the crew to find a way to travel back in time to prevent Earth's destruction.", TrekEventId = 1 },

                    new TrekEvent { Date = 2026, Description = "World War III starts on Earth. Eco-Terrorists attack the world. 37 Million people die.", TrekEventId = 2 },

                    new TrekEvent { Date = 2032, Description = "The creator of the warp drive: Zefram Cochrane, is born.", TrekEventId = 3 },

                    new TrekEvent { Date = 2053, Description = "World War III comes to an end. The world is in shambles after a long nuclear war. The aftermath of the war leaves a death rate of 600 Million people.", TrekEventId = 4 },

                    new TrekEvent { Date = 2063, Description = "Zefram Cochrane successful launches the first space craft using warp technology into space, The Pheonix. This craft is seen by a Vulcan ship passing by Earth's solar system. The Vulcans land on Earth to meet humanity and welcome them into and Zefram Cochrane is held in a high status. The events of this date are rewritten when the crew of the USS Enterprise C have to travel back in time to stop the Borg from destroying Earth and preventing the launch of the first craft. Captain Jean Luc Picard and his crew successfully thwart the Borg and help Zefram Cochrane launch his.", TrekEventId = 5 },

                    new TrekEvent { Date = 2079, Description = "Earth is finally recovering from the nuclear war.", TrekEventId = 6 },

                    new TrekEvent { Date = 2119, Description = "Zefram Cochrane sets off from his home on Alpha Centauri on an adventure. The world, never hearing back from him again presumes that he is dead.", TrekEventId = 7 },

                    new TrekEvent { Date = 2156, Description = "Star of the Earth and Ramulan War", TrekEventId = 8 },

                    new TrekEvent { Date = 2160, Description = "Earth-Ramulan War comes to a close with the Battle of Cheron, which results in Earth inflicting a humiliating defeat to the Romulans. The Neutral Zone is then later established.", TrekEventId = 9 },

                    new TrekEvent { Date = 2161, Description = "The United Federation of Planets is founded by Earth, Tellar, Vulcan and Andoria.", TrekEventId = 10 },

                    new TrekEvent { Date = 2165, Description = "Sarek, Vulcan's future Ambassador and Spock's Father is born.", TrekEventId = 11 },

                    new TrekEvent { Date = 2222, Description = "Montgomery Scott is born.", TrekEventId = 12 },

                    new TrekEvent { Date = 2227, Description = "Leonard McCoy is born.", TrekEventId = 13 },

                    new TrekEvent { Date = 2230, Description = "Spock and Hikaru Sulu are born.", TrekEventId = 14 },

                    new TrekEvent { Date = 2233, Description = "James T. Kirk and Nyota Uhura is born.", TrekEventId = 15 },

                    new TrekEvent { Date = 2245, Description = "Pavel Chekov is born. The USS Enterprise, a Constitution class vessel is launched under the command of Robert April, on a five-year mission of exploration.", TrekEventId = 16 },

                    new TrekEvent { Date = 2250, Description = "The USS Enterprise is refitted and renamed NCC-1701. It is launched on a second five-year mission under the command of Captain Christopher Pike.", TrekEventId = 17 },

                    new TrekEvent { Date = 2266, Description = "James T Kirk is appointed to Captain of the USS Enterprise NCC-1701. Montgomery Scott 'Scotty' is appointed Chief Engineer. Leonard McCoy 'Bones' is appointed Chief Medical Officer. Hikaru Sulu is appointed Helmsman. Nyota Uhura is appointed Chief Communications Officer. Pavel Chekov is appointed First Officer. Spock is appointed Chief Science Officer. The Enterprise sets out on a 5 year mission to chart out planets, explore and discover new life forms.", TrekEventId = 18 },

                    new TrekEvent { Date = 2270, Description = "The USS Enterprise returns home from it's 5 year journey. Captain Kirk is promoted to Admiral and the Enterprise undergoes maintenance and refitting.", TrekEventId = 19 },

                    new TrekEvent { Date = 2073, Description = "Admiral Kirk and a new crew take off on a new 5 year voyage in the newly refitted Enterprise. An unknown life-form named V'ger is causing destruction in Klingon space and is approaching the Earth. Kirk leads a mission to investigate and hopefully stop this threat. The threat is avoided but at great cost.", TrekEventId = 20 },

                    new TrekEvent { Date = 2279, Description = "The USS Enterprise UCC-1701 returns from it's voyage and is retired from active duty and is repurposed as a training vessel.", TrekEventId = 21 },

                    new TrekEvent { Date = 2285, Description = "Admiral Kirk oversees a training exercise aboard the Enterprise NCC-1701. Kahn, an old enemy of Kirk and the crew of the Enterprise takes a science vessel captive to get revenge against the crew of the Enterprise. Spock dies to save the crew of the Enterprise. Upon returning home the Enterprise is marked for complete decommission. After learning that Spock's spirit is still alive, the crew steal the Enterprise to return to the planet where Spock's body was laid to rest in hopes of reviving him. The Enterprise is destroyed to prevent it from landing in enemy hands. The crew of the Enterprise steal a Klingon Warbird vessel.", TrekEventId = 22 },

                    new TrekEvent { Date = 2286, Description = "The crew of the Enterprise returns home to find Earth getting destroyed. They travel back in time 100 years to try and prevent Earth's destruction. The newly refit USS Yorktown NCC-1717 is renamed the USS Enterprise NCC-1701-A and is launched on its maiden voyage with Admiral Kirk as it's Captain.", TrekEventId = 23 },

                    new TrekEvent { Date = 2287, Description = "A group of separatists take Federation Ambassadors of Earth, Klingon and Ramulas hostage on Nimbus III. Captain Kirk and the crew of the Enterprise is asked to intercept and save the hostages.", TrekEventId = 24 },

                    new TrekEvent { Date = 2293, Description = "The Klingon moon of Praxis is destroyed and the Klingon Empire decided to make peace with the Federation. A group of rebel Klingon who oppose this peace treaty, plan to attack the location of the peace treaty. Kirk under command of the Enterprise and Hikaru Sulu, newly appointed Captain of the USS Excelsior intervene and stop the attack. Admiral Kirk joins the newly built Enterprise NCC 1701-B and it's Captain, John Harriman, on a launching mission. The ship is struck by the Nexus and Kirk is lost, and presumed dead.", TrekEventId = 25 },

                    new TrekEvent {Date = 2305, Description = "Jean-Luc Picard is born in LaBarre, France on Earth", TrekEventId = 26 }, 
                    
                    new TrekEvent{Date = 2311, Description = "The Tomed Incident was an alleged terrorist attack by extremist Romulan Admiral Aventeer Vokar and 5 crewmates. Their ship impacted with an asteroid base in the Foxtrot center and and its quantum singularity drive caused a massive explosion disrupting space-time throughout the sector and wiping out dozens of asteroid bases and at least one starship, the USS Agamemnon. Thousands of lives were said to be lost. This incident led to the Klingon Empire siding with Federation Forces and the retreat of the Imperial Fleet. Two months later the Treaty of Alegron is signed banning the development of cloaking weapons in the Federation in exchange for the Star Empire's agreement to withdraw behind its borders and to recall all of its diplomatic missions and citizens.", TrekEventId = 27 }, 
                    
                    new TrekEvent{Date = 2324, Description = "Beverly Howard (Crusher) is born in Copernicus City, Luna", TrekEventId = 28 }, 
                    
                    new TrekEvent{Date = 2327, Description = "Jean-Luc Picard graduates from Starfleet Academy on Earth", TrekEventId = 29 }, 
                    
                    new TrekEvent {Date = 2333, Description = "Jean-Luc Picard becomes the Captain of the USS Stargazer.", TrekEventId = 30 }, 
                    
                    new TrekEvent {Date = 2335, Description = "Geordi La Forge is born in Mogadishu, Somalia. William T. Riker is born in Valdez, Alaska", TrekEventId = 31 }, 
                    
                    new TrekEvent {Date = 2336, Description = "Deanna Troi is born on Betazed.", TrekEventId = 32 }, 


                    new TrekEvent {Date=2337, Description = "Tasha yar is born in a failed Federation colony on Turkana IV", TrekEventId = 33 }, 
                    
                    new TrekEvent {Date = 2340, Description = "Worf, son of Mogh, is born on the Kilingon homeworld, Qo'noS", TrekEventId = 34 },

                    new TrekEvent { Date = 2395, Description = "Episode: All good things, TNG Series Finale, The future segment of the episode in which a retired Picard jumps through time as a continuation of humanities continuing trial by the Q continuum, to investigate a spatial anomaly while his friends question Picard's mental health", TrekEventId = 35 },

                    new TrekEvent { Date = 2387, Description = "A star in the Romulan Empire goes Supernova. Ambassador Spock attempts to counter the resulting shockwave using Red Matter, but is unable to save the planet Romulus from destruction. Spock and the Romulan mining ship Narada, commanded by Nero, are dragged into a black hole created by the Red Matter detonation and arrive in the past. Nero's arrival in 2233 and subsequent attack on the USS Kelvin creates the Kelvin Timeline.", TrekEventId = 36 },

                    new TrekEvent { Date = 2379, Description = "The events of Star Trek: Nemesis, Discovery of previously unknown Android named 'B-4', a less advanced android designed by Dr.Soong and brother to LT. Commander Data. Lt. Commander Data sacrifices his Life to save Picard and the crew of the Enterprise", TrekEventId = 37 },

                    new TrekEvent { Date = 2375, Description = "The events of Star Trek: Insurrection. Data is transferred to observe the Ba'ku on a joint mission between the Federation and the Son'a. While investigating a sudden malfunction of data that has jeopardized the safety of the observing task force, the Enterprise discovers that the Ba'ku planet has effectively made the inhabitants immortal, that the Son'a are seeking to exploit the resource to reverse their rapidly declining health and in doing so will destroy the planet in the process", TrekEventId = 38 },

                    new TrekEvent { Date = 2373, Description = "The events of Star Trek: First Contact. The Battle of Sector 001 occurs with a Starfleet Task Force engaging in a running battle with a Borg cube en route to Earth. The USS Defiant (NX-74205) is severely damaged but not destroyed, with the crew evacuated to the Enterprise. The USS Enterprise (NCC-1701-E) follows a Borg sphere through a temporal rift and events shift at that point to 2063.", TrekEventId = 39 },

                    new TrekEvent { Date = 2372, Description = "Sovereign-class USS Enterprise (NCC-1701-E) is launched under the command of Captain Jean-Luc Picard.", TrekEventId = 40 },

                    new TrekEvent { Date = 2371, Description = "The events of Star Trek Generations. The USS Enterprise (NCC-1701-D)'s stardrive section is destroyed by a warp core breach; the saucer section containing the crew makes a forced landing on Veridian III. The ship is subsequently declared a total loss. James T. Kirk reappears from the temporal continuum in which he had been since his disappearance in 2293. Kirk is killed on Veridian III. (Kirk is resurrected a month later in a subsequent story written by William Shatner, called The Return.)", TrekEventId = 41 },

                    new TrekEvent { Date = 2367, Description = "The Borg assimilate Captain Jean-Luc Picard; the Battle of Wolf 359 is fought 7.7 light years from Earth in Sector 001. The battle results in the loss of 39 Starfleet vessels and over 11,000 lives. With the task force lost, the Borg continue to Earth. Picard is rescued and the Borg cube is destroyed via the actions of the crew of the Enterprise-D.", TrekEventId = 42 },

                    new TrekEvent { Date = 2370 , Description = "The end of Star Trek: The Next Generation series.", TrekEventId = 43 },

                    new TrekEvent { Date = 2370, Description = "The beginning of Star Trek: The Next Generation. Jean-Luc Picard is appointed captain of the USS Enterprise(NCC-1701-D), William T. Riker is appointed first officer, Data is appointed second officer operations officer, Geordi La Forge is appointed helmsman and later chief engineer, Tasha Yar is appointed chief of security, Worf (son of Mogh) Rozhenko is appointed to chief of security after Yar's death, Beverly Crusher is appointed chief medical officer, Deanna Troi is appointed ship's, Wesley Crusher son of Beverley Crusher is later appointed to acting ensign.", TrekEventId = 44 },

                    new TrekEvent { Date = 2363, Description = "USS Enterprise (NCC-1701-D), the third Galaxy-class starship (following the Galaxy and Yamato) is launched from the Utopia Planitia shipyards in Mars orbit (under the command of Jean-Luc Picard), and becomes the Federation's new flagship.", TrekEventId = 45 },

                    new TrekEvent { Date = 2364, Description = "The Stargazer is later recovered in 2364.", TrekEventId = 46 },

                    new TrekEvent { Date = 2357, Description = "Worf is the first Klingon to enter Starfleet Academy.", TrekEventId = 47 },

                    new TrekEvent { Date = 2355 , Description = "The USS Stargazer is attacked by an unknown vessel (later discovered to be Ferengi in origin) in the Maxia Zeta system. Jean-Luc Picard wins the confrontation by devising a tactic which becomes known as the Picard Manoeuvre. However, due to damage suffered during the battle, the crew are forced to abandon ship.", TrekEventId = 48 },

                    new TrekEvent { Date = 2346, Description = "Worf's parents are killed by Romulans in the Khitomer massacre. Worf (age 6) is adopted by human parents.", TrekEventId = 49 },

                    new TrekEvent { Date = 2334 , Description = "The Enterprise-C, under the command of Captain Rachel Garrett, is destroyed defending a Klingon settlement on Narendra III under attack from Romulans. Due to the Enterprise-C's sacrifice, a new era of more open communication begins between the Federation and the Klingon Empire, leading to a formalized alliance.", TrekEventId = 50 }
            );
        }

        public DbSet<TrekEvent> TrekEvents { get; set; }
        public DbSet<Character> Characters { get; set; }
    }
}