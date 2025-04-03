namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    public Table(int number)
    {
        this.Number = number;
    }

    public Order Order { get; set; }

    public int Number {get; set;}
    
    public bool IsOccupied {get; set;}

   
    private ArrayList order = new ArrayList();
    
    public void Occupy()
    {
        this.IsOccupied = true;
        this.Order = new Order();
    }

    public void Free()
    {
        this.IsOccupie = false;
        this.Order = null;
        
    }
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }
}