using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp20
{
    class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section { get; set; }

        public Admin(string username,string password,string section,bool isSuperadmin):base(username,password)
        {
            Section = section;
            IsSuperAdmin = isSuperadmin;
        }

        public virtual string Showinfo()
        {
            return $"Username: {Username}, Password: {Password}, Section: {Section},{( IsSuperAdmin ? "Super Admindir" : "Super Admin deyil")}";
        }
    }
}
