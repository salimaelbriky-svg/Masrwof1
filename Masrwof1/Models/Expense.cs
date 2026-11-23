using Masrwof1.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace Masrwof1.Models
{
    public class Expense : InterfaceId
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date {  get; set; }
        public string Category { get; set; }
    }
}
