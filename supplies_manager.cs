class Supplies_Manager
{
    
}
class Supply_Item
{
    //Unique ID generated from Supplies_Manager
    private static int id;
    //Item name
    private static string name;
    //Item quantity
    private float qnty;
    //Item description
    private string description;

    /// <summary>
    /// Constructor for a Supply Item.
    /// </summary>
    /// <param name="item_id">Unique item ID</param>
    /// <param name="item_name">Item name</param>
    /// <param name="item_qnty">Item quantity</param>
    /// <param name="item_description">Item description</param>
    public void Supply_Item(int item_id, string item_name, float item_qnty, string item_description)
    {
        id = item_id;
        name = item_name
        qnty = item_qnty
        description = item_description
    }

    /// <summary>
    /// This method adjusts the quantity of item. Use a negative adjust to reduce qnty.
    /// </summary>
    /// <param name="adjust">Amount added to qnty</param>
    public void update_qnty(float adjust)
    {
        qnty += adjust
        if(qnty < 0)
        {
            qnty = 0
        }
    }

    public string ToString()
    {
        return name + "," + id + "," + qnty + "," + description
    }
}