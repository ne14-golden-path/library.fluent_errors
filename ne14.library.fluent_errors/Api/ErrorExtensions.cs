// <copyright file="ErrorExtensions.cs" company="ne1410s">
// Copyright (c) ne1410s. All rights reserved.
// </copyright>

namespace ne14.library.fluent_errors.Api;

using System;
using ne14.library.fluent_errors.Api.Models;
using ne14.library.fluent_errors.Errors;

/// <summary>
/// Error handling extensions.
/// </summary>
public static class ErrorExtensions
{
    /// <summary>
    /// Maps an error to a suggested http outcome.
    /// </summary>
    /// <param name="ex">The error.</param>
    /// <returns>The outcome.</returns>
    public static HttpErrorOutcome ToOutcome(this Exception ex)
    {
        var errorCode = (ex ?? throw new ArgumentNullException(nameof(ex))).ToErrorCode();
        var errorMessage = errorCode == 500 ? "An unexpected error occurred" : ex.Message;
        var invalidItems = ex is ValidatingException valEx ? valEx.InvalidItems : null;

        return new HttpErrorOutcome(
            errorCode,
            new HttpErrorBody(ex.GetType().Name, errorMessage, invalidItems));
    }

    /// <summary>
    /// Maps exceptions to http error codes.
    /// </summary>
    /// <param name="ex">The exception.</param>
    /// <returns>An http error code.</returns>
    public static int ToErrorCode(this Exception ex) => ex switch
    {
        StaticValidationException _ => 400,
        AuthorisationException _ => 403,
        ResourceMissingException _ => 404,
        ServiceOrchestrationException _ => 422,
        _ => 500,
    };
}