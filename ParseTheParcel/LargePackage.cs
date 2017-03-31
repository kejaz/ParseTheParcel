using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTheParcel
{
    class LargePackage : PackageBase
    {
        public LargePackage()
        {
            this.packageName = xmlReader.GetPackageName("LargePackage");
            this.packageCost = double.Parse(xmlReader.GetPackageCost("LargePackage"));
        }       
    }   
}   
