using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DigitalNameCard2.Services
{
    public interface ISQLServices
    {
        SQLite.SQLiteConnection getConnection();
             
        
    }
}
