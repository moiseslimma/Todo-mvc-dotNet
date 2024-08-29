using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Todo.Validators;

namespace Todo.Models
{
    public class Todos
    {
        public int Id { get; set; }
        
        [Display(Name = "Título")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres")]
        public string Title { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }
        
        [Display(Name = "Data de Entrega")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DisplayFormat(DataFormatString="{0:yyyy-MM-dd}", ApplyFormatInEditMode=true)]
        [FutureOrPresent]
        public DateOnly Deadline { get; set; }
        public DateOnly? FinishedAt { get; set; }

        public void Finish()
        {
            FinishedAt = DateOnly.FromDateTime(DateTime.Now);
        }
    }
}