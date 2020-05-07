using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspRestApiWorkshop.Models
{
    public class LinkedResourceBaseDto
    {
        public List<LinkDto> Links { get; set; } = new List<LinkDto>();
    }
}
