﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExchangeRate.KurService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="KurService.IKurService")]
    public interface IKurService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKurService/ParaBirimleriGetir", ReplyAction="http://tempuri.org/IKurService/ParaBirimleriGetirResponse")]
        string[] ParaBirimleriGetir();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKurService/ParaBirimleriGetir", ReplyAction="http://tempuri.org/IKurService/ParaBirimleriGetirResponse")]
        System.Threading.Tasks.Task<string[]> ParaBirimleriGetirAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKurService/KurlariGetir", ReplyAction="http://tempuri.org/IKurService/KurlariGetirResponse")]
        double[] KurlariGetir(string kurTipi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IKurService/KurlariGetir", ReplyAction="http://tempuri.org/IKurService/KurlariGetirResponse")]
        System.Threading.Tasks.Task<double[]> KurlariGetirAsync(string kurTipi);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IKurServiceChannel : ExchangeRate.KurService.IKurService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class KurServiceClient : System.ServiceModel.ClientBase<ExchangeRate.KurService.IKurService>, ExchangeRate.KurService.IKurService {
        
        public KurServiceClient() {
        }
        
        public KurServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public KurServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KurServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public KurServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] ParaBirimleriGetir() {
            return base.Channel.ParaBirimleriGetir();
        }
        
        public System.Threading.Tasks.Task<string[]> ParaBirimleriGetirAsync() {
            return base.Channel.ParaBirimleriGetirAsync();
        }
        
        public double[] KurlariGetir(string kurTipi) {
            return base.Channel.KurlariGetir(kurTipi);
        }
        
        public System.Threading.Tasks.Task<double[]> KurlariGetirAsync(string kurTipi) {
            return base.Channel.KurlariGetirAsync(kurTipi);
        }
    }
}