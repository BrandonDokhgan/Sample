public class Person
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string StreetAddress { get; set; }
    public string City { get; set; }

    public Person()
    { }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void UpdateAddress(string address)
    {
        if (!StreetAddress.Equals(address) && !string.IsNullOrEmpty(address))
            StreetAddress = address;
    }

    
}