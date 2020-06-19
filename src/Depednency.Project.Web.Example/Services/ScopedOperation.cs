using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Depednency.Project.Web.Example.Services
{
    public interface IScopedOperation : IOperation
    {

    }
    public class ScopedOperation : IScopedOperation
    {
        public Guid Id { get; }

        public ScopedOperation() 
        {
            Id = Guid.NewGuid();
        
        } 

    }
}
