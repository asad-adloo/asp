
namespace CRM.Common
{
    public enum UserRoles {
        Administrator,
        Saler,
        Customer
    }


    public enum InvoiceStatus
    {
        Draft,
        Init,
        Final
    }

    public enum ItemType
    {
        Persentage,
        FixPrice,
        PerItem
    }

    public enum ProductUnit { 
        Kg,
        Pack
    }

    public enum ProductStatus
    {
        Active,
        DeActive,
        Delete,
        OutOfStock,
        
    }

    public enum ActiveAndDeleteStatus { 
        Active,
        Delete
    }
}
