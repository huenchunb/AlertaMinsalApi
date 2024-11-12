using System.Net.Mail;

namespace WebApiAlertaMinsal.Domain.ValueObjects;

public class Email : ValueObject
{
    public string Value { get; }

    public Email(string value)
    {
        try
        {
            var mailAddress = new MailAddress(value);
            Value = mailAddress.Address;
        }
        catch (FormatException)
        {
            throw new UnsupportedEmailException(value);
        }   
    }
    
    public static Email Create(string value)
    {
        return new Email(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
