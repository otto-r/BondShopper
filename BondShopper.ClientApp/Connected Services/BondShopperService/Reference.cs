﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BondShopper.ClientApp.BondShopperService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BondShopperService.IBondService")]
    public interface IBondService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBondService/GetBonds", ReplyAction="http://tempuri.org/IBondService/GetBondsResponse")]
        System.Collections.Generic.List<BondShopper.Model.Bond> GetBonds();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBondService/GetBonds", ReplyAction="http://tempuri.org/IBondService/GetBondsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BondShopper.Model.Bond>> GetBondsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBondService/AddBond", ReplyAction="http://tempuri.org/IBondService/AddBondResponse")]
        void AddBond(BondShopper.Model.Bond bond);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBondService/AddBond", ReplyAction="http://tempuri.org/IBondService/AddBondResponse")]
        System.Threading.Tasks.Task AddBondAsync(BondShopper.Model.Bond bond);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBondService/DeleteBond", ReplyAction="http://tempuri.org/IBondService/DeleteBondResponse")]
        void DeleteBond(BondShopper.Model.Bond bond);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBondService/DeleteBond", ReplyAction="http://tempuri.org/IBondService/DeleteBondResponse")]
        System.Threading.Tasks.Task DeleteBondAsync(BondShopper.Model.Bond bond);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBondService/UpdateBond", ReplyAction="http://tempuri.org/IBondService/UpdateBondResponse")]
        void UpdateBond(BondShopper.Model.Bond bond);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBondService/UpdateBond", ReplyAction="http://tempuri.org/IBondService/UpdateBondResponse")]
        System.Threading.Tasks.Task UpdateBondAsync(BondShopper.Model.Bond bond);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBondServiceChannel : BondShopper.ClientApp.BondShopperService.IBondService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BondServiceClient : System.ServiceModel.ClientBase<BondShopper.ClientApp.BondShopperService.IBondService>, BondShopper.ClientApp.BondShopperService.IBondService {
        
        public BondServiceClient() {
        }
        
        public BondServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BondServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BondServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BondServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<BondShopper.Model.Bond> GetBonds() {
            return base.Channel.GetBonds();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BondShopper.Model.Bond>> GetBondsAsync() {
            return base.Channel.GetBondsAsync();
        }
        
        public void AddBond(BondShopper.Model.Bond bond) {
            base.Channel.AddBond(bond);
        }
        
        public System.Threading.Tasks.Task AddBondAsync(BondShopper.Model.Bond bond) {
            return base.Channel.AddBondAsync(bond);
        }
        
        public void DeleteBond(BondShopper.Model.Bond bond) {
            base.Channel.DeleteBond(bond);
        }
        
        public System.Threading.Tasks.Task DeleteBondAsync(BondShopper.Model.Bond bond) {
            return base.Channel.DeleteBondAsync(bond);
        }
        
        public void UpdateBond(BondShopper.Model.Bond bond) {
            base.Channel.UpdateBond(bond);
        }
        
        public System.Threading.Tasks.Task UpdateBondAsync(BondShopper.Model.Bond bond) {
            return base.Channel.UpdateBondAsync(bond);
        }
    }
}
