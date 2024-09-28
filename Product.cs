using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInventoryManagementSystem
{
    public class Product
    {
        //Fields
        private int id;
        private string name = string.Empty;
        private string? description;

        private int maxItemsInStock = 0;

        private UnitType unitType;
        private int amountInStock = 0;
        private bool isBelowStockTreshold = false;

        //Properties
        public int Id
        {
            get { return id; }
            set {  id = value; }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value.Length > 50 ? value[..50] : value;
            }
        }
        public string? Description
        {
            get { return description; }
            set
            {
                if (value == null)
                    description = string.Empty;
                else
                {
                    description = value.Length > 400 ? value[..400] : value;
                }
            }

        }
        public UnitType UnitType { get; set; }

        public int AmountInStock { get; set; }
        public bool IsBelowStockTreshold { get; set; }

        //Constructors
        public Product(int id,string name)
        {
            Id= id;
            Name= name;
        }

        public Product(int id) : this(id, string.Empty)
        { }

        public Product (int id, string name, string? description, UnitType unitType, int maxAmountInStock)
        {
            Id=id;
            Name= name;
            Description= description;
            UnitType= unitType;
            this.maxItemsInStock = maxAmountInStock;
        }

        //Methods






    }
}
