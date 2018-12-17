using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMultiContext.AppContext
{
    public class Pessoa : ISoftDelete
    {
        public Pessoa()
        {
            PessoaId = Guid.NewGuid();
        }

        [Key]
        public Guid PessoaId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }

        public Guid TelefoneId { get; set; }

        [ForeignKey("TelefoneId")]
        public Telefone Telefone { get; set; }


        public ICollection<Email> Emails { get; set; }



        [Required]
        public bool Deletado { get; set; }

    }
}