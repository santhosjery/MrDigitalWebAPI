using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.WishList
{
    public class WishLists
    {
        [Key]
        public int WishListId { get; set; }

        public byte? Type { get; set; }

        public int VideoId { get; set; }

        public int UserId { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
