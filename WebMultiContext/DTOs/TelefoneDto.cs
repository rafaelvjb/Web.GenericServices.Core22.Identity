using GenericServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using WebMultiContext.AppContext;

namespace WebMultiContext.DTOs
{
    public class TelefoneDto : ILinkToEntity<Telefone>
    {
        public TelefoneDto()
        {
            TelefoneId = Guid.NewGuid();
        }

        [HiddenInput]
        [ReadOnly(true)]
        public Guid TelefoneId { get; set; }

        [MaxLength(12)]
        [DataType(DataType.PhoneNumber)]
        public string Numero { get; set; }
    }
}