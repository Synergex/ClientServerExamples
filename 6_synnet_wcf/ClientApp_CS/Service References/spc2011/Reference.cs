﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientApp.spc2011 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/spc2011")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Customer_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Date_createdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Date_modifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StatusField;
        
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
        public int Customer_id {
            get {
                return this.Customer_idField;
            }
            set {
                if ((this.Customer_idField.Equals(value) != true)) {
                    this.Customer_idField = value;
                    this.RaisePropertyChanged("Customer_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date_created {
            get {
                return this.Date_createdField;
            }
            set {
                if ((this.Date_createdField.Equals(value) != true)) {
                    this.Date_createdField = value;
                    this.RaisePropertyChanged("Date_created");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime Date_modified {
            get {
                return this.Date_modifiedField;
            }
            set {
                if ((this.Date_modifiedField.Equals(value) != true)) {
                    this.Date_modifiedField = value;
                    this.RaisePropertyChanged("Date_modified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Contact", Namespace="http://schemas.datacontract.org/2004/07/spc2011")]
    [System.SerializableAttribute()]
    public partial class Contact : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Billing_contactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Contact_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Customer_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long FaxField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string First_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Friendly_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool General_contactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long Home_phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Last_nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Management_contactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long Mobile_phoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Sales_contactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SalutationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Technical_contactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Web_siteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Work_extensionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long Work_phoneField;
        
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
        public bool Billing_contact {
            get {
                return this.Billing_contactField;
            }
            set {
                if ((this.Billing_contactField.Equals(value) != true)) {
                    this.Billing_contactField = value;
                    this.RaisePropertyChanged("Billing_contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Contact_id {
            get {
                return this.Contact_idField;
            }
            set {
                if ((this.Contact_idField.Equals(value) != true)) {
                    this.Contact_idField = value;
                    this.RaisePropertyChanged("Contact_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Customer_id {
            get {
                return this.Customer_idField;
            }
            set {
                if ((this.Customer_idField.Equals(value) != true)) {
                    this.Customer_idField = value;
                    this.RaisePropertyChanged("Customer_id");
                }
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
        public long Fax {
            get {
                return this.FaxField;
            }
            set {
                if ((this.FaxField.Equals(value) != true)) {
                    this.FaxField = value;
                    this.RaisePropertyChanged("Fax");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string First_name {
            get {
                return this.First_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.First_nameField, value) != true)) {
                    this.First_nameField = value;
                    this.RaisePropertyChanged("First_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Friendly_name {
            get {
                return this.Friendly_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Friendly_nameField, value) != true)) {
                    this.Friendly_nameField = value;
                    this.RaisePropertyChanged("Friendly_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool General_contact {
            get {
                return this.General_contactField;
            }
            set {
                if ((this.General_contactField.Equals(value) != true)) {
                    this.General_contactField = value;
                    this.RaisePropertyChanged("General_contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Home_phone {
            get {
                return this.Home_phoneField;
            }
            set {
                if ((this.Home_phoneField.Equals(value) != true)) {
                    this.Home_phoneField = value;
                    this.RaisePropertyChanged("Home_phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Last_name {
            get {
                return this.Last_nameField;
            }
            set {
                if ((object.ReferenceEquals(this.Last_nameField, value) != true)) {
                    this.Last_nameField = value;
                    this.RaisePropertyChanged("Last_name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Management_contact {
            get {
                return this.Management_contactField;
            }
            set {
                if ((this.Management_contactField.Equals(value) != true)) {
                    this.Management_contactField = value;
                    this.RaisePropertyChanged("Management_contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Mobile_phone {
            get {
                return this.Mobile_phoneField;
            }
            set {
                if ((this.Mobile_phoneField.Equals(value) != true)) {
                    this.Mobile_phoneField = value;
                    this.RaisePropertyChanged("Mobile_phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Sales_contact {
            get {
                return this.Sales_contactField;
            }
            set {
                if ((this.Sales_contactField.Equals(value) != true)) {
                    this.Sales_contactField = value;
                    this.RaisePropertyChanged("Sales_contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Salutation {
            get {
                return this.SalutationField;
            }
            set {
                if ((object.ReferenceEquals(this.SalutationField, value) != true)) {
                    this.SalutationField = value;
                    this.RaisePropertyChanged("Salutation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Technical_contact {
            get {
                return this.Technical_contactField;
            }
            set {
                if ((this.Technical_contactField.Equals(value) != true)) {
                    this.Technical_contactField = value;
                    this.RaisePropertyChanged("Technical_contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Web_site {
            get {
                return this.Web_siteField;
            }
            set {
                if ((object.ReferenceEquals(this.Web_siteField, value) != true)) {
                    this.Web_siteField = value;
                    this.RaisePropertyChanged("Web_site");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Work_extension {
            get {
                return this.Work_extensionField;
            }
            set {
                if ((this.Work_extensionField.Equals(value) != true)) {
                    this.Work_extensionField = value;
                    this.RaisePropertyChanged("Work_extension");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long Work_phone {
            get {
                return this.Work_phoneField;
            }
            set {
                if ((this.Work_phoneField.Equals(value) != true)) {
                    this.Work_phoneField = value;
                    this.RaisePropertyChanged("Work_phone");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Method_status", Namespace="http://schemas.datacontract.org/2004/07/spc2011")]
    public enum Method_status : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Success = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Info_error = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Fatal_error = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="spc2011.ISynergyServer")]
    public interface ISynergyServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynergyServer/GetAllCustomers", ReplyAction="http://tempuri.org/ISynergyServer/GetAllCustomersResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="a_customers")]
        System.Collections.Generic.List<ClientApp.spc2011.Customer> GetAllCustomers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynergyServer/GetCustomerContacts", ReplyAction="http://tempuri.org/ISynergyServer/GetCustomerContactsResponse")]
        [return: System.ServiceModel.MessageParameterAttribute(Name="a_contacts")]
        System.Collections.Generic.List<ClientApp.spc2011.Contact> GetCustomerContacts(int a_customer_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynergyServer/GetContactForUpdate", ReplyAction="http://tempuri.org/ISynergyServer/GetContactForUpdateResponse")]
        ClientApp.spc2011.Method_status GetContactForUpdate(out ClientApp.spc2011.Contact a_contact, out byte[] a_grfa, out string a_message, int a_customer_id, int a_contact_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISynergyServer/UpdateContact", ReplyAction="http://tempuri.org/ISynergyServer/UpdateContactResponse")]
        ClientApp.spc2011.Method_status UpdateContact(ref ClientApp.spc2011.Contact a_contact, ref byte[] a_grfa, out string a_message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISynergyServerChannel : ClientApp.spc2011.ISynergyServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SynergyServerClient : System.ServiceModel.ClientBase<ClientApp.spc2011.ISynergyServer>, ClientApp.spc2011.ISynergyServer {
        
        public SynergyServerClient() {
        }
        
        public SynergyServerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SynergyServerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SynergyServerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SynergyServerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.List<ClientApp.spc2011.Customer> GetAllCustomers() {
            return base.Channel.GetAllCustomers();
        }
        
        public System.Collections.Generic.List<ClientApp.spc2011.Contact> GetCustomerContacts(int a_customer_id) {
            return base.Channel.GetCustomerContacts(a_customer_id);
        }
        
        public ClientApp.spc2011.Method_status GetContactForUpdate(out ClientApp.spc2011.Contact a_contact, out byte[] a_grfa, out string a_message, int a_customer_id, int a_contact_id) {
            return base.Channel.GetContactForUpdate(out a_contact, out a_grfa, out a_message, a_customer_id, a_contact_id);
        }
        
        public ClientApp.spc2011.Method_status UpdateContact(ref ClientApp.spc2011.Contact a_contact, ref byte[] a_grfa, out string a_message) {
            return base.Channel.UpdateContact(ref a_contact, ref a_grfa, out a_message);
        }
    }
}