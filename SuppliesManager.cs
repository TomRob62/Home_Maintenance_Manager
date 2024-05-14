/**
Thomas Roberts
May 13, 2024

Description: This program contains the support classes for Home Maintenance
Manager application
*/

namespace HomeMaintenanceManager
{
    class SupplyItem
    {
        private static int id;
        private string name;
        private float qnty;
        private string description;

        public SupplyItem(int itemID, string itemName, float itemQnty, string itemDescription)
        {
            id = itemID;
            name = itemName;
            qnty = itemQnty;
            description = itemDescription;
        }
    }
}