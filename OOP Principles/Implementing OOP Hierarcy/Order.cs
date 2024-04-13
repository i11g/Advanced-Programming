using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseOopHierarchy
{
    public class Order
    { 
        private List <MenuItem> _items;

        public void AddItem (MenuItem item)
        {
            this._items.Add(item);
        }
    }
}
