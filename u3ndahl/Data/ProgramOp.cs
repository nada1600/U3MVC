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

        private List<Program> programs = new List<Program>
            {
                new Program {id=1, title="Indiana Jones", category ="Movie", channel=3, time=20.00 },
                new Program {id=1, title="Walking dead", category ="Serie", channel=3, time=20.00 }
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
        public Program GetP()
        {
            Program p = new Program()
            {
                title = "Hej",
                channel = 1
            };
            //if (p.channel == 1)
            //{
            //    return 
            //}

            return p;
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
