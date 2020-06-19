using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace Depednency.Project.Web.Example.Services
{
    public interface ISingletonOperation:IOperation
    {

    }
    public class SingletonOperation : ISingletonOperation
    {
        public Guid Id { get; }
        public SingletonOperation()
        {
            Id = Guid.NewGuid();
        }
    }

 
}
