using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab5.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Avilable { get; set; }
        public int Amount { get; set; }
        public string Description { get; set; }
    }
}