using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using u3ndahl.Models;

namespace u3ndahl.Data
{
    public class Data
    {
        Program Program1 = new Program()
        {
            title = "Alfons Elefanter",
            category = "Barn",
            time = 18
        };

        List<Program> kanal1 = new List<Program>();
    }
}