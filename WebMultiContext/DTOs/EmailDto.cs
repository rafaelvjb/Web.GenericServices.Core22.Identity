using GenericServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMultiContext.AppContext;

namespace WebMultiContext.DTOs
{
    public class EmailDto : ILinkToEntity<Email>
    {
        [HiddenInput]
        [ReadOnly(true)]
        public Guid EmailId { get; set; }

        [DataType(DataType.EmailAddress)]
        [MaxLength(250)]
        public string Endereco { get; set; }
    }
}
