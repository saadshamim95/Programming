using System.Collections.Generic;

namespace Object_Oriented
{
    public class Inventory
    {
        /// <summary>
        /// Gets or sets the rice list.
        /// </summary>
        /// <value>
        /// The rice list.
        /// </value>
        public List<Item> RiceList { get; set; }

        /// <summary>
        /// Gets or sets the pulse list.
        /// </summary>
        /// <value>
        /// The pulse list.
        /// </value>
        public List<Item> PulseList { get; set; }

        /// <summary>
        /// Gets or sets the wheat list.
        /// </summary>
        /// <value>
        /// The wheat list.
        /// </value>
        public List<Item> WheatList { get; set; }

        public class Item { 
            public string Name { get; set; }
            public int Weight { get; set; }
            public int Price { get; set; }
        }       
    }
}