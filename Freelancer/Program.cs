

using Freelancer.Entities;
using Freelancer.Services;

var anotherCustomer = new Customer
{
    Id = Guid.NewGuid(),
    CreatedOn = DateTime.Now,
    FirstName = "Celal",
    LastName = "Karahan",
    PhoneNumber = "190-719-0719"
};

NotepadService notepadService = new();
notepadService.SaveToNotepad(anotherCustomer);
string customerData = notepadService.GetOnNotepad("C:\\Users\\Celal\\source\\repos\\YetGenAkbankJump\\Freelancer\\Database\\Customers.txt");

string[] splittedLines = customerData.Split('\n\r', StringSplitOptions.RemoveEmptyEntries);

List<Customer> customers = new();

foreach (string line in splittedLines)
{
    Customer customer = new();
    customer.SetValueCSV(line);
    customers.Add(customer);
}
