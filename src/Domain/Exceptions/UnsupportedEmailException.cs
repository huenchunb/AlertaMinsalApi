namespace WebApiAlertaMinsal.Domain.Exceptions;

public class UnsupportedEmailException(string email) : Exception($"El email {email} no es válido");
