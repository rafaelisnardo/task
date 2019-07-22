using FluentValidation;
using ddd.Domain.Entities;
using System;

namespace ddd.Service.Validators
{
    public class TaskValidator : AbstractValidator<Task>
    {
        public TaskValidator()
        {
            RuleFor(c => c)
                .NotNull()
                .OnAnyFailure(x =>
                {
                    throw new ArgumentNullException("Task não encontrada!");
                });

            RuleFor(c => c.Titulo)
                .NotEmpty().WithMessage("Informe um título para a task.")
                .NotNull().WithMessage("Informe um título para a task.");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Informe uma descrição para a task.")
                .NotNull().WithMessage("Informe uma descrição para a task.");
        }
    }
}
