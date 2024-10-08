﻿namespace FIAP.PhaseOne.Domain.ContactAggregate;

public class Address : EntityBase
{
    public Address(
        string street, 
        string number, 
        string complement, 
        string city, 
        string district, 
        string country, 
        string zipcode)
    {
        Street = street;
        Number = number;
        Complement = complement;
        City = city;
        District = district;
        Country = country;
        Zipcode = zipcode;
    }

    public string Street { get; private set; }
    public string Number { get; private set; }
    public string Complement { get; private set; }
    public string City { get; private set; }
    public string District { get; private set; }
    public string Country { get; private set; }
    public string Zipcode { get; private set; }
    public Contact Contact { get; set; }
    public Guid ContactId { get; private set; }
}