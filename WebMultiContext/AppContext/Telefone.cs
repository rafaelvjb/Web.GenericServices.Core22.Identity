using System;
using System.ComponentModel.DataAnnotations;

namespace WebMultiContext.AppContext
{
    public class Telefone
    {
        public Telefone()
        {
            TelefoneId = Guid.NewGuid();
        }

        [Key]
        public Guid TelefoneId { get; set; }

        [MaxLength(12)]
        public string Numero { get; set; }
    }
}