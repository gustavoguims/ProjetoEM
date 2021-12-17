using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Repository.Verificação
{
    public class MatriculaCadastrada : Exception
    {
        public MatriculaCadastrada(string msg, Exception exception) : base(msg, exception) { }
    }
}
