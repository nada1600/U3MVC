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

        //FL1
        private List<Program> programs = new List<Program>()
        {
            new Program()
            {
                title = "Hejsan",
                channel = 2
            },
            new Program()
            {
                title = "Hejhopp",
                channel = 1
            }
        };
        //------------------------------

        //Programobjekt
        Program Program1 = new Program()
        {
            title = "Alfons Elefanter",
            category = "Barn",
            channel = 1,
            time = 18.00
        };

        Program Program2 = new Program()
        {
            title = "Liftarens Guide till Galaxen",
            category = "SciFi",
            channel = 2,
            time = 19.00
        };

        Program Program3 = new Program()
        {
            title = "Nyheter",
            category = "Nyheter",
            channel = 3,
            time = 18.00
        };

        Program Program4 = new Program()
        {
            title = "Hela Sveriges bagare",
            category = "Underhållning",
            channel = 4,
            time = 19.00
        };
        //-----------------------------

        private List<Program> programss = new List<Program>
            {
                new Program {id=1, title="Alfons Elefanter", category ="Barn", channel=1, time=18.00 },
                new Program {id=1, title="Fem myror är fler än fyra elefanter", category ="Barn", channel=1, time=18.30 },
                new Program {id=1, title="Femte elementet", category ="Film", channel=1, time=20.30 },
                new Program {id=1, title="Nyheterna", category ="Nyheter", channel=1, time=20.30 },

                new Program {id=1, title="The Goonies", category ="Film", channel=2, time=18.00 },
                new Program {id=1, title="Stargate", category ="Film", channel=2, time=19.30 },
                new Program {id=1, title="Death Proof", category ="Film", channel=2, time=21.00 },
                new Program {id=1, title="Indiana Jones", category ="Film", channel=2, time=20.30 },

                new Program {id=1, title="Morgonfotöljen", category ="Nyheter", channel=3, time=9.00 },
                new Program {id=1, title="Loppisfyndarna", category ="Serie", channel=3, time=11.00 },
                new Program {id=1, title="Sveriges bästa hemmabagare", category ="Serie", channel=3, time=19.00 },
                new Program {id=1, title="Mytkrossarna", category ="Serie", channel=3, time=20.00 },

                new Program {id=1, title="Vad är PI", category ="Kunskap", channel=4, time=19.00 },
                new Program {id=1, title="Databasteknik för nybörjare", category ="Kunskap", channel=4, time=20.00 },
                new Program {id=1, title="Nyhetssändning", category ="Nyheter", channel=4, time=21.00 },
                new Program {id=1, title="Liftarens guide till galaxen", category ="Film", channel=4, time=21.30 }

            };

        //public Program GetProgram()
        //{
        //    return "1";
        //}
        

        public List<Program> GetList()
        {
            foreach (Program p in programList)
            {
                programList.Add(Program1);
                programList.Add(Program2);
                programList.Add(Program3);
                programList.Add(Program4);
            }
            return programList;
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

        public List<Program> GetPrograms() 
        {
            
            return programs;

        }



        //List<Program> kanal1 = new List<Program>();

        //public void GetProgram()
        //{
        //    foreach (Program p in kanal1)
        //    {
        //        return k1 = ("title = {0}, category = {1}, time = {3}", p.title, p.category, p.time);
        //    }
        //}





    }
    
    
    //programList.Add(Program1);
    
}
