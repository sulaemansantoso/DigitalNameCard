using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DigitalNameCard2.Model
{
   
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
