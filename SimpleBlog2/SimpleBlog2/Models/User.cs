﻿using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleBlog2.Models
{
    public class User
    {
        public virtual int Id { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual String PasswordHash { get; set; }

        public virtual void SetPassword(string password)
        {
            PasswordHash = "IGNORE";
        }
    }
    public class UserMap:ClassMapping<User>
    {
        public UserMap()
        {
            Table("users");
            Id(x => x.Id, x => x.Generator(Generators.Identity));
            Property(x => x.Username, x => x.NotNullable(true));
            Property(x => x.Email, x => x.NotNullable(true));
            Property(x => x.PasswordHash, x =>
               {
                   x.NotNullable(true);
                   x.Column("password_hash");//isim tutmuyor büyük kücük mühim degil ama _ var
            });
        }


    }
}