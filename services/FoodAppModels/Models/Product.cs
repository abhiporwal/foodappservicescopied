using System;
using System.Collections.Generic;
using System.Text;

namespace FoodAppModels.Models
{
   public class Product
    {     /// <summary>
          /// DpetNo
          /// </summary>
        public int ProductID { get; set; }
        /// <summary>
        /// DName
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Location
        /// </summary>
        public string Location { get; set; }
    }
}
