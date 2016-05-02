using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CreateDatabaseWithSqlitenet
{
    class Users
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime BirthDate { get; set; }

        public string BabyName { get; set; }

        public override string ToString()
        {
            return string.Format("[Person: ID={0}, Username={1}, Password={2}]", ID, UserName, Password);
        }
        
    }
    
}
