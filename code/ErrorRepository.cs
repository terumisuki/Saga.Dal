using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Errors;

namespace Saga.Dal
{
    public class ErrorRepository : IErrorRepository
    {
        public void LogError(string error)
        {
            throw new NotImplementedException();
        }

        public void LogError(Exception e)
        {
            throw new NotImplementedException();
        }
    }
}
