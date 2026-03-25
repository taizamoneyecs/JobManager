using System;

public record FullName
{
	public string FirstName { get; }
    public string LastName { get; }
	
    public FullName(string firstName, string lastName)
	{
		if (string.IsNullOrWhiteSpace(firstName))
		{
			throw new ArgumentException("First name cannot be null or empty.", nameof(firstName));
		}
		if (string.IsNullOrWhiteSpace(lastName))
		{
			throw new ArgumentException("Last name cannot be null or empty.", nameof(lastName));
		}
		FirstName = firstName;
		LastName = lastName;
    }
    

	

}
