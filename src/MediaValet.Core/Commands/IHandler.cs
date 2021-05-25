using System.Threading.Tasks;

namespace MediaValet.Core.Commands
{
    public interface IHandler<T> where T : ICommand
    {
        Task<ICommandResult> Handle(T command);
    }
}
