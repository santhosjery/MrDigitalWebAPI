using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel.ShowCase
{
    public class SliderImages
    {
        [Key]
        public int SliderId { get; set; }

        public string ImageDescription { get; set; }

        public string ImageName { get; set; }

        public string Remarks { get; set; }

        public byte Status { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }
    }
}
