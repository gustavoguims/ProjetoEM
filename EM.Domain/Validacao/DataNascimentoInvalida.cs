using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain.Validacao
{
    public class DataNascimentoInvalida : Exception
    {
           public DataNascimentoInvalida(string msg, Exception exception) : base(msg, exception) { }
    }
}
