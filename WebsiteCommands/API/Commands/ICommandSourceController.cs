﻿using OpenMod.API.Commands;
using OpenMod.API.Ioc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebsiteCommands.API.Commands
{
    [Service]
    public interface ICommandSourceController
    {
        Task<IReadOnlyCollection<ICommandRegistration>> GetCommandsAsync();

        Task AddCommandAsync(ICommandRegistration registration);

        Task InvalidateAsync();
    }
}
