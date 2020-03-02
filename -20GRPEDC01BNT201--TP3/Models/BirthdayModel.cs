using System;
using System.ComponentModel.DataAnnotations;

namespace _20GRPEDC01BNT201__TP3.Models
{
    public class BirthdayModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        [DataType(DataType.Date)]
        public DateTime Data { get; set; }
    }
}
