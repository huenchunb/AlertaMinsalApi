﻿namespace WebApiAlertaMinsal.Domain.Exceptions;

public class UnsupportedColourException(string code) : Exception($"Colour \"{code}\" is unsupported.");
