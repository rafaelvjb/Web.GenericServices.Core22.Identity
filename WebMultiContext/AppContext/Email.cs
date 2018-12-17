using System;
using System.ComponentModel.DataAnnotations;

namespace WebMultiContext.AppContext
{
    public class Email
    {
        [Key]
        public Guid EmailId { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(250)]
        public string Endereco { get; set; }

    }
}