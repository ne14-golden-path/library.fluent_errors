// <copyright file="TestModelValidator.cs" company="ne1410s">
// Copyright (c) ne1410s. All rights reserved.
// </copyright>

namespace ne14.library.fluent_errors.tests.Validation;

using ne14.library.fluent_errors.Validation;
using FluentValidation;

public class TestModelValidator : FluentValidatorBase<TestModel>
{
    protected override void DefineModelValidity()
    {
        this.RuleFor(m => m.Name)
            .MinimumLength(3)
            .WithMessage("Gimme a name");

        this.RuleFor(m => m.Magnitude)
            .GreaterThan(12)
            .WithMessage("Gimme some magnitude");
    }
}
