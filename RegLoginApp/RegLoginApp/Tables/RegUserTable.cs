using System;
using System.Collections.Generic;
using System.Text;

namespace RegLoginApp.Tables
{
    //It will hold multiple users data
    public class RegUserTable
    {

        public Guid UserId          { get; set; }
        public string UserName      { get; set; }
        public string Password      { get; set; }
        public string Email         { get; set; }
        public string PhoneNumber   { get; set; }
        
        

    }
}
