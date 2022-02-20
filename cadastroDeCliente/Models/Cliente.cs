using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace cadastroDeCliente.Models
{
    public class Cliente
    {
        public Cliente() { }

        public string Nome { get; set; }

        public string Sexo { get; set; }

        public string Cpf { get; set; }

        public string Rg { get; set; }

        public string dataNascimento { get; set; }

        public string Endereco { get; set; }

        public static List<Cliente> Lista = new List<Cliente>();

        public List<Cliente> Todos()
        {
            return Cliente.Lista;
        }

        public void Salvar()
        {
            Cliente.Lista.Add(this);
        }
    }

}