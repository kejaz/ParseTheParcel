﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParseTheParcelApp.ParseTheParcelService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="PackageBase", Namespace="http://schemas.datacontract.org/2004/07/ParseTheParcel")]
    [System.SerializableAttribute()]
    public partial class PackageBase : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ParseTheParcelService.IParceTheParcel")]
    public interface IParceTheParcel {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParceTheParcel/GetPackage", ReplyAction="http://tempuri.org/IParceTheParcel/GetPackageResponse")]
        ParseTheParcelApp.ParseTheParcelService.PackageBase GetPackage(int length, int breadth, int hight, int weight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParceTheParcel/GetPackage", ReplyAction="http://tempuri.org/IParceTheParcel/GetPackageResponse")]
        System.Threading.Tasks.Task<ParseTheParcelApp.ParseTheParcelService.PackageBase> GetPackageAsync(int length, int breadth, int hight, int weight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParceTheParcel/GetPackageName", ReplyAction="http://tempuri.org/IParceTheParcel/GetPackageNameResponse")]
        string GetPackageName(int length, int breadth, int hight, int weight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParceTheParcel/GetPackageName", ReplyAction="http://tempuri.org/IParceTheParcel/GetPackageNameResponse")]
        System.Threading.Tasks.Task<string> GetPackageNameAsync(int length, int breadth, int hight, int weight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParceTheParcel/GetPackageCost", ReplyAction="http://tempuri.org/IParceTheParcel/GetPackageCostResponse")]
        double GetPackageCost(int length, int breadth, int hight, int weight);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IParceTheParcel/GetPackageCost", ReplyAction="http://tempuri.org/IParceTheParcel/GetPackageCostResponse")]
        System.Threading.Tasks.Task<double> GetPackageCostAsync(int length, int breadth, int hight, int weight);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IParceTheParcelChannel : ParseTheParcelApp.ParseTheParcelService.IParceTheParcel, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ParceTheParcelClient : System.ServiceModel.ClientBase<ParseTheParcelApp.ParseTheParcelService.IParceTheParcel>, ParseTheParcelApp.ParseTheParcelService.IParceTheParcel {
        
        public ParceTheParcelClient() {
        }
        
        public ParceTheParcelClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ParceTheParcelClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ParceTheParcelClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ParceTheParcelClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ParseTheParcelApp.ParseTheParcelService.PackageBase GetPackage(int length, int breadth, int hight, int weight) {
            return base.Channel.GetPackage(length, breadth, hight, weight);
        }
        
        public System.Threading.Tasks.Task<ParseTheParcelApp.ParseTheParcelService.PackageBase> GetPackageAsync(int length, int breadth, int hight, int weight) {
            return base.Channel.GetPackageAsync(length, breadth, hight, weight);
        }
        
        public string GetPackageName(int length, int breadth, int hight, int weight) {
            return base.Channel.GetPackageName(length, breadth, hight, weight);
        }
        
        public System.Threading.Tasks.Task<string> GetPackageNameAsync(int length, int breadth, int hight, int weight) {
            return base.Channel.GetPackageNameAsync(length, breadth, hight, weight);
        }
        
        public double GetPackageCost(int length, int breadth, int hight, int weight) {
            return base.Channel.GetPackageCost(length, breadth, hight, weight);
        }
        
        public System.Threading.Tasks.Task<double> GetPackageCostAsync(int length, int breadth, int hight, int weight) {
            return base.Channel.GetPackageCostAsync(length, breadth, hight, weight);
        }
    }
}
