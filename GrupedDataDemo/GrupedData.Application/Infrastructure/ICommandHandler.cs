using System;
using System.Collections.Generic;
using System.Text;

namespace GrupedData.Application.Infrastructure
{
    public interface ICommandHandler<in T>
    {
        void Handle(T command);
    }
}
