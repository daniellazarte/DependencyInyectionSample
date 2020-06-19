using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Depednency.Project.Web.Example.Services
{
    public interface ItransientOperation : IOperation
    {

    }
    public class TransientOperation:ItransientOperation
    {
        public Guid Id { get; }

        public TransientOperation()
        {
            Id = Guid.NewGuid();

        }
    }
}
