using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using DigitalNameCard2.Model;

namespace DigitalNameCard2.Services
{
    public class DataAccess
    {
        SQLite.SQLiteConnection dbConnection;
        public DataAccess()
        {
            dbConnection = DependencyService.Get<Services.ISQLServices>().getConnection();
            dbConnection.CreateTable<Item>();
        }

        public List<Item> GetAllItem()
        {
            return dbConnection.Query<Item>("select * from [Item]");
        }

        public int SaveItem(Item I)
        {
            int result = dbConnection.Insert(I);
            return result;
        }

        public int DeleteItem(Item I)
        {
            return dbConnection.Delete(I);
        }

        public int EditItem(Item I)
        {
            return dbConnection.Update(I);
        }
    }
}
