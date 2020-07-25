using CqrsPatternInPractice.Common.Context.CQRS;
using System;

namespace CqrsPatternInPractice.Command
{
    public class CreateUserCommand: ICommand
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand>
    {
        public void Handle(CreateUserCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
