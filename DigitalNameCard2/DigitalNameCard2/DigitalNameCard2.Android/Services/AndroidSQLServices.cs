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
using Xamarin.Forms;
using Xamarin;
using DigitalNameCard2.Services;
using SQLite;
using System.IO;

namespace DigitalNameCard2.Droid.Services
{
    public class AndroidSQLServices : ISQLServices
    {
        public SQLiteConnection getConnection()
        {
            var fileName = "DigitalNameCard.db3";
            string documentPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentPath, fileName);
            if (!File.Exists(path)) { File.Create(path); }
            var conn = new SQLite.SQLiteConnection(path, true);
            return conn;
        }

       
    }
}