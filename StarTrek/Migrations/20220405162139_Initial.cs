using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StarTrek.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Bio = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "TrekEvents",
                columns: table => new
                {
                    TrekEventId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Date = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrekEvents", x => x.TrekEventId);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Bio", "Name" },
                values: new object[,]
                {
                    { 1, "Captain of the USS Enterprise NCC-1701", "James T. Kirk" },
                    { 18, "Ambassador of Vulcan and father of Spock", "Sarek" },
                    { 17, "Member of the Q Continuum. Q is the reason the Borg now know about humanity.", "Q" },
                    { 16, "Inventor of the first Warp Drive.", "Zefram Cochrane" },
                    { 14, "Chief Medical Officer on the USS Enterprise C", "Beverly Crusher" },
                    { 13, "Former Chief of Security on the USS Enterprise C", "Dana Yar" },
                    { 12, "Counselor on the USS Enterprise C", "Dianna Troi" },
                    { 11, "Commander on the USS Enterprise C", "William Riker" },
                    { 10, "Chief of Security on the USS Enterprise C", "Worf" },
                    { 15, "Ensign aboard the USS Enterprise-C, training to become a Starfleet Officer.", "Wesley Crusher" },
                    { 8, "Captain of the USS Enterprise C", "Jean Luc Picard" },
                    { 7, "First Officer on the USS Enterprise NCC-1701", "Pavel Chekov" },
                    { 6, "Chief Engineer on the USS Enterprise NCC-1701", "Montgomery Scott" },
                    { 5, "Chief Medical Officer on the USS Enterprise NCC-1701", "Leonard McCoy" },
                    { 4, "Chief Science Officer on the USS Enterprise NCC-1701", "Spock" },
                    { 3, "Chief Communications Officer on the USS Enterprise NCC-1701", "Nyota Uhura" },
                    { 2, "Helmsman on the USS Enterprise NCC-1701", "Hikaru Sulu" },
                    { 9, "Chief Engineer on the USS Enterprise C", "Geordi LeForge" }
                });

            migrationBuilder.InsertData(
                table: "TrekEvents",
                columns: new[] { "TrekEventId", "Date", "Description" },
                values: new object[,]
                {
                    { 35, 2395, "Episode: All good things, TNG Series Finale, The future segment of the episode in which a retired Picard jumps through time as a continuation of humanities continuing trial by the Q continuum, to investigate a spatial anomaly while his friends question Picard's mental health" },
                    { 34, 2340, "Worf, son of Mogh, is born on the Kilingon homeworld, Qo'noS" },
                    { 33, 2337, "Tasha yar is born in a failed Federation colony on Turkana IV" },
                    { 32, 2336, "Deanna Troi is born on Betazed." },
                    { 28, 2324, "Beverly Howard (Crusher) is born in Copernicus City, Luna" },
                    { 30, 2333, "Jean-Luc Picard becomes the Captain of the USS Stargazer." },
                    { 29, 2327, "Jean-Luc Picard graduates from Starfleet Academy on Earth" },
                    { 27, 2311, "The Tomed Incident was an alleged terrorist attack by extremist Romulan Admiral Aventeer Vokar and 5 crewmates. Their ship impacted with an asteroid base in the Foxtrot center and and its quantum singularity drive caused a massive explosion disrupting space-time throughout the sector and wiping out dozens of asteroid bases and at least one starship, the USS Agamemnon. Thousands of lives were said to be lost. This incident led to the Klingon Empire siding with Federation Forces and the retreat of the Imperial Fleet. Two months later the Treaty of Alegron is signed banning the development of cloaking weapons in the Federation in exchange for the Star Empire's agreement to withdraw behind its borders and to recall all of its diplomatic missions and citizens." },
                    { 36, 2387, "A star in the Romulan Empire goes Supernova. Ambassador Spock attempts to counter the resulting shockwave using Red Matter, but is unable to save the planet Romulus from destruction. Spock and the Romulan mining ship Narada, commanded by Nero, are dragged into a black hole created by the Red Matter detonation and arrive in the past. Nero's arrival in 2233 and subsequent attack on the USS Kelvin creates the Kelvin Timeline." },
                    { 31, 2335, "Geordi La Forge is born in Mogadishu, Somalia. William T. Riker is born in Valdez, Alaska" },
                    { 37, 2379, "The events of Star Trek: Nemesis, Discovery of previously unknown Android named 'B-4', a less advanced android designed by Dr.Soong and brother to LT. Commander Data. Lt. Commander Data sacrifices his Life to save Picard and the crew of the Enterprise" },
                    { 46, 2364, "The Stargazer is later recovered in 2364." },
                    { 39, 2373, "The events of Star Trek: First Contact. The Battle of Sector 001 occurs with a Starfleet Task Force engaging in a running battle with a Borg cube en route to Earth. The USS Defiant (NX-74205) is severely damaged but not destroyed, with the crew evacuated to the Enterprise. The USS Enterprise (NCC-1701-E) follows a Borg sphere through a temporal rift and events shift at that point to 2063." },
                    { 40, 2372, "Sovereign-class USS Enterprise (NCC-1701-E) is launched under the command of Captain Jean-Luc Picard." },
                    { 41, 2371, "The events of Star Trek Generations. The USS Enterprise (NCC-1701-D)'s stardrive section is destroyed by a warp core breach; the saucer section containing the crew makes a forced landing on Veridian III. The ship is subsequently declared a total loss. James T. Kirk reappears from the temporal continuum in which he had been since his disappearance in 2293. Kirk is killed on Veridian III. (Kirk is resurrected a month later in a subsequent story written by William Shatner, called The Return.)" },
                    { 42, 2367, "The Borg assimilate Captain Jean-Luc Picard; the Battle of Wolf 359 is fought 7.7 light years from Earth in Sector 001. The battle results in the loss of 39 Starfleet vessels and over 11,000 lives. With the task force lost, the Borg continue to Earth. Picard is rescued and the Borg cube is destroyed via the actions of the crew of the Enterprise-D." },
                    { 43, 2370, "The end of Star Trek: The Next Generation series." },
                    { 44, 2370, "The beginning of Star Trek: The Next Generation. Jean-Luc Picard is appointed captain of the USS Enterprise(NCC-1701-D), William T. Riker is appointed first officer, Data is appointed second officer operations officer, Geordi La Forge is appointed helmsman and later chief engineer, Tasha Yar is appointed chief of security, Worf (son of Mogh) Rozhenko is appointed to chief of security after Yar's death, Beverly Crusher is appointed chief medical officer, Deanna Troi is appointed ship's, Wesley Crusher son of Beverley Crusher is later appointed to acting ensign." },
                    { 45, 2363, "USS Enterprise (NCC-1701-D), the third Galaxy-class starship (following the Galaxy and Yamato) is launched from the Utopia Planitia shipyards in Mars orbit (under the command of Jean-Luc Picard), and becomes the Federation's new flagship." },
                    { 26, 2305, "Jean-Luc Picard is born in LaBarre, France on Earth" },
                    { 47, 2357, "Worf is the first Klingon to enter Starfleet Academy." },
                    { 48, 2355, "The USS Stargazer is attacked by an unknown vessel (later discovered to be Ferengi in origin) in the Maxia Zeta system. Jean-Luc Picard wins the confrontation by devising a tactic which becomes known as the Picard Manoeuvre. However, due to damage suffered during the battle, the crew are forced to abandon ship." },
                    { 38, 2375, "The events of Star Trek: Insurrection. Data is transferred to observe the Ba'ku on a joint mission between the Federation and the Son'a. While investigating a sudden malfunction of data that has jeopardized the safety of the observing task force, the Enterprise discovers that the Ba'ku planet has effectively made the inhabitants immortal, that the Son'a are seeking to exploit the resource to reverse their rapidly declining health and in doing so will destroy the planet in the process" },
                    { 25, 2293, "The Klingon moon of Praxis is destroyed and the Klingon Empire decided to make peace with the Federation. A group of rebel Klingon who oppose this peace treaty, plan to attack the location of the peace treaty. Kirk under command of the Enterprise and Hikaru Sulu, newly appointed Captain of the USS Excelsior intervene and stop the attack. Admiral Kirk joins the newly built Enterprise NCC 1701-B and it's Captain, John Harriman, on a launching mission. The ship is struck by the Nexus and Kirk is lost, and presumed dead." },
                    { 16, 2245, "Pavel Chekov is born. The USS Enterprise, a Constitution class vessel is launched under the command of Robert April, on a five-year mission of exploration." },
                    { 23, 2286, "The crew of the Enterprise returns home to find Earth getting destroyed. They travel back in time 100 years to try and prevent Earth's destruction. The newly refit USS Yorktown NCC-1717 is renamed the USS Enterprise NCC-1701-A and is launched on its maiden voyage with Admiral Kirk as it's Captain." },
                    { 1, 1986, "The crew of the USS Enterprise return back to Earth after their voyage to save Spock, only to find that an alien life-form probing Earth. Earth is destroyed, forcing the crew to find a way to travel back in time to prevent Earth's destruction." },
                    { 2, 2026, "World War III starts on Earth. Eco-Terrorists attack the world. 37 Million people die." },
                    { 3, 2032, "The creator of the warp drive: Zefram Cochrane, is born." },
                    { 4, 2053, "World War III comes to an end. The world is in shambles after a long nuclear war. The aftermath of the war leaves a death rate of 600 Million people." },
                    { 5, 2063, "Zefram Cochrane successful launches the first space craft using warp technology into space, The Pheonix. This craft is seen by a Vulcan ship passing by Earth's solar system. The Vulcans land on Earth to meet humanity and welcome them into and Zefram Cochrane is held in a high status. The events of this date are rewritten when the crew of the USS Enterprise C have to travel back in time to stop the Borg from destroying Earth and preventing the launch of the first craft. Captain Jean Luc Picard and his crew successfully thwart the Borg and help Zefram Cochrane launch his." },
                    { 6, 2079, "Earth is finally recovering from the nuclear war." },
                    { 7, 2119, "Zefram Cochrane sets off from his home on Alpha Centauri on an adventure. The world, never hearing back from him again presumes that he is dead." },
                    { 8, 2156, "Star of the Earth and Ramulan War" },
                    { 9, 2160, "Earth-Ramulan War comes to a close with the Battle of Cheron, which results in Earth inflicting a humiliating defeat to the Romulans. The Neutral Zone is then later established." },
                    { 10, 2161, "The United Federation of Planets is founded by Earth, Tellar, Vulcan and Andoria." },
                    { 24, 2287, "A group of separatists take Federation Ambassadors of Earth, Klingon and Ramulas hostage on Nimbus III. Captain Kirk and the crew of the Enterprise is asked to intercept and save the hostages." },
                    { 11, 2165, "Sarek, Vulcan's future Ambassador and Spock's Father is born." },
                    { 13, 2227, "Leonard McCoy is born." },
                    { 14, 2230, "Spock and Hikaru Sulu are born." },
                    { 15, 2233, "James T. Kirk and Nyota Uhura is born." },
                    { 49, 2346, "Worf's parents are killed by Romulans in the Khitomer massacre. Worf (age 6) is adopted by human parents." },
                    { 17, 2250, "The USS Enterprise is refitted and renamed NCC-1701. It is launched on a second five-year mission under the command of Captain Christopher Pike." },
                    { 18, 2266, "James T Kirk is appointed to Captain of the USS Enterprise NCC-1701. Montgomery Scott 'Scotty' is appointed Chief Engineer. Leonard McCoy 'Bones' is appointed Chief Medical Officer. Hikaru Sulu is appointed Helmsman. Nyota Uhura is appointed Chief Communications Officer. Pavel Chekov is appointed First Officer. Spock is appointed Chief Science Officer. The Enterprise sets out on a 5 year mission to chart out planets, explore and discover new life forms." },
                    { 19, 2270, "The USS Enterprise returns home from it's 5 year journey. Captain Kirk is promoted to Admiral and the Enterprise undergoes maintenance and refitting." },
                    { 20, 2073, "Admiral Kirk and a new crew take off on a new 5 year voyage in the newly refitted Enterprise. An unknown life-form named V'ger is causing destruction in Klingon space and is approaching the Earth. Kirk leads a mission to investigate and hopefully stop this threat. The threat is avoided but at great cost." },
                    { 21, 2279, "The USS Enterprise UCC-1701 returns from it's voyage and is retired from active duty and is repurposed as a training vessel." },
                    { 22, 2285, "Admiral Kirk oversees a training exercise aboard the Enterprise NCC-1701. Kahn, an old enemy of Kirk and the crew of the Enterprise takes a science vessel captive to get revenge against the crew of the Enterprise. Spock dies to save the crew of the Enterprise. Upon returning home the Enterprise is marked for complete decommission. After learning that Spock's spirit is still alive, the crew steal the Enterprise to return to the planet where Spock's body was laid to rest in hopes of reviving him. The Enterprise is destroyed to prevent it from landing in enemy hands. The crew of the Enterprise steal a Klingon Warbird vessel." },
                    { 12, 2222, "Montgomery Scott is born." },
                    { 50, 2334, "The Enterprise-C, under the command of Captain Rachel Garrett, is destroyed defending a Klingon settlement on Narendra III under attack from Romulans. Due to the Enterprise-C's sacrifice, a new era of more open communication begins between the Federation and the Klingon Empire, leading to a formalized alliance." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "TrekEvents");
        }
    }
}
