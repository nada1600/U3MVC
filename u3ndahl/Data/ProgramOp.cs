using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u3ndahl.Models;

namespace u3ndahl.Data
{
    public class ProgramOp
    {
        List<Program> programList = new List<Program>();
        

        private List<Program> programs = new List<Program>
            {
                new Program {id=1, title="Alfons Elefanter", category ="Barn", channel=1, length=30, date= new DateTime(2017,11,29, 18,00,00), description="Sjuåriga Alfons vill verkligen ha en elefant eller två. Men hans pappa tycker inte han är stor nog. Det är svårt att verka ansvarstagande med en låtsaskompis, men Alfons har en plan..." },
                new Program {id=2, title="Fem myror är fler än fyra elefanter", category ="Barn", channel=1, length=120, date= new DateTime(2017,11,29, 18,30,00), description="Pedagogiskt barnprogram från -73." },
                new Program {id=3, title="Femte elementet", category ="Film", channel=1, length=120, date= new DateTime(2017,11,29, 20,30,00), description="I en avlägsen framtid dras en taxichaufför i New York in i en kamp mellan gott och ont när en vacker ung kvinna dyker upp i hans liv. Tillsammans med kvinnan tar han upp kampen för att sammanföra de fem elementen som ska rädda jorden från undergång." },
                new Program {id=4, title="Nyheterna", category ="Nyheter", channel=1, length=60, date= new DateTime(2017,11,29,22,30,00), description="Nyheterna sänder aktuella nyheter varje dag under hela året." },

                new Program {id=5, title="The Goonies", category ="Film", channel=2, length=90, date= new DateTime(2017,11,29, 18,00,00), description="Mikey och Brandon Walsh är två bröder vars familj är på väg att flytta från sin stad Astoria. Orsaken till detta är att man planerat att riva ner hela staden för att bygga en golfbana, om man inte lyckas få ihop tillräckligt med pengar för att stoppa projektet, vilket är väldigt tvivelaktigt. Men Mikey hittar av en slump en skattkarta som leder till den ökända piraten One-Eyed Willys skatter, och det leder till att han, hans vänner och bror ger sig på att hitta dessa. De hittar ingången till en grotta som leder till skatterna. Problemet är bara att den ligger under en stängd restaurang som numera hyser en efterlyst kriminell familj, Frattelli. De vill inte gärna att deras gömställe läcker ut, samtidigt som de mer än gärna vill ha tag i de där rikedomarna själva, så de ger sig efter ungdomsgänget. En jakt på skatten börjar; kommer Goonies att hitta skatten först så de kan rädda sin stad?" },
                new Program {id=6, title="Stargate", category ="Film", channel=2, length=90, date= new DateTime(2017,11,29, 19,30,00), description="In 1928, in Egypt, a strange device is found by an expedition. In the present days, the outcast linguist Dr. Daniel Jackson is invited by a mysterious woman to decipher an ancient hieroglyph in a military facility. Soon he finds that the device was developed by an advanced civilization and opens a portal to teletransport to another planet. Dr. Jackson is invited to join a military team under the command of Colonel Jonathan 'Jack' O'Neil that will explore the new world. They find a land that recalls Egypt and humans in a primitive culture that worship and are slaves to Ra, the God of the Sun. But soon they discover the secret of the mysterious stargate. Written by Claudio Carvalho, Rio de Janeiro, Brazil" },
                new Program {id=7, title="Death Proof", category ="Film", channel=2, length=90, date= new DateTime(2017,11,29, 21,00,00),description="Tre tjejkompisar är ute och firar en födelsedag, och får uppmärksamhet av den före detta stuntmannen Mike. När de lämnar baren står han beredd med sin specialbyggda stuntbil som han använder för att förfölja och döda unga tjejer med." },
                new Program {id=8, title="Indiana Jones", category ="Film", channel=2, length=120, date= new DateTime(2017,11,29, 22,30,00), description="Äventyraren Indiana Jones får i uppdrag att finna den sägenomspunna arken, med resterna av stentavlorna med de tio budorden. Hitler har skickat sina hejdukar efter skatten och det blir en våldsam kapplöpning efter arken." },

                new Program {id=9, title="Morgonfotöljen", category ="Nyheter", channel=3, length=120, date= new DateTime(2017,11,29, 09,00,00), description="En härlig morgonstund med Janis och Lemmy där det diskuteras allt från himmel till jord." },
                new Program {id=10, title="Loppisfyndarna", category ="Serie", channel=3,  length=60, date= new DateTime(2017,11,29, 11,00,00), description="Följ med på en spännande jakt bland gamla prylar!" },
                new Program {id=11, title="Sveriges bästa hemmabagare", category ="Serie", length=60, channel=3, date= new DateTime(2017,11,29,19,00,00), description="Under några veckor kämpar tolv personer från hela Sverige om att vinna baktävlingen Sveriges bästa hemmabagare. Deltagarna tvingas bevisa en noggrann jury om sina bakningsfärdigheter i allt från tårtor och bakelser till bröd och pajer. Programledare är Tilde de Nadia Dahlgren som själv passar på att lära sig mer om olika traditionella bakverk och ingredienser. Svårighetsgraden höjs desto längre tävlingen fortgår och den juryn, besående av mästerbagare av olika slag missar inte en endaste detalj när de bedömer bakverken." },
                new Program {id=12, title="Mytkrossarna", category ="Serie", channel=3, length=60, date= new DateTime(2017,11,29,20,00,00), description="Hur svårt är det att hitta en nål i en höstack, egentligen? Kan vatten som droppar på din panna göra dig galen? Dessa och en rad andra frågor och myter ställs på prov för att reda ut vilka som är faktiskt är sanna och vilka som bara är påhittade."},

                new Program {id=13, title="Vad är PI", category ="Kunskap", channel=4, length=60, date= new DateTime(2017,11,29,19,00,00), description="Intressant program som handlar om PI." },
                new Program {id=14, title="Databasteknik för nybörjare", category ="Kunskap", channel=4, length=60, date= new DateTime(2017,11,29,20,00,00), description="Ett underhållande program där du får lära dig, precis som titeln på programmet lyder, grunderna i databasteknik. Följ med i en värld av spännande SQL-frågor och öka dina kunskaper om lagring med hjälp av databas." },
                new Program {id=15, title="Nyhetssändning", category ="Nyheter", channel=4, length=30, date= new DateTime(2017,11,29,21,00,00), description="Dagens nyhetssändning." },
                new Program {id=16, title="Liftarens guide till galaxen", category ="Film", length=120, channel=4, date= new DateTime(2017,11,29,21,30,00), description="Bara sekunder innan jorden blir demolerad av ett utomjordiskt byggföretag dras jordmänniskan Arthur Dent av planeten av sin kompis Ford Prefect, en journalist som håller på att skriva en ny version av Liftarens Guide till Galaxen." }

            };

        public List<Program> GetPrograms()
        {
            return programs;
        }

        public List<Program>GetUnique()
        {
            var DistinctItems = programs.GroupBy(x => x.category).Select(y => y.First());

            foreach (var item in DistinctItems)
            {
                programList.Add(item);
            }
            return DistinctItems.ToList();
        }


        public List<Program> GetChannel(int channel)
        {
            var result = programs.FindAll(c => c.channel == channel);
            //var result = programs.FirstOrDefault(c => c.channel == channel);
            return result;
        }

        public List<Program> GetCategory(string category)
        {
            var result = programs.FindAll(p => p.category == category);
            //if (category == "Nyheter")
            //{
            //    //return n.ToList();
            //    return result;
            //}
            //else if (category == "Barn")
            //{
            //    return result;
            //}
            //else if (category == "Film")
            //{
            //    return result;
            //}
            //else if (category == "Kunskap")
            //{
            //    return result;
            //}
            //else
            return result;

        }
        public Program GetNavCategory(string category)
        {
            //var n = programs.Where(p => p.category == "Nyheter");
            var result = programs.FirstOrDefault(p => p.category == category);
            return result;

        }


        public Program GetProgramById(int? id)
        {
            var result = programs.FirstOrDefault(i => i.id == id);
            return result;
        }


        //FL1
        public Program GetProgram()
        {
            Program p = new Program()
            {
                title = "Hej",
                channel = 1
            };
            //if (p.channel == 1)
            //{
            //    return p; 
            //}

            return p;
        }


        public List<Program> GetC(int channel)
        {
            if (channel == 1)
            {
                var result1 = programs.FindAll(c => c.channel == channel);
                return result1;
            }
            else if (channel == 2)
            {
                var result2 = programs.FindAll(c => c.channel == channel);
                return result2;
            }
            else if (channel == 3)
            {
                var result3 = programs.FindAll(c => c.channel == channel);
                return result3;
            }
            else if (channel == 4)
            {
                var result4 = programs.FindAll(c => c.channel == channel);
                return result4;
            }
            else
                return null;

        }



        //List<Program> kanal1 = new List<Program>();

        //public void GetProgram()
        //{
        //    foreach (Program p in kanal1)
        //    {
        //        return k1 = ("title = {0}, category = {1}, time = {3}", p.title, p.category, p.time);
        //    }
        //}


        //public string DayOfWeek(DayOfWeek day)
        //{
        //    switch(day)
        //    {
        //        case (DayOfWeek.Synday)
        //            return "Söndag";
        //        case (DayOfWeek.Monday)
        //            return "Måndag";
        //        case (DayOfWeek.Tuesday)
        //            return "Tisdag";
        //        case (DayOfWeek.Wednesday)
        //            return "Onsdag";
        //        case (DayOfWeek.Thursday)
        //            return "Torsdag";
        //        case (DayOfWeek.Friday)
        //            return "Fredag";
        //        case (DayOfWeek.Saturday)
        //            return "Lördag";
        //    }
        //    return "Fredag";

        //}


    }
    
    
    //programList.Add(Program1);
    
}
