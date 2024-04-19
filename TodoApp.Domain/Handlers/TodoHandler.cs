using Flunt.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Commands;
using TodoApp.Domain.Commands.Contracts;
using TodoApp.Domain.Entities;
using TodoApp.Domain.Handlers.Contracts;
using TodoApp.Domain.Repositories;

namespace TodoApp.Domain.Handlers
{
    public class TodoHandler :
        Notifiable,
        IHandler<CreateTodoCommand>
    {
        private readonly ITodoRepository _repository;
        public TodoHandler(ITodoRepository repository)
        {
            _repository = repository;
        }

        public ICommandResult Handle(CreateTodoCommand command)
        {
            // Fail Fast Validation
            command.Validate();
            if (command.Invalid)
                return new GenericCommandResult(false, "Ops, parece que sua tarefa está errada!", command.Notifications);

            // Gera o TodoItem
            var todo = new Todo(command.Title, command.User, command.Date);

            // Salva no banco
            _repository.Create(todo);

            // Retorna o resultado
            return new GenericCommandResult(true, "Tarefa salva", todo);
        }
    }
}
