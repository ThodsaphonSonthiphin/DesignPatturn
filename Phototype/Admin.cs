using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Xml.Linq;

namespace Prototype
{
    public class Admin
    {
        public Admin()
        {
            RoleId = 2;
        }

        public Admin(Admin admin)
        {
            RoleId = 2;
            Username = admin.Username;
            Password = admin.Password;
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }

        public virtual Admin ShallowCopy()
        {
            return (Admin)this.MemberwiseClone();
        }

        public virtual Admin DeepCopy()
        {
            Admin clone = new Admin(this);
            return clone;
        }

        public override string ToString()
        {
            var myString = $"{nameof(this.Username)}:{this.Username} \n {nameof(this.Password)}:{Password} \n {nameof(RoleId)}:{RoleId} \n";

            return myString;
        }
    }

    
}