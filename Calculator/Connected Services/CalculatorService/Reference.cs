﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculator.CalculatorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://tempuri.org/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CalculatorService.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mul", ReplyAction="*")]
        int mul(int a, int b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mul", ReplyAction="*")]
        System.Threading.Tasks.Task<int> mulAsync(int a, int b);
        
        // CODEGEN: Generating message contract since element name GetCalculationResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCalculation", ReplyAction="*")]
        Calculator.CalculatorService.GetCalculationResponse GetCalculation(Calculator.CalculatorService.GetCalculationRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCalculation", ReplyAction="*")]
        System.Threading.Tasks.Task<Calculator.CalculatorService.GetCalculationResponse> GetCalculationAsync(Calculator.CalculatorService.GetCalculationRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculation", Namespace="http://tempuri.org/", Order=0)]
        public Calculator.CalculatorService.GetCalculationRequestBody Body;
        
        public GetCalculationRequest() {
        }
        
        public GetCalculationRequest(Calculator.CalculatorService.GetCalculationRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCalculationRequestBody {
        
        public GetCalculationRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculationResponse", Namespace="http://tempuri.org/", Order=0)]
        public Calculator.CalculatorService.GetCalculationResponseBody Body;
        
        public GetCalculationResponse() {
        }
        
        public GetCalculationResponse(Calculator.CalculatorService.GetCalculationResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCalculationResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public Calculator.CalculatorService.ArrayOfString GetCalculationResult;
        
        public GetCalculationResponseBody() {
        }
        
        public GetCalculationResponseBody(Calculator.CalculatorService.ArrayOfString GetCalculationResult) {
            this.GetCalculationResult = GetCalculationResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Calculator.CalculatorService.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Calculator.CalculatorService.WebService1Soap>, Calculator.CalculatorService.WebService1Soap {
        
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
        
        public int Add(int a, int b) {
            return base.Channel.Add(a, b);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int a, int b) {
            return base.Channel.AddAsync(a, b);
        }
        
        public int mul(int a, int b) {
            return base.Channel.mul(a, b);
        }
        
        public System.Threading.Tasks.Task<int> mulAsync(int a, int b) {
            return base.Channel.mulAsync(a, b);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Calculator.CalculatorService.GetCalculationResponse Calculator.CalculatorService.WebService1Soap.GetCalculation(Calculator.CalculatorService.GetCalculationRequest request) {
            return base.Channel.GetCalculation(request);
        }
        
        public Calculator.CalculatorService.ArrayOfString GetCalculation() {
            Calculator.CalculatorService.GetCalculationRequest inValue = new Calculator.CalculatorService.GetCalculationRequest();
            inValue.Body = new Calculator.CalculatorService.GetCalculationRequestBody();
            Calculator.CalculatorService.GetCalculationResponse retVal = ((Calculator.CalculatorService.WebService1Soap)(this)).GetCalculation(inValue);
            return retVal.Body.GetCalculationResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Calculator.CalculatorService.GetCalculationResponse> Calculator.CalculatorService.WebService1Soap.GetCalculationAsync(Calculator.CalculatorService.GetCalculationRequest request) {
            return base.Channel.GetCalculationAsync(request);
        }
        
        public System.Threading.Tasks.Task<Calculator.CalculatorService.GetCalculationResponse> GetCalculationAsync() {
            Calculator.CalculatorService.GetCalculationRequest inValue = new Calculator.CalculatorService.GetCalculationRequest();
            inValue.Body = new Calculator.CalculatorService.GetCalculationRequestBody();
            return ((Calculator.CalculatorService.WebService1Soap)(this)).GetCalculationAsync(inValue);
        }
    }
}