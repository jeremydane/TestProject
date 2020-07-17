using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestProject.Model
{
    public class Token
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string access_token { get; set; }
        public string error_descrption { get; set; }
        public DateTime expire_date { get; set; }

        public Token() { }
        //public Token(string access_token, string error_description, DateTime expire_date)
        //{
        //    this.access_token = access_token;
        //    this.error_descrption = error_descrption;
        //    this.expire_date = expire_date;
        //}
    }
}
