using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgra
{
    class History
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Coin1 { get; set; }
        public decimal Change1 { get; set; }
        public string Coin2 { get; set; }
        public decimal Change2 { get; set; }
    }
}
