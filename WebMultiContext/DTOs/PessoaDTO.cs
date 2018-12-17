using GenericServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WebMultiContext.AppContext;

namespace WebMultiContext.DTOs
{
    public class PessoaDto : ILinkToEntity<Pessoa>, ISoftDelete
    {
        public PessoaDto()
        {
            PessoaId = Guid.NewGuid();
            
        }

        [HiddenInput]
        [ReadOnly(true)]
        public Guid PessoaId { get; set; }

        [MaxLength(50)]
        [Required]
        public string Nome { get; set; }

        [HiddenInput]
        [ReadOnly(true)]
        public Guid TelefoneId { get; set; }
        
        public TelefoneDto Telefone { get; set; }

        public ICollection<EmailDto> Emails { get; set; }

        [HiddenInput]
        [Required]
        public bool Deletado { get; set; }
    }
}
