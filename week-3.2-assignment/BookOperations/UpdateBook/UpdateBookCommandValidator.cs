﻿using FluentValidation;
using week_3_assignment.BookOperations.DeleteBook;

namespace week_3_assignment.BookOperations.UpdateBook
{
	public class UpdateBookCommandValidator : AbstractValidator<UpdateBookCommand>
	{
        public UpdateBookCommandValidator()
        {
            RuleFor(command => command.bookId).GreaterThan(0);
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.Title).NotEmpty().MinimumLength(4).NotNull();
        }
    }
}
