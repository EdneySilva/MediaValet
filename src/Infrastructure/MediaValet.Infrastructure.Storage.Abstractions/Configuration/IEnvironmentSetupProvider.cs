using System;
using System.Collections.Generic;
using System.Text;

namespace MediaValet.Infrastructure.Storage.Abstractions.Configuration
{
    public interface IEnvironmentSetupProvider
    {
        void Apply();
    }
}
