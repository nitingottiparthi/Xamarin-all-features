using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyFirstPcl.Interfaces;
using SQLite;
using System.IO;
using Xamarin.Forms;
using MyFirstPcl.Droid;

[assembly:Dependency(typeof(SQLite_Android))]
namespace MyFirstPcl.Droid
{
    public class SQLite_Android : ISqlite
    {
        public SQLite_Android()
        {

        }
        public SQLiteConnection GetConnection()//void, non_void
        {
            var file_name = "MyFirstDB.db3";
            var doc_path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var myDBPath = Path.Combine(doc_path,file_name);
            File.Create(myDBPath);
            var Myconnection = new SQLiteConnection(myDBPath);
            return Myconnection;
        }
    }
}