using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTheParcel
{
    static class PackageFactory
    {
        public static PackageBase Create(Dimensions dimension, double weight)
        {
            try
            {
                int smallLength = Int32.Parse(xmlReader.GetPackageDimension("SmallPackage", "Length"));
                int smallBredth = Int32.Parse(xmlReader.GetPackageDimension("SmallPackage", "Breadth"));
                int smallHeight = Int32.Parse(xmlReader.GetPackageDimension("SmallPackage", "Height"));
                int smallWeight = Int32.Parse(xmlReader.GetPackageWeight("SmallPackage"));

                int mediumLength = Int32.Parse(xmlReader.GetPackageDimension("MediumPackage", "Length"));
                int mediumBredth = Int32.Parse(xmlReader.GetPackageDimension("MediumPackage", "Breadth"));
                int mediumHeight = Int32.Parse(xmlReader.GetPackageDimension("MediumPackage", "Height"));
                int mediumWeight = Int32.Parse(xmlReader.GetPackageWeight("MediumPackage"));

                int largeLength = Int32.Parse(xmlReader.GetPackageDimension("LargePackage", "Length"));
                int largeBredth = Int32.Parse(xmlReader.GetPackageDimension("LargePackage", "Breadth"));
                int largeHeight = Int32.Parse(xmlReader.GetPackageDimension("LargePackage", "Height"));
                int largeWeight = Int32.Parse(xmlReader.GetPackageWeight("LargePackage"));


                if (dimension.Length > 0 &&  dimension.Length <= smallLength && dimension.Breadth > 0 && dimension.Breadth <= smallBredth && dimension.Height > 0 && dimension.Height <= smallHeight && weight <= smallWeight)
                {
                    return new SmallPackage();
                }
                if (dimension.Length > smallLength && dimension.Length <= mediumLength && dimension.Breadth > smallBredth && dimension.Breadth <= mediumBredth && dimension.Height > smallHeight && dimension.Height <= mediumHeight && weight <= mediumWeight)
                {
                    return new MediumPackage();
                }
                if (dimension.Length > mediumLength && dimension.Length <= largeLength && dimension.Breadth > mediumBredth && dimension.Breadth <= largeBredth && dimension.Height > 180 && dimension.Height <= 200 && weight <= largeWeight)
                {
                    return new LargePackage();
                }
                else
                {
                    return new NotAvaialbePackage();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
