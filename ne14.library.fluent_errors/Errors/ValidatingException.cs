// <copyright file="ValidatingException.cs" company="ne1410s">
// Copyright (c) ne1410s. All rights reserved.
// </copyright>

namespace ne14.library.fluent_errors.Errors;

using System.Collections.Generic;
using ne14.library.fluent_errors.Validation;

/// <summary>
/// Represents errors occuring during validation.
/// </summary>
public class ValidatingException : ServiceOrchestrationException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ValidatingException"/>
    /// class.
    /// </summary>
    /// <param name="invalidItems">Invalid items.</param>
    public ValidatingException(params InvalidItem[] invalidItems)
        : base("Invalid instance received.")
    {
        this.InvalidItems = invalidItems;
    }

    /// <summary>
    /// Gets the invalid items.
    /// </summary>
    public IList<InvalidItem> InvalidItems { get; }
}