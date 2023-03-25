using System;
using System.Collections.Generic;
using System.Text;

using SQLite;


namespace NatureEco.date
{
    public class userModel
    {
        [PrimaryKey,AutoIncrement]
        public string ID { get; set; }
        

        [Indexed]
        [MaxLength(25)]
        public string Username { get; set; }
        [MaxLength(30),Unique]
        public string Email { get; set; }
        public DateTime Date { get; set; }
        [MaxLength(12)]
        public string Password { get; set; }
        public string ProfilePic { get; set; }

    }
}
