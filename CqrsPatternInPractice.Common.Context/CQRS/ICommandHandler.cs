using System;
using System.Collections.Generic;
using System.Text;

namespace CqrsPatternInPractice.Common.Context.CQRS
{
    public interface ICommand
    {
    }
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        void Handle(TCommand command);
    }
}
