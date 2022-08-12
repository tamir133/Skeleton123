using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mStockID;
        private string mStockName;
        private Int32 mStockQuantity;
        private Int32 mTotalSold;
        private DateTime mDateAdded;
        private decimal mPrice;
        private bool mAvailable;
            
        public Int32 StockID 
        {
            get
            {
                return mStockID;
            }
            set
            {
                mStockID = value;
            }
        }
        public string StockName
        {
            get
            {
                return mStockName;
            }
            set
            {
                mStockName = value;
            }

        } 
        public Int32 StockQuantity
        { 
            get
            {
                return mStockQuantity;
            }
            set
            {
                mStockQuantity = value;
            }
        
        }
        public Int32 StockTotalSold
        {
            get
            {
                return mTotalSold;
            }
            set
            {
                mTotalSold = value;
            }
        }
        public DateTime DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        public bool StockAvailable
        {
            get
            {
                return mAvailable;
            }
            set
            {
                mAvailable = value;
            }
        }

        public bool Find(int stockID)
        {
            {
                clsDataConnection DB = new clsDataConnection();
                DB.AddParameter("@StockID", StockID);
                DB.Execute("sproc_tblStock_FilterByStockID");
                if (DB.Count == 1)
                {
                    mStockID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                    mStockName = Convert.ToString(DB.DataTable.Rows[0]["StockName"]);
                    mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                    mAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["StockAvailable"]);
                    mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["Price"]);
                    mStockQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["StockQuantity"]);
                    mTotalSold = Convert.ToInt32(DB.DataTable.Rows[0]["TotalSold"]);

                    return true;
                }
                else
                {
                    return false;
                }
            }

        }  
    }
}