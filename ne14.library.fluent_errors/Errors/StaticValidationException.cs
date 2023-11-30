// <copyright file="StaticValidationException.cs" company="ne1410s">
// Copyright (c) ne1410s. All rights reserved.
// </copyright>

namespace ne14.library.fluent_errors.Errors;

using ne14.library.fluent_errors.Validation;

/// <summary>
/// Represents errors occuring during static validation.
/// </summary>
public class StaticValidationException : ValidatingException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StaticValidationException"/>
    /// class.
    /// </summary>
    /// <param name="invalidItems">Invalid items.</param>
    public StaticValidationException(params InvalidItem[] invalidItems)
        : base(invalidItems)
    { }
}