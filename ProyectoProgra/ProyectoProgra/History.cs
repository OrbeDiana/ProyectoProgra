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
        public string coin1 { get; set; }
        public decimal change1 { get; set; }
        public string coin2 { get; set; }
        public decimal change2 { get; set; }
    }
}
