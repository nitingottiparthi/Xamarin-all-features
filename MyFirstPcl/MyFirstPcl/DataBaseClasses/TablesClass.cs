using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPcl.DataBaseClasses
{
    public class TablesClass
    {
        public class MyFirstTable
        {
            [PrimaryKey]
            public string name { get; set; }
            [MaxLength(20)]
            public string cource { get; set; }
            
        }
    }
}
