using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWork.Contracts.Dto
{
    public class BusinessEntityForCreateDto
    {
        public Guid Rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
