using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ParseTheParcel
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ParceTheParcel" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ParceTheParcel.svc or ParceTheParcel.svc.cs at the Solution Explorer and start debugging.
    public class ParseTheParcelPackage : IParceTheParcel
    {
        Dimensions dimension;
        double weight;
        public ParseTheParcelPackage()
        {
            
        }
        public ParseTheParcelPackage(Dimensions dimension, double weight)
        {
            this.dimension = dimension;
            this.weight = weight;
        }
        public ParseTheParcelPackage(int length,int breadth, int height, double weight)
        {
            this.dimension.Length = length;
            this.dimension.Breadth = breadth;
            this.dimension.Height = height;
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
        public PackageBase GetPackage(Dimensions dimension, int weight)
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
        public string GetPackageName(int length, int breadth, int hight, int weight)
        {
            try
            {
                return PackageFactory.Create(new Dimensions(length, breadth, hight), weight).PackageName;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public double GetPackageCost(int length, int breadth, int hight, int weight)
        {
            try
            {
                return PackageFactory.Create(new Dimensions(length, breadth, hight), weight).PackageCost;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public PackageBase GetPackage(int length, int breadth, int hight, int weight)
        {
            PackageBase package = null;
            try
            {
                return package = PackageFactory.Create(new Dimensions(length,breadth,hight), weight);
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
