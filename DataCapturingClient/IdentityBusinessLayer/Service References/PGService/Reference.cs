﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IdentityBusinessLayer.PGService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentRecord", Namespace="http://schemas.datacontract.org/2004/07/PGPortal.WebService")]
    [System.SerializableAttribute()]
    public partial class StudentRecord : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstnameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MatricNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddlenameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProgramCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProgrammeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Department {
            get {
                return this.DepartmentField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentField, value) != true)) {
                    this.DepartmentField = value;
                    this.RaisePropertyChanged("Department");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Firstname {
            get {
                return this.FirstnameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstnameField, value) != true)) {
                    this.FirstnameField = value;
                    this.RaisePropertyChanged("Firstname");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MatricNo {
            get {
                return this.MatricNoField;
            }
            set {
                if ((object.ReferenceEquals(this.MatricNoField, value) != true)) {
                    this.MatricNoField = value;
                    this.RaisePropertyChanged("MatricNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Middlename {
            get {
                return this.MiddlenameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddlenameField, value) != true)) {
                    this.MiddlenameField = value;
                    this.RaisePropertyChanged("Middlename");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProgramCategory {
            get {
                return this.ProgramCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.ProgramCategoryField, value) != true)) {
                    this.ProgramCategoryField = value;
                    this.RaisePropertyChanged("ProgramCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Programme {
            get {
                return this.ProgrammeField;
            }
            set {
                if ((object.ReferenceEquals(this.ProgrammeField, value) != true)) {
                    this.ProgrammeField = value;
                    this.RaisePropertyChanged("Programme");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex {
            get {
                return this.SexField;
            }
            set {
                if ((object.ReferenceEquals(this.SexField, value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Status {
            get {
                return this.StatusField;
            }
            set {
                if ((object.ReferenceEquals(this.StatusField, value) != true)) {
                    this.StatusField = value;
                    this.RaisePropertyChanged("Status");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Surname {
            get {
                return this.SurnameField;
            }
            set {
                if ((object.ReferenceEquals(this.SurnameField, value) != true)) {
                    this.SurnameField = value;
                    this.RaisePropertyChanged("Surname");
                }
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PGService.IPGService")]
    public interface IPGService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPGService/getStudentRecord", ReplyAction="http://tempuri.org/IPGService/getStudentRecordResponse")]
        IdentityBusinessLayer.PGService.StudentRecord getStudentRecord(string MatricNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPGService/getStudentRecord", ReplyAction="http://tempuri.org/IPGService/getStudentRecordResponse")]
        System.Threading.Tasks.Task<IdentityBusinessLayer.PGService.StudentRecord> getStudentRecordAsync(string MatricNo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPGService/getStudentRecordWithSession", ReplyAction="http://tempuri.org/IPGService/getStudentRecordWithSessionResponse")]
        IdentityBusinessLayer.PGService.StudentRecord getStudentRecordWithSession(string MatricNo, string Session);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPGService/getStudentRecordWithSession", ReplyAction="http://tempuri.org/IPGService/getStudentRecordWithSessionResponse")]
        System.Threading.Tasks.Task<IdentityBusinessLayer.PGService.StudentRecord> getStudentRecordWithSessionAsync(string MatricNo, string Session);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPGServiceChannel : IdentityBusinessLayer.PGService.IPGService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PGServiceClient : System.ServiceModel.ClientBase<IdentityBusinessLayer.PGService.IPGService>, IdentityBusinessLayer.PGService.IPGService {
        
        public PGServiceClient() {
        }
        
        public PGServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PGServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PGServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PGServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public IdentityBusinessLayer.PGService.StudentRecord getStudentRecord(string MatricNo) {
            return base.Channel.getStudentRecord(MatricNo);
        }
        
        public System.Threading.Tasks.Task<IdentityBusinessLayer.PGService.StudentRecord> getStudentRecordAsync(string MatricNo) {
            return base.Channel.getStudentRecordAsync(MatricNo);
        }
        
        public IdentityBusinessLayer.PGService.StudentRecord getStudentRecordWithSession(string MatricNo, string Session) {
            return base.Channel.getStudentRecordWithSession(MatricNo, Session);
        }
        
        public System.Threading.Tasks.Task<IdentityBusinessLayer.PGService.StudentRecord> getStudentRecordWithSessionAsync(string MatricNo, string Session) {
            return base.Channel.getStudentRecordWithSessionAsync(MatricNo, Session);
        }
    }
}