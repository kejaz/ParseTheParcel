using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ParseTheParcel;

namespace ParseTheParcel
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IParceTheParcel" in both code and config file together.
    [ServiceContract]
    public interface IParceTheParcel
    {
        [OperationContract]
        PackageBase GetPackage(int length, int breadth, int hight, int weight);

        [OperationContract]
        string GetPackageName(int length, int breadth, int hight, int weight);

        [OperationContract]
        double GetPackageCost(int length, int breadth, int hight, int weight);
    }
}
