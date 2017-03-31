using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Web.Configuration;

namespace ParseTheParcel
{
    class SmallPackage : PackageBase
    {
        public SmallPackage()
        {
            this.packageName = xmlReader.GetPackageName("SmallPackage");
            this.packageCost = double.Parse(xmlReader.GetPackageCost("SmallPackage"));
        }       
    }
}
