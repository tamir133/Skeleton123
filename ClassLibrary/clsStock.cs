using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public int StockID { get; set; }
        public string StockName { get; set; }
        public int StockQuantity { get; set; }
        public int StockTotalSold { get; set; }
        public DateTime DateAdded { get; set; }
        public decimal Price { get; set; }
        public bool StockAvailable { get; set; }
    }
}