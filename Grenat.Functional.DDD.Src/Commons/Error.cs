﻿namespace Grenat.Functional.DDD;

public record Error
{
    public string Message { get; }
    public string Code { get; }
    public string TypeName { get; }

    public Error(string message) : this(message, string.Empty) { }

    public Error(string message, string code)
    {
        Message = message;
        TypeName = GetType().Name;
        Code = code;
    }
}

public static class ErrorExtensions
{
    public static string Concat(this IEnumerable<Error> errors, string separator = ", ")
    {
        return errors.Concat(separator);
    }
}
