namespace MicroServiceEduOrder.Persistence.Model
{
    public class OrderLineEf
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public int OrderID { get; set; }
        

    }
}
