using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate_task.Models
{
    internal class Medicine
    {
        private static int _id;
        internal int? medicinee;

        public int Id { get; }
        public string Name { get; set; }
        public int Price { get; set; }
        public double Count { get; set; }
        public bool IsDeleted { get; set; } = false;
        public Medicine()
        {
            _id++;
            this.Name = Name;
            this.Price = Price;
            this.Count = Count;
            this.Id = Id;
        }
        public int Sell()
        {
            Count -= 1;
            return 0;
            
        }
        
        public  void ShowInfo()
        {
            Console.WriteLine($"Name:{Name}-Price:{Price}-Count:{Count}-Id:{Id}");
        }
        
    }
}

