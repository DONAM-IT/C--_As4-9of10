﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebClient.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToVND", ReplyAction="*")]
        WebClient.ServiceReference2.ConvertToVNDResponse ConvertToVND(WebClient.ServiceReference2.ConvertToVNDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToVND", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClient.ServiceReference2.ConvertToVNDResponse> ConvertToVNDAsync(WebClient.ServiceReference2.ConvertToVNDRequest request);
        
        // CODEGEN: Generating message contract since element name name from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToForeignCurrencies", ReplyAction="*")]
        WebClient.ServiceReference2.ConvertToForeignCurrenciesResponse ConvertToForeignCurrencies(WebClient.ServiceReference2.ConvertToForeignCurrenciesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToForeignCurrencies", ReplyAction="*")]
        System.Threading.Tasks.Task<WebClient.ServiceReference2.ConvertToForeignCurrenciesResponse> ConvertToForeignCurrenciesAsync(WebClient.ServiceReference2.ConvertToForeignCurrenciesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertToVNDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertToVND", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference2.ConvertToVNDRequestBody Body;
        
        public ConvertToVNDRequest() {
        }
        
        public ConvertToVNDRequest(WebClient.ServiceReference2.ConvertToVNDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertToVNDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double vnd;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        public ConvertToVNDRequestBody() {
        }
        
        public ConvertToVNDRequestBody(double vnd, string name) {
            this.vnd = vnd;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertToVNDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertToVNDResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference2.ConvertToVNDResponseBody Body;
        
        public ConvertToVNDResponse() {
        }
        
        public ConvertToVNDResponse(WebClient.ServiceReference2.ConvertToVNDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertToVNDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double ConvertToVNDResult;
        
        public ConvertToVNDResponseBody() {
        }
        
        public ConvertToVNDResponseBody(double ConvertToVNDResult) {
            this.ConvertToVNDResult = ConvertToVNDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertToForeignCurrenciesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertToForeignCurrencies", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference2.ConvertToForeignCurrenciesRequestBody Body;
        
        public ConvertToForeignCurrenciesRequest() {
        }
        
        public ConvertToForeignCurrenciesRequest(WebClient.ServiceReference2.ConvertToForeignCurrenciesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertToForeignCurrenciesRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double foregin;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string name;
        
        public ConvertToForeignCurrenciesRequestBody() {
        }
        
        public ConvertToForeignCurrenciesRequestBody(double foregin, string name) {
            this.foregin = foregin;
            this.name = name;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConvertToForeignCurrenciesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConvertToForeignCurrenciesResponse", Namespace="http://tempuri.org/", Order=0)]
        public WebClient.ServiceReference2.ConvertToForeignCurrenciesResponseBody Body;
        
        public ConvertToForeignCurrenciesResponse() {
        }
        
        public ConvertToForeignCurrenciesResponse(WebClient.ServiceReference2.ConvertToForeignCurrenciesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class ConvertToForeignCurrenciesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double ConvertToForeignCurrenciesResult;
        
        public ConvertToForeignCurrenciesResponseBody() {
        }
        
        public ConvertToForeignCurrenciesResponseBody(double ConvertToForeignCurrenciesResult) {
            this.ConvertToForeignCurrenciesResult = ConvertToForeignCurrenciesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WebClient.ServiceReference2.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WebClient.ServiceReference2.WebService1Soap>, WebClient.ServiceReference2.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ServiceReference2.ConvertToVNDResponse WebClient.ServiceReference2.WebService1Soap.ConvertToVND(WebClient.ServiceReference2.ConvertToVNDRequest request) {
            return base.Channel.ConvertToVND(request);
        }
        
        public double ConvertToVND(double vnd, string name) {
            WebClient.ServiceReference2.ConvertToVNDRequest inValue = new WebClient.ServiceReference2.ConvertToVNDRequest();
            inValue.Body = new WebClient.ServiceReference2.ConvertToVNDRequestBody();
            inValue.Body.vnd = vnd;
            inValue.Body.name = name;
            WebClient.ServiceReference2.ConvertToVNDResponse retVal = ((WebClient.ServiceReference2.WebService1Soap)(this)).ConvertToVND(inValue);
            return retVal.Body.ConvertToVNDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.ServiceReference2.ConvertToVNDResponse> WebClient.ServiceReference2.WebService1Soap.ConvertToVNDAsync(WebClient.ServiceReference2.ConvertToVNDRequest request) {
            return base.Channel.ConvertToVNDAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference2.ConvertToVNDResponse> ConvertToVNDAsync(double vnd, string name) {
            WebClient.ServiceReference2.ConvertToVNDRequest inValue = new WebClient.ServiceReference2.ConvertToVNDRequest();
            inValue.Body = new WebClient.ServiceReference2.ConvertToVNDRequestBody();
            inValue.Body.vnd = vnd;
            inValue.Body.name = name;
            return ((WebClient.ServiceReference2.WebService1Soap)(this)).ConvertToVNDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebClient.ServiceReference2.ConvertToForeignCurrenciesResponse WebClient.ServiceReference2.WebService1Soap.ConvertToForeignCurrencies(WebClient.ServiceReference2.ConvertToForeignCurrenciesRequest request) {
            return base.Channel.ConvertToForeignCurrencies(request);
        }
        
        public double ConvertToForeignCurrencies(double foregin, string name) {
            WebClient.ServiceReference2.ConvertToForeignCurrenciesRequest inValue = new WebClient.ServiceReference2.ConvertToForeignCurrenciesRequest();
            inValue.Body = new WebClient.ServiceReference2.ConvertToForeignCurrenciesRequestBody();
            inValue.Body.foregin = foregin;
            inValue.Body.name = name;
            WebClient.ServiceReference2.ConvertToForeignCurrenciesResponse retVal = ((WebClient.ServiceReference2.WebService1Soap)(this)).ConvertToForeignCurrencies(inValue);
            return retVal.Body.ConvertToForeignCurrenciesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WebClient.ServiceReference2.ConvertToForeignCurrenciesResponse> WebClient.ServiceReference2.WebService1Soap.ConvertToForeignCurrenciesAsync(WebClient.ServiceReference2.ConvertToForeignCurrenciesRequest request) {
            return base.Channel.ConvertToForeignCurrenciesAsync(request);
        }
        
        public System.Threading.Tasks.Task<WebClient.ServiceReference2.ConvertToForeignCurrenciesResponse> ConvertToForeignCurrenciesAsync(double foregin, string name) {
            WebClient.ServiceReference2.ConvertToForeignCurrenciesRequest inValue = new WebClient.ServiceReference2.ConvertToForeignCurrenciesRequest();
            inValue.Body = new WebClient.ServiceReference2.ConvertToForeignCurrenciesRequestBody();
            inValue.Body.foregin = foregin;
            inValue.Body.name = name;
            return ((WebClient.ServiceReference2.WebService1Soap)(this)).ConvertToForeignCurrenciesAsync(inValue);
        }
    }
}
