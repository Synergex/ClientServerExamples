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
    [System.Runtime.Serialization.DataContractAttribute(Name="Address", Namespace="http://schemas.datacontract.org/2004/07/spc2011")]
    [System.SerializableAttribute()]
    public partial class Address : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime Active_dateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Address_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ClientApp.spc2011.Address_type Address_typeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Billing_addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Customer_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Mailing_addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Main_addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Postal_codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Replication_keyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool Satellite_officeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
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
        public System.DateTime Active_date {
            get {
                return this.Active_dateField;
            }
            set {
                if ((this.Active_dateField.Equals(value) != true)) {
                    this.Active_dateField = value;
                    this.RaisePropertyChanged("Active_date");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address1 {
            get {
                return this.Address1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address1Field, value) != true)) {
                    this.Address1Field = value;
                    this.RaisePropertyChanged("Address1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address2 {
            get {
                return this.Address2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address2Field, value) != true)) {
                    this.Address2Field = value;
                    this.RaisePropertyChanged("Address2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address3 {
            get {
                return this.Address3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address3Field, value) != true)) {
                    this.Address3Field = value;
                    this.RaisePropertyChanged("Address3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Address_id {
            get {
                return this.Address_idField;
            }
            set {
                if ((this.Address_idField.Equals(value) != true)) {
                    this.Address_idField = value;
                    this.RaisePropertyChanged("Address_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ClientApp.spc2011.Address_type Address_type {
            get {
                return this.Address_typeField;
            }
            set {
                if ((this.Address_typeField.Equals(value) != true)) {
                    this.Address_typeField = value;
                    this.RaisePropertyChanged("Address_type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Billing_address {
            get {
                return this.Billing_addressField;
            }
            set {
                if ((this.Billing_addressField.Equals(value) != true)) {
                    this.Billing_addressField = value;
                    this.RaisePropertyChanged("Billing_address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Country {
            get {
                return this.CountryField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryField, value) != true)) {
                    this.CountryField = value;
                    this.RaisePropertyChanged("Country");
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
        public bool Mailing_address {
            get {
                return this.Mailing_addressField;
            }
            set {
                if ((this.Mailing_addressField.Equals(value) != true)) {
                    this.Mailing_addressField = value;
                    this.RaisePropertyChanged("Mailing_address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Main_address {
            get {
                return this.Main_addressField;
            }
            set {
                if ((this.Main_addressField.Equals(value) != true)) {
                    this.Main_addressField = value;
                    this.RaisePropertyChanged("Main_address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Postal_code {
            get {
                return this.Postal_codeField;
            }
            set {
                if ((object.ReferenceEquals(this.Postal_codeField, value) != true)) {
                    this.Postal_codeField = value;
                    this.RaisePropertyChanged("Postal_code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Replication_key {
            get {
                return this.Replication_keyField;
            }
            set {
                if ((object.ReferenceEquals(this.Replication_keyField, value) != true)) {
                    this.Replication_keyField = value;
                    this.RaisePropertyChanged("Replication_key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Satellite_office {
            get {
                return this.Satellite_officeField;
            }
            set {
                if ((this.Satellite_officeField.Equals(value) != true)) {
                    this.Satellite_officeField = value;
                    this.RaisePropertyChanged("Satellite_office");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Address_type", Namespace="http://schemas.datacontract.org/2004/07/spc2011")]
    public enum Address_type : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Business = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Home = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Other = 2,
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
        private string Noname_001Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Replication_keyField;
        
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
        public string Noname_001 {
            get {
                return this.Noname_001Field;
            }
            set {
                if ((object.ReferenceEquals(this.Noname_001Field, value) != true)) {
                    this.Noname_001Field = value;
                    this.RaisePropertyChanged("Noname_001");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Replication_key {
            get {
                return this.Replication_keyField;
            }
            set {
                if ((object.ReferenceEquals(this.Replication_keyField, value) != true)) {
                    this.Replication_keyField = value;
                    this.RaisePropertyChanged("Replication_key");
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
        private int Address_idField;
        
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
        private string Noname_001Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Picture_fileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Replication_keyField;
        
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
        public int Address_id {
            get {
                return this.Address_idField;
            }
            set {
                if ((this.Address_idField.Equals(value) != true)) {
                    this.Address_idField = value;
                    this.RaisePropertyChanged("Address_id");
                }
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
        public string Noname_001 {
            get {
                return this.Noname_001Field;
            }
            set {
                if ((object.ReferenceEquals(this.Noname_001Field, value) != true)) {
                    this.Noname_001Field = value;
                    this.RaisePropertyChanged("Noname_001");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Picture_file {
            get {
                return this.Picture_fileField;
            }
            set {
                if ((object.ReferenceEquals(this.Picture_fileField, value) != true)) {
                    this.Picture_fileField = value;
                    this.RaisePropertyChanged("Picture_file");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Replication_key {
            get {
                return this.Replication_keyField;
            }
            set {
                if ((object.ReferenceEquals(this.Replication_keyField, value) != true)) {
                    this.Replication_keyField = value;
                    this.RaisePropertyChanged("Replication_key");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="spc2011.SynergyServer")]
    public interface SynergyServer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SynergyServer/GetAddressForUpdate", ReplyAction="http://tempuri.org/SynergyServer/GetAddressForUpdateResponse")]
        ClientApp.spc2011.Method_status GetAddressForUpdate(int CustomerID, int AddressID, ref ClientApp.spc2011.Address Address, ref byte[] GRFA, ref string Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SynergyServer/GetAllCustomers", ReplyAction="http://tempuri.org/SynergyServer/GetAllCustomersResponse")]
        void GetAllCustomers(ref System.Collections.Generic.List<ClientApp.spc2011.Customer> Customers);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SynergyServer/GetContactForUpdate", ReplyAction="http://tempuri.org/SynergyServer/GetContactForUpdateResponse")]
        ClientApp.spc2011.Method_status GetContactForUpdate(int CustomerID, int ContactID, ref ClientApp.spc2011.Contact Contact, ref byte[] GRFA, ref string Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SynergyServer/GetCustomerAddresses", ReplyAction="http://tempuri.org/SynergyServer/GetCustomerAddressesResponse")]
        void GetCustomerAddresses(int CustomerID, ref System.Collections.Generic.List<ClientApp.spc2011.Address> Addresses);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SynergyServer/GetCustomerContacts", ReplyAction="http://tempuri.org/SynergyServer/GetCustomerContactsResponse")]
        void GetCustomerContacts(int CustomerID, ref System.Collections.Generic.List<ClientApp.spc2011.Contact> Contacts);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SynergyServer/GetCustomerForUpdate", ReplyAction="http://tempuri.org/SynergyServer/GetCustomerForUpdateResponse")]
        ClientApp.spc2011.Method_status GetCustomerForUpdate(int CustomerID, ref ClientApp.spc2011.Customer Customer, ref byte[] GRFA, ref string Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SynergyServer/UpdateContact", ReplyAction="http://tempuri.org/SynergyServer/UpdateContactResponse")]
        ClientApp.spc2011.Method_status UpdateContact(ref ClientApp.spc2011.Contact Contact, ref byte[] GRFA, ref string Message);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SynergyServer/UpdateCustomer", ReplyAction="http://tempuri.org/SynergyServer/UpdateCustomerResponse")]
        ClientApp.spc2011.Method_status UpdateCustomer(ref ClientApp.spc2011.Customer Customer, ref byte[] GRFA, ref string Message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SynergyServerChannel : ClientApp.spc2011.SynergyServer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SynergyServerClient : System.ServiceModel.ClientBase<ClientApp.spc2011.SynergyServer>, ClientApp.spc2011.SynergyServer {
        
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
        
        public ClientApp.spc2011.Method_status GetAddressForUpdate(int CustomerID, int AddressID, ref ClientApp.spc2011.Address Address, ref byte[] GRFA, ref string Message) {
            return base.Channel.GetAddressForUpdate(CustomerID, AddressID, ref Address, ref GRFA, ref Message);
        }
        
        public void GetAllCustomers(ref System.Collections.Generic.List<ClientApp.spc2011.Customer> Customers) {
            base.Channel.GetAllCustomers(ref Customers);
        }
        
        public ClientApp.spc2011.Method_status GetContactForUpdate(int CustomerID, int ContactID, ref ClientApp.spc2011.Contact Contact, ref byte[] GRFA, ref string Message) {
            return base.Channel.GetContactForUpdate(CustomerID, ContactID, ref Contact, ref GRFA, ref Message);
        }
        
        public void GetCustomerAddresses(int CustomerID, ref System.Collections.Generic.List<ClientApp.spc2011.Address> Addresses) {
            base.Channel.GetCustomerAddresses(CustomerID, ref Addresses);
        }
        
        public void GetCustomerContacts(int CustomerID, ref System.Collections.Generic.List<ClientApp.spc2011.Contact> Contacts) {
            base.Channel.GetCustomerContacts(CustomerID, ref Contacts);
        }
        
        public ClientApp.spc2011.Method_status GetCustomerForUpdate(int CustomerID, ref ClientApp.spc2011.Customer Customer, ref byte[] GRFA, ref string Message) {
            return base.Channel.GetCustomerForUpdate(CustomerID, ref Customer, ref GRFA, ref Message);
        }
        
        public ClientApp.spc2011.Method_status UpdateContact(ref ClientApp.spc2011.Contact Contact, ref byte[] GRFA, ref string Message) {
            return base.Channel.UpdateContact(ref Contact, ref GRFA, ref Message);
        }
        
        public ClientApp.spc2011.Method_status UpdateCustomer(ref ClientApp.spc2011.Customer Customer, ref byte[] GRFA, ref string Message) {
            return base.Channel.UpdateCustomer(ref Customer, ref GRFA, ref Message);
        }
    }
}
