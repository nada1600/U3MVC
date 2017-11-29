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
                new Program {id=1, title="Alfons Elefanter", category ="Barn", channel=1, time=18.00, date= new DateTime(2017,11,29) },
                new Program {id=2, title="Fem myror är fler än fyra elefanter", category ="Barn", channel=1, time=18.30, date= new DateTime(2017,11,29) },
                new Program {id=3, title="Femte elementet", category ="Film", channel=1, time=20.30, date= new DateTime(2017,11,29) },
                new Program {id=4, title="Nyheterna", category ="Nyheter", channel=1, time=20.30, date= new DateTime(2017,11,29) },

                new Program {id=5, title="The Goonies", category ="Film", channel=2, time=18.00, date= new DateTime(2017,11,29) },
                new Program {id=6, title="Stargate", category ="Film", channel=2, time=19.30, date= new DateTime(2017,11,29) },
                new Program {id=7, title="Death Proof", category ="Film", channel=2, time=21.00, date= new DateTime(2017,11,29) },
                new Program {id=8, title="Indiana Jones", category ="Film", channel=2, time=20.30, date= new DateTime(2017,11,29) },

                new Program {id=9, title="Morgonfotöljen", category ="Nyheter", channel=3, time=9.00, date= new DateTime(2017,11,29) },
                new Program {id=10, title="Loppisfyndarna", category ="Serie", channel=3, time=11.00, date= new DateTime(2017,11,29) },
                new Program {id=11, title="Sveriges bästa hemmabagare", category ="Serie", channel=3, time=19.00, date= new DateTime(2017,11,29) },
                new Program {id=12, title="Mytkrossarna", category ="Serie", channel=3, time=20.00, date= new DateTime(2017,11,29) },

                new Program {id=13, title="Vad är PI", category ="Kunskap", channel=4, time=19.00, date= new DateTime(2017,11,29) },
                new Program {id=14, title="Databasteknik för nybörjare", category ="Kunskap", channel=4, time=20.00, date= new DateTime(2017,11,29) },
                new Program {id=15, title="Nyhetssändning", category ="Nyheter", channel=4, time=21.00, date= new DateTime(2017,11,29) },
                new Program {id=16, title="Liftarens guide till galaxen", category ="Film", channel=4, time=21.30, date= new DateTime(2017,11,29) }

            };

        public List<Program> GetPrograms()
        {
            return programs;
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
            return result;
        }

        
        public Program GetProgramById(int id)
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
