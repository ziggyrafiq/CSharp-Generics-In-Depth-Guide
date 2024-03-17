//The File Name is Program.cs

using GenericRepositoryEnterpriseExample;

using (var unitOfWork = new UnitOfWork(new YourDbContext()))
{
    // Example usage of the generic repository pattern
    var customerRepository = unitOfWork.Customers;

    // Add a new customer
    customerRepository.Add(new Customer { Name = "Lisa Smith" });

    // Update an existing customer
    var existingCustomer = customerRepository.GetById(1);
    existingCustomer.Name = "Tom Hallway";
    customerRepository.Update(existingCustomer);

    // Delete a customer
    customerRepository.Delete(2);

    // Save changes to the database
    unitOfWork.SaveChanges();
}