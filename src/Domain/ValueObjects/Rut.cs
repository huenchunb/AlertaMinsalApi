namespace WebApiAlertaMinsal.Domain.ValueObjects;

public class Rut : ValueObject
{
    public string Value { get; }

    private Rut(string value)
    {
        if (!IsValid(value))
        {
            throw new UnsupportedRutException(value);
        }

        Value = value;
    }

    public static Rut Create(string value)
    {
        return new Rut(value);
    }

    private static bool IsValid(string rut)
    {
        rut = rut.Replace(".", "").Replace("-", "");

        if (rut.Length is < 8 or > 9)
        {
            return false;
        }

        string dv = rut.Substring(rut.Length - 1, 1);
        string rutWithoutDv = rut[..^1];

        int totalSum = 0;
        int multiplier = 2;

        for (int i = rutWithoutDv.Length - 1; i >= 0; i--)
        {
            totalSum += int.Parse(rutWithoutDv[i].ToString()) * multiplier;
            multiplier = multiplier == 7 ? 2 : multiplier + 1;
        }

        int remainder = totalSum % 11;
        string calculatedDv = (11 - remainder).ToString();
        if (calculatedDv == "11") calculatedDv = "0";
        if (calculatedDv == "10") calculatedDv = "K";

        return calculatedDv.Equals(dv, StringComparison.OrdinalIgnoreCase);
    }

    public string GetRutWithoutDv()
    {
        return Value[..^1].Replace("-", string.Empty).Replace(".", string.Empty);
    }

    public char GetDv()
    {
        return Value[^1];
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
