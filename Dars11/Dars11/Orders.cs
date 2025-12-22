namespace Dars11;

internal class Orders
{
    public Guid OrderId { get; set; }
    public string CustomerName { get; set; }
    public string OrderDate { get; set; }
    public decimal TotalPrice { get; set; }
    public bool IsDelivered { get; set; }
}
