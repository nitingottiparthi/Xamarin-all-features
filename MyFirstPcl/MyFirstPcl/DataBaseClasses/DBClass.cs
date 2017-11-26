using MyFirstPcl.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static MyFirstPcl.DataBaseClasses.TablesClass;

namespace MyFirstPcl.DataBaseClasses
{
    public class DBClass
    {
        static SQLiteConnection myCn = DependencyService.Get<ISqlite>().GetConnection();
        public static void CreateMyFirstTable()
        {
            bool res = CheckTable("MyFirstTable");
            if (res == false)
            {
                myCn.CreateTable<TablesClass.MyFirstTable>();
            }
        }
        
        public static bool CheckTable(string table_name)
        {
            SQLite.TableMapping tMap = new TableMapping(typeof(TablesClass));
            List<object> tables = myCn.Query(tMap, "Select * FROM sqlite_master where type = 'table' and name='" + table_name + "'", new object[1]);
            int count = tables.Count();
            if (count > 0)
                return true;
            else
                return false;
        }

        public static void insertIntoMyFirstTable(MyFirstTable mfTable)
        {
            var res = myCn.Query<TablesClass.MyFirstTable>("Select * from MyFirstTable where name ='" +mfTable.name+"'");
            if (res.Count() == 0)
            {
                myCn.Insert(mfTable);
            }
        }

        public static List<MyFirstTable> getFirstTableData()
        {            
            var data = myCn.Query<TablesClass.MyFirstTable>("Select * from MyFirstTable");
            return data;
        }

        public static void UpdateName(string name)
        {
            myCn.Query<TablesClass.MyFirstTable>("update MyFirstTable set name='"+name+"' where cource='Xamarin'");
        }

        public static void DeleteRecord(string name)
        {
            myCn.Query<TablesClass.MyFirstTable>("Delete from MyFirstTable where name = '"+ name +"'");//Delete * from MyFirstTable where name = 'Nagarjun'
        }
    }
}
