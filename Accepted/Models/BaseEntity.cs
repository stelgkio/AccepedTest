using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Accepted.Models
{
    public abstract class BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 100)]
        public DateTime CreatedDate { get; protected set; }
        [Column(Order = 101)]
        public DateTime UpdatedDate { get; set; }
        [Column(Order = 102)]
        public DateTime? DeletedDate { get; set; }
        [Column(Order = 103)]
        public bool IsDeleted { get; set; } = false;

     
        public BaseEntity()
        {
          
            CreatedDate = DateTime.UtcNow;
            SetUpdatedDate();
        }

        protected virtual void SetUpdatedDate()
            => UpdatedDate = DateTime.UtcNow;
        protected virtual void SetDeleted()
        {
            UpdatedDate = DateTime.UtcNow;
            IsDeleted = true;
        }                

        public string Error {
            get; protected set;
        }
    }
}
