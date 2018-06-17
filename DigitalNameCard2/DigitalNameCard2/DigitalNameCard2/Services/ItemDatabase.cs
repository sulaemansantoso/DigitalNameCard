using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using DigitalNameCard2;

namespace DigitalNameCard2.Services
{
    public class ItemDatabase
    {
        public static ItemDatabase database;
        public static ItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ItemDatabase(DependencyService.Get<ISQLServices>().GetLocalFilePath("TodoSQLite.db3"));
                }
                return database;
            }
        }

        public ItemDatabase(string dbPath)
        {
            SQLiteAsyncConnection database;
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<DigitalNameCard2.Model.Item>().Wait();
        }
    }
}
