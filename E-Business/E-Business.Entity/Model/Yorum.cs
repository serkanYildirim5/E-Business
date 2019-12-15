using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Business.Entity.Model
{
    public class Yorum:IEntity
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
        public string Comment { get; set; }
        public int BagliOlduguUrunId { get; set; }
        public virtual Urun YorumUrun { get; set; }
    }
}
