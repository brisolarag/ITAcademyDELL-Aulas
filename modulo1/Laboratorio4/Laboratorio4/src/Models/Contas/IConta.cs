using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio4.src.Models.Contas
{
    public interface IConta
    {
        bool Depositar(double val);
        bool Sacar(double val);
        string Extrato();
    }
}