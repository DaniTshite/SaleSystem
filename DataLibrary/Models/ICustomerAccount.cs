namespace DataLibrary.Models
{
    public interface ICustomerAccount
    {
        int AccountId { get; set; }
        string CellPhone { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string IdNumber { get; set; }
        string LastName { get; set; }
        string PhysicalAddress { get; set; }
        string Gender { get; set; }
    }
}