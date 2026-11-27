using Masrwof1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Masrwof1.Models
{
    public class Category : InterfaceId
    {
        public Guid Id { get; set; }
        public string? Name { get; set; } 
    }
}
