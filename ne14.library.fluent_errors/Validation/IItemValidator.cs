// <copyright file="IItemValidator.cs" company="ne1410s">
// Copyright (c) ne1410s. All rights reserved.
// </copyright>

namespace ne14.library.fluent_errors.Validation;

using ne14.library.fluent_errors.Errors;

/// <summary>
/// Validates an item.
/// </summary>
/// <typeparam name="TItem">The item type.</typeparam>
public interface IItemValidator<in TItem>
{
    /// <summary>
    /// Validates an item.
    /// </summary>
    /// <param name="item">The item to validate.</param>
    /// <exception cref="ValidatingException">Invalid data.</exception>
    public void AssertValid(TItem item);
}