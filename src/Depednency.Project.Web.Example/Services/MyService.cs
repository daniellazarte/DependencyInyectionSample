using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Depednency.Project.Web.Example.Services
{
    public interface IMyService
    {

    }
    public class MyService: IMyService
    {
        private readonly ISingletonOperation _singletonOperation;
        private readonly IScopedOperation _scopedOperation;
        private readonly ItransientOperation _transienoperation;

        public MyService(ISingletonOperation singletonOperation,IScopedOperation scopedOperation, ItransientOperation transienOperation)
        {
            _singletonOperation = singletonOperation;
            _scopedOperation = scopedOperation;
            _transienoperation = transienOperation;

        }
    }
}
