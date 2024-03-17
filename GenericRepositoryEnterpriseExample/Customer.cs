//The File Name is Customer.cs
//Normallay we place our entity in Model folder but for this example we have place it int he root folder.
namespace GenericRepositoryEnterpriseExample;
public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; } = string.empty;
    public string EmailAddress { get; set; } = string.empty;
    public bool EmailAddressConfirmed { get; set; } = false;
    public string AddressLine1 { get; set; }= string.empty;
    public string AddressLine2 { get; set; }= string.empty;
    public string City { get; set; }
    public string Region { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }
    public string PhoneNumber { get; set; }
    public bool PhoneNumberConfirmed { get; set; }=false;
            
}
