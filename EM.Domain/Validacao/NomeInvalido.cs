using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain.Validacao
{
    public class NomeInvalido : Exception
    {
        public NomeInvalido(string msg, Exception exception) : base(msg, exception) { }
    }
}
