using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace cadastroDeCliente.Models
{
    public class Cliente
    {
        public Cliente() { }

        [Required]
        [StringLength(6, ErrorMessage ="Acima de 6")]
        public string Nome { get; set; }

        
        public string Sexo { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public string Rg { get; set; }

        [Required]
        public string DataNascimento { get; set; }

        [Required]
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