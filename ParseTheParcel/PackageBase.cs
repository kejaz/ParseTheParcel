using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ParseTheParcel
{
    public class PackageBase
    {
        protected string packageName { get; set; }
        protected double packageCost { get; set; }

        public string PackageName
        {
            get
            {
                return packageName;
            }
        }
        public double PackageCost
        {
            get
            {
                return packageCost;
            }
        }
    }
}
