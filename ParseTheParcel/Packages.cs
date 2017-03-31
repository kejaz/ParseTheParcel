using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParseTheParcel;

namespace ParseTheParcel
{
    public class Packages : IParceTheParcel
    {
        Dimensions dimension;
        double weight;
        public Packages(Dimensions dimension, double weight)
        {
            this.dimension = dimension;
            this.weight = weight;
        }
        public PackageBase GetPackage()
        {
            PackageBase package = null;
            try
            {
                return package = PackageFactory.Create(dimension, weight);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                package = null;
            }
        }
    }
}
