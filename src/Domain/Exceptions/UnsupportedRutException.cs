namespace WebApiAlertaMinsal.Domain.Exceptions;

public class UnsupportedRutException(string value) : Exception($"El rut {value} no es válido");
