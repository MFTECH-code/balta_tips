// Conversão implícita (Conversão que o próprio C# consegue fazer sozinho)
// int x = 100;
// double y = x; // 100.00

// Conversão explícita (Casting)
// double z = 100.0;
// int h = (int) z; // 100

var phone = new Phone
{
    CountryCode = "55",
    Area = "11",
    Number = "9999999"
};
Console.WriteLine(phone);

var telefone = "123";
telefone = phone;
Console.WriteLine(telefone);

telefone = "55 11 12345568";
phone = telefone;
Console.WriteLine(phone);

public class Phone
{ 
    public string CountryCode { get; set; }
    public string Area { get; set; }
    public string Number { get; set; }

    public Phone(string countryCode, string area, string number)
    {
        CountryCode = countryCode;
        Area = area;
        Number = number;
    }

    public Phone()
    {
    }

    public static implicit operator string(Phone phone)
        => $"+{phone.CountryCode} ({phone.Area}) {phone.Number}";

    public static implicit operator Phone(string phone)
    {
        var data = phone.Split(" ");
        return new Phone(data[0], data[1], data[2]);
    }

    public override string ToString()
    {
        return $"+{CountryCode} ({Area}) {Number}";
    }
}