using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Model.Abtracts
{
 public interface IAudiable
    {
        DateTime CreatedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string MetaKeyword { set; get; }
        string UpdatedBy { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}
