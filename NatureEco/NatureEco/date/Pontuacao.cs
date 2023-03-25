using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace NatureEco.date
{
    public class Pontuacao
    {
        [PrimaryKey]
        public string Email { get; set; }
        public string Username {get;set;}
        public decimal pontuação { get; set; }

        
    
    }
}
