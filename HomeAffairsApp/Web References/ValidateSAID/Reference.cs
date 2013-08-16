﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.18051.
// 
#pragma warning disable 1591

namespace HomeAffairsApp.ValidateSAID {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="SAIDValidatorSoap", Namespace="http://xml-fx.com/services/SAIDValidator/")]
    public partial class SAIDValidator : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetServiceIdentifierOperationCompleted;
        
        private System.Threading.SendOrPostCallback ValidateIdStringOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SAIDValidator() {
            this.Url = global::HomeAffairsApp.Properties.Settings.Default.HomeAffairsApp_ValidateSAID_SAIDValidator;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetServiceIdentifierCompletedEventHandler GetServiceIdentifierCompleted;
        
        /// <remarks/>
        public event ValidateIdStringCompletedEventHandler ValidateIdStringCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://xml-fx.com/services/SAIDValidator/GetServiceIdentifier", RequestNamespace="http://xml-fx.com/services/SAIDValidator/", ResponseNamespace="http://xml-fx.com/services/SAIDValidator/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetServiceIdentifier() {
            object[] results = this.Invoke("GetServiceIdentifier", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetServiceIdentifierAsync() {
            this.GetServiceIdentifierAsync(null);
        }
        
        /// <remarks/>
        public void GetServiceIdentifierAsync(object userState) {
            if ((this.GetServiceIdentifierOperationCompleted == null)) {
                this.GetServiceIdentifierOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServiceIdentifierOperationCompleted);
            }
            this.InvokeAsync("GetServiceIdentifier", new object[0], this.GetServiceIdentifierOperationCompleted, userState);
        }
        
        private void OnGetServiceIdentifierOperationCompleted(object arg) {
            if ((this.GetServiceIdentifierCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetServiceIdentifierCompleted(this, new GetServiceIdentifierCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://xml-fx.com/services/SAIDValidator/ValidateIdString", RequestNamespace="http://xml-fx.com/services/SAIDValidator/", ResponseNamespace="http://xml-fx.com/services/SAIDValidator/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("said", Namespace="http://xml-fx.com/services/SAIDValidator/said.xsd")]
        public saidType ValidateIdString(string authToken, string said) {
            object[] results = this.Invoke("ValidateIdString", new object[] {
                        authToken,
                        said});
            return ((saidType)(results[0]));
        }
        
        /// <remarks/>
        public void ValidateIdStringAsync(string authToken, string said) {
            this.ValidateIdStringAsync(authToken, said, null);
        }
        
        /// <remarks/>
        public void ValidateIdStringAsync(string authToken, string said, object userState) {
            if ((this.ValidateIdStringOperationCompleted == null)) {
                this.ValidateIdStringOperationCompleted = new System.Threading.SendOrPostCallback(this.OnValidateIdStringOperationCompleted);
            }
            this.InvokeAsync("ValidateIdString", new object[] {
                        authToken,
                        said}, this.ValidateIdStringOperationCompleted, userState);
        }
        
        private void OnValidateIdStringOperationCompleted(object arg) {
            if ((this.ValidateIdStringCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ValidateIdStringCompleted(this, new ValidateIdStringCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://xml-fx.com/services/SAIDValidator/said.xsd")]
    public partial class saidType {
        
        private string inputField;
        
        private saidTypeOutput outputField;
        
        private bool validField;
        
        private bool validFieldSpecified;
        
        private uint errorField;
        
        private bool errorFieldSpecified;
        
        /// <remarks/>
        public string Input {
            get {
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
        
        /// <remarks/>
        public saidTypeOutput output {
            get {
                return this.outputField;
            }
            set {
                this.outputField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool Valid {
            get {
                return this.validField;
            }
            set {
                this.validField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidSpecified {
            get {
                return this.validFieldSpecified;
            }
            set {
                this.validFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public uint Error {
            get {
                return this.errorField;
            }
            set {
                this.errorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorSpecified {
            get {
                return this.errorFieldSpecified;
            }
            set {
                this.errorFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18053")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xml-fx.com/services/SAIDValidator/said.xsd")]
    public partial class saidTypeOutput {
        
        private int cCDField;
        
        private int cdField;
        
        private saidTypeOutputCitizen citizenField;
        
        private System.DateTime dOBField;
        
        private string errorFlagsField;
        
        private saidTypeOutputGender genderField;
        
        private string parsedField;
        
        private uint sequenceField;
        
        /// <remarks/>
        public int CCD {
            get {
                return this.cCDField;
            }
            set {
                this.cCDField = value;
            }
        }
        
        /// <remarks/>
        public int CD {
            get {
                return this.cdField;
            }
            set {
                this.cdField = value;
            }
        }
        
        /// <remarks/>
        public saidTypeOutputCitizen Citizen {
            get {
                return this.citizenField;
            }
            set {
                this.citizenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
        public System.DateTime DOB {
            get {
                return this.dOBField;
            }
            set {
                this.dOBField = value;
            }
        }
        
        /// <remarks/>
        public string ErrorFlags {
            get {
                return this.errorFlagsField;
            }
            set {
                this.errorFlagsField = value;
            }
        }
        
        /// <remarks/>
        public saidTypeOutputGender Gender {
            get {
                return this.genderField;
            }
            set {
                this.genderField = value;
            }
        }
        
        /// <remarks/>
        public string Parsed {
            get {
                return this.parsedField;
            }
            set {
                this.parsedField = value;
            }
        }
        
        /// <remarks/>
        public uint Sequence {
            get {
                return this.sequenceField;
            }
            set {
                this.sequenceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18053")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xml-fx.com/services/SAIDValidator/said.xsd")]
    public enum saidTypeOutputCitizen {
        
        /// <remarks/>
        Unknown,
        
        /// <remarks/>
        SA,
        
        /// <remarks/>
        Foreign,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18053")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xml-fx.com/services/SAIDValidator/said.xsd")]
    public enum saidTypeOutputGender {
        
        /// <remarks/>
        Unknown,
        
        /// <remarks/>
        Female,
        
        /// <remarks/>
        Male,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetServiceIdentifierCompletedEventHandler(object sender, GetServiceIdentifierCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetServiceIdentifierCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetServiceIdentifierCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void ValidateIdStringCompletedEventHandler(object sender, ValidateIdStringCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ValidateIdStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ValidateIdStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public saidType Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((saidType)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591