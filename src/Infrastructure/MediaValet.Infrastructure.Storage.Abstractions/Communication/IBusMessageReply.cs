using MediaValet.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MediaValet.Infrastructure.Storage.Abstractions.Communication
{
    public interface IBusMessageReply
    {
        Task<Confirmation> WaitResponseAsync(string key, TimeSpan timeout);

        Task SendConfirmation(Confirmation confirmation);
    }
}
