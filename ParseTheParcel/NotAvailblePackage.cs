using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTheParcel
{
    class NotAvaialbePackage : PackageBase
    {
        public NotAvaialbePackage()
        {
            this.packageName = "Package Not Available";
            this.packageCost = 0;            
        }       
    }
}
