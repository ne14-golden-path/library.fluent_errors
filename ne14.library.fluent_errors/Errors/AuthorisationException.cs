// <copyright file="AuthorisationException.cs" company="ne1410s">
// Copyright (c) ne1410s. All rights reserved.
// </copyright>

namespace ne14.library.fluent_errors.Errors;

/// <summary>
/// Authorisation errors.
/// </summary>
public class AuthorisationException : ServiceOrchestrationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AuthorisationException"/> class.
    /// </summary>
    /// <param name="message">A description of the exception.</param>
    public AuthorisationException(string? message = null)
        : base(message ?? "Forbidden")
    { }
}