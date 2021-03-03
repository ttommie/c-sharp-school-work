using System;

/*
 * Programmer: Tommie
 * Date: 03/02/2021
 * Inst Class: Ch04Receipt
 * Data Members: Receipt ID | Customer ID | Item ID | Date Of Purchase | Customer Name | Customer Address | Customer Phone # | Item Desc | Quantity Purchased | Unit Price
 */

namespace ATHCh04Ex05_receipt
{
    class Ch04Receipt
    {
        //INST VARIABLES 
        int receiptNum,
            customerNum,
            itemNum,
            quantityPurchased;

        string dateOfPurchase,
            customerName,
            customerAddress,
            customerPhoneNum,
            itemDesc;

        double unitPrice;


        //CONSTRUCTORS 

        public Ch04Receipt()
        {

        }

        public Ch04Receipt(int receiptID, string receiptDate, int customerID, int itemID, string itemDescription, double unitPricing, int totalQuantity)
        {
            receiptNum = receiptID;
            dateOfPurchase = receiptDate;
            customerNum = customerID;
            itemNum = itemID;
            itemDesc = itemDescription;
            unitPrice = unitPricing;
            quantityPurchased = totalQuantity;
        }

        public Ch04Receipt(int receiptID, string receiptDate, int customerID, string cusName, string cusAddress, int itemID, string itemDescription, double unitPricing, int totalQuantity)
        {
            receiptNum = receiptID;
            dateOfPurchase = receiptDate;
            customerNum = customerID;
            customerName = cusName;
            customerAddress = cusAddress;
            itemNum = itemID;
            itemDesc = itemDescription;
            unitPrice = unitPricing;
            quantityPurchased = totalQuantity;
        }

        public Ch04Receipt(int receiptID, string receiptDate, int customerID, string cusName, string cusAddress, string cusPhoneNum, int itemID, string itemDescription, double unitPricing, int totalQuantity)
        {
            receiptNum = receiptID;
            dateOfPurchase = receiptDate;
            customerNum = customerID;
            customerName = cusName;
            customerAddress = cusAddress;
            customerPhoneNum = cusPhoneNum;
            itemNum = itemID;
            itemDesc = itemDescription;
            unitPrice = unitPricing;
            quantityPurchased = totalQuantity;
        }


        //PROPERTIES 

        public int ReceiptNum
        {
            get
            {
                return receiptNum;
            }
            set
            {
                receiptNum = value;
            }
        }

        public int CustomerNum
        {
            get
            {
                return customerNum;
            }
            set
            {
                customerNum = value;
            }
        }

        public int ItemNum
        {
            get
            {
                return itemNum;
            }
            set
            {
                itemNum = value;
            }
        }

        public int QuantityPurchased
        {
            get
            {
                return quantityPurchased;
            }
            set
            {
                quantityPurchased = value;
            }
        }

        public string DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }
            set
            {
                dateOfPurchase = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }
            set
            {
                customerName = value;
            }
        }

        public string CustomerAddress
        {
            get
            {
                return customerAddress;
            }
            set
            {
                customerAddress = value;
            }
        }

        public string CustomerPhoneNum
        {
            get
            {
                return customerPhoneNum;
            }
            set
            {
                customerPhoneNum = value;
            }
        }

        public string ItemDesc
        {
            get
            {
                return itemDesc;
            }
            set
            {
                itemDesc = value;
            }
        }

        public double UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                unitPrice = value;
            }
        }


        public double TotalPrice()
        {
            return unitPrice * quantityPurchased;
        }


        public override string ToString()
        {
            return "----------------------------------------------\n" +
                   $"{"Reciept ID:",-2} {receiptNum}\n" +
                   $"{"Date of Purchase:",-2} {dateOfPurchase}\n" +
                   $"{"Customer ID:",-2} {customerNum}\n" +
                   $"{"Customer Name:",-2} {customerName}\n" +
                   $"{"Customer Address:",-2} {customerAddress}\n" +
                   $"{"Customer Phone #:",-2} {customerPhoneNum}\n" +
                   $"{"Item ID:",-2} {itemNum}\n" +
                   $"{"Item Description:",-2} {itemDesc:C}\n" +
                   $"{"Quantity Purchased:",-2} {quantityPurchased}\n" +
                   $"{"Unit Price:",-2} {unitPrice:C}\n" +
                   $"{"Total:",-2} {TotalPrice():C}\n" +
                   "----------------------------------------------";
        }
    }
}