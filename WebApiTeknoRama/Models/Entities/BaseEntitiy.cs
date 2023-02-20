using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiTeknoRama.Models.Entities
{
    public class BaseEntitiy

    {
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}