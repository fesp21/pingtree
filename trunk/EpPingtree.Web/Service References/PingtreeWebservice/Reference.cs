﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EpPingtree.Web.PingtreeWebservice {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LeadRequest", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class LeadRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ForenameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SurnameField;
        
        private System.DateTime DobField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressLine1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressLine2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TownField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HomeStatusField;
        
        private System.Nullable<int> MonthsAtAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployersNameField;
        
        private System.Nullable<int> MonthsAtEmployerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IncomeFrequencyField;
        
        private int MonthlyIncomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmploymentStatusField;
        
        private bool DirectDepositField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BankAccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BankSortcodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HomePhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WorkPhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobilePhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailAddressField;
        
        private System.DateTime ApplicationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SubSourceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IpAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryField;
        
        private int LoanAmountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DebitCardTypeField;
        
        private System.DateTime PaybackDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SellerNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((object.ReferenceEquals(this.GenderField, value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string Forename {
            get {
                return this.ForenameField;
            }
            set {
                if ((object.ReferenceEquals(this.ForenameField, value) != true)) {
                    this.ForenameField = value;
                    this.RaisePropertyChanged("Forename");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public System.DateTime Dob {
            get {
                return this.DobField;
            }
            set {
                if ((this.DobField.Equals(value) != true)) {
                    this.DobField = value;
                    this.RaisePropertyChanged("Dob");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string AddressLine1 {
            get {
                return this.AddressLine1Field;
            }
            set {
                if ((object.ReferenceEquals(this.AddressLine1Field, value) != true)) {
                    this.AddressLine1Field = value;
                    this.RaisePropertyChanged("AddressLine1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string AddressLine2 {
            get {
                return this.AddressLine2Field;
            }
            set {
                if ((object.ReferenceEquals(this.AddressLine2Field, value) != true)) {
                    this.AddressLine2Field = value;
                    this.RaisePropertyChanged("AddressLine2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Town {
            get {
                return this.TownField;
            }
            set {
                if ((object.ReferenceEquals(this.TownField, value) != true)) {
                    this.TownField = value;
                    this.RaisePropertyChanged("Town");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string County {
            get {
                return this.CountyField;
            }
            set {
                if ((object.ReferenceEquals(this.CountyField, value) != true)) {
                    this.CountyField = value;
                    this.RaisePropertyChanged("County");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string Postcode {
            get {
                return this.PostcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostcodeField, value) != true)) {
                    this.PostcodeField = value;
                    this.RaisePropertyChanged("Postcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=10)]
        public string HomeStatus {
            get {
                return this.HomeStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.HomeStatusField, value) != true)) {
                    this.HomeStatusField = value;
                    this.RaisePropertyChanged("HomeStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=11)]
        public System.Nullable<int> MonthsAtAddress {
            get {
                return this.MonthsAtAddressField;
            }
            set {
                if ((this.MonthsAtAddressField.Equals(value) != true)) {
                    this.MonthsAtAddressField = value;
                    this.RaisePropertyChanged("MonthsAtAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string EmployersName {
            get {
                return this.EmployersNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployersNameField, value) != true)) {
                    this.EmployersNameField = value;
                    this.RaisePropertyChanged("EmployersName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=13)]
        public System.Nullable<int> MonthsAtEmployer {
            get {
                return this.MonthsAtEmployerField;
            }
            set {
                if ((this.MonthsAtEmployerField.Equals(value) != true)) {
                    this.MonthsAtEmployerField = value;
                    this.RaisePropertyChanged("MonthsAtEmployer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=14)]
        public string IncomeFrequency {
            get {
                return this.IncomeFrequencyField;
            }
            set {
                if ((object.ReferenceEquals(this.IncomeFrequencyField, value) != true)) {
                    this.IncomeFrequencyField = value;
                    this.RaisePropertyChanged("IncomeFrequency");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=15)]
        public int MonthlyIncome {
            get {
                return this.MonthlyIncomeField;
            }
            set {
                if ((this.MonthlyIncomeField.Equals(value) != true)) {
                    this.MonthlyIncomeField = value;
                    this.RaisePropertyChanged("MonthlyIncome");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=16)]
        public string EmploymentStatus {
            get {
                return this.EmploymentStatusField;
            }
            set {
                if ((object.ReferenceEquals(this.EmploymentStatusField, value) != true)) {
                    this.EmploymentStatusField = value;
                    this.RaisePropertyChanged("EmploymentStatus");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=17)]
        public bool DirectDeposit {
            get {
                return this.DirectDepositField;
            }
            set {
                if ((this.DirectDepositField.Equals(value) != true)) {
                    this.DirectDepositField = value;
                    this.RaisePropertyChanged("DirectDeposit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=18)]
        public string BankAccountNumber {
            get {
                return this.BankAccountNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.BankAccountNumberField, value) != true)) {
                    this.BankAccountNumberField = value;
                    this.RaisePropertyChanged("BankAccountNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=19)]
        public string BankSortcode {
            get {
                return this.BankSortcodeField;
            }
            set {
                if ((object.ReferenceEquals(this.BankSortcodeField, value) != true)) {
                    this.BankSortcodeField = value;
                    this.RaisePropertyChanged("BankSortcode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=20)]
        public string HomePhone {
            get {
                return this.HomePhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.HomePhoneField, value) != true)) {
                    this.HomePhoneField = value;
                    this.RaisePropertyChanged("HomePhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=21)]
        public string WorkPhone {
            get {
                return this.WorkPhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.WorkPhoneField, value) != true)) {
                    this.WorkPhoneField = value;
                    this.RaisePropertyChanged("WorkPhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=22)]
        public string MobilePhone {
            get {
                return this.MobilePhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.MobilePhoneField, value) != true)) {
                    this.MobilePhoneField = value;
                    this.RaisePropertyChanged("MobilePhone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=23)]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=24)]
        public System.DateTime ApplicationDate {
            get {
                return this.ApplicationDateField;
            }
            set {
                if ((this.ApplicationDateField.Equals(value) != true)) {
                    this.ApplicationDateField = value;
                    this.RaisePropertyChanged("ApplicationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=25)]
        public string Source {
            get {
                return this.SourceField;
            }
            set {
                if ((object.ReferenceEquals(this.SourceField, value) != true)) {
                    this.SourceField = value;
                    this.RaisePropertyChanged("Source");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=26)]
        public string SubSource {
            get {
                return this.SubSourceField;
            }
            set {
                if ((object.ReferenceEquals(this.SubSourceField, value) != true)) {
                    this.SubSourceField = value;
                    this.RaisePropertyChanged("SubSource");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=27)]
        public string IpAddress {
            get {
                return this.IpAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.IpAddressField, value) != true)) {
                    this.IpAddressField = value;
                    this.RaisePropertyChanged("IpAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=28)]
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
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=29)]
        public int LoanAmount {
            get {
                return this.LoanAmountField;
            }
            set {
                if ((this.LoanAmountField.Equals(value) != true)) {
                    this.LoanAmountField = value;
                    this.RaisePropertyChanged("LoanAmount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=30)]
        public string DebitCardType {
            get {
                return this.DebitCardTypeField;
            }
            set {
                if ((object.ReferenceEquals(this.DebitCardTypeField, value) != true)) {
                    this.DebitCardTypeField = value;
                    this.RaisePropertyChanged("DebitCardType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=31)]
        public System.DateTime PaybackDate {
            get {
                return this.PaybackDateField;
            }
            set {
                if ((this.PaybackDateField.Equals(value) != true)) {
                    this.PaybackDateField = value;
                    this.RaisePropertyChanged("PaybackDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=32)]
        public string SellerName {
            get {
                return this.SellerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SellerNameField, value) != true)) {
                    this.SellerNameField = value;
                    this.RaisePropertyChanged("SellerName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SellLeadResponse", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class SellLeadResponse : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private EpPingtree.Web.PingtreeWebservice.ESellLeadResponse ResultField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EpPingtree.Web.PingtreeWebservice.FailureReasons ErrorMessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AcceptedLenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RedirectUrlField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReferenceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public EpPingtree.Web.PingtreeWebservice.ESellLeadResponse Result {
            get {
                return this.ResultField;
            }
            set {
                if ((this.ResultField.Equals(value) != true)) {
                    this.ResultField = value;
                    this.RaisePropertyChanged("Result");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public EpPingtree.Web.PingtreeWebservice.FailureReasons ErrorMessage {
            get {
                return this.ErrorMessageField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorMessageField, value) != true)) {
                    this.ErrorMessageField = value;
                    this.RaisePropertyChanged("ErrorMessage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string AcceptedLender {
            get {
                return this.AcceptedLenderField;
            }
            set {
                if ((object.ReferenceEquals(this.AcceptedLenderField, value) != true)) {
                    this.AcceptedLenderField = value;
                    this.RaisePropertyChanged("AcceptedLender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string RedirectUrl {
            get {
                return this.RedirectUrlField;
            }
            set {
                if ((object.ReferenceEquals(this.RedirectUrlField, value) != true)) {
                    this.RedirectUrlField = value;
                    this.RaisePropertyChanged("RedirectUrl");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Reference {
            get {
                return this.ReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ReferenceField, value) != true)) {
                    this.ReferenceField = value;
                    this.RaisePropertyChanged("Reference");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="FailureReasons", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class FailureReasons : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private EpPingtree.Web.PingtreeWebservice.ErrorReason[] ErrorReasonsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public EpPingtree.Web.PingtreeWebservice.ErrorReason[] ErrorReasons {
            get {
                return this.ErrorReasonsField;
            }
            set {
                if ((object.ReferenceEquals(this.ErrorReasonsField, value) != true)) {
                    this.ErrorReasonsField = value;
                    this.RaisePropertyChanged("ErrorReasons");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ESellLeadResponse", Namespace="http://tempuri.org/")]
    public enum ESellLeadResponse : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Accepted = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Rejected = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Invalid = 2,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ErrorReason", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class ErrorReason : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FieldField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ReasonField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Field {
            get {
                return this.FieldField;
            }
            set {
                if ((object.ReferenceEquals(this.FieldField, value) != true)) {
                    this.FieldField = value;
                    this.RaisePropertyChanged("Field");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Reason {
            get {
                return this.ReasonField;
            }
            set {
                if ((object.ReferenceEquals(this.ReasonField, value) != true)) {
                    this.ReasonField = value;
                    this.RaisePropertyChanged("Reason");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PingtreeWebservice.ServiceSoap")]
    public interface ServiceSoap {
        
        // CODEGEN: Generating message contract since element name request from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SubmitLead", ReplyAction="*")]
        EpPingtree.Web.PingtreeWebservice.SubmitLeadResponse SubmitLead(EpPingtree.Web.PingtreeWebservice.SubmitLeadRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubmitLeadRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SubmitLead", Namespace="http://tempuri.org/", Order=0)]
        public EpPingtree.Web.PingtreeWebservice.SubmitLeadRequestBody Body;
        
        public SubmitLeadRequest() {
        }
        
        public SubmitLeadRequest(EpPingtree.Web.PingtreeWebservice.SubmitLeadRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SubmitLeadRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public EpPingtree.Web.PingtreeWebservice.LeadRequest request;
        
        public SubmitLeadRequestBody() {
        }
        
        public SubmitLeadRequestBody(EpPingtree.Web.PingtreeWebservice.LeadRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SubmitLeadResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SubmitLeadResponse", Namespace="http://tempuri.org/", Order=0)]
        public EpPingtree.Web.PingtreeWebservice.SubmitLeadResponseBody Body;
        
        public SubmitLeadResponse() {
        }
        
        public SubmitLeadResponse(EpPingtree.Web.PingtreeWebservice.SubmitLeadResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SubmitLeadResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public EpPingtree.Web.PingtreeWebservice.SellLeadResponse SubmitLeadResult;
        
        public SubmitLeadResponseBody() {
        }
        
        public SubmitLeadResponseBody(EpPingtree.Web.PingtreeWebservice.SellLeadResponse SubmitLeadResult) {
            this.SubmitLeadResult = SubmitLeadResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ServiceSoapChannel : EpPingtree.Web.PingtreeWebservice.ServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSoapClient : System.ServiceModel.ClientBase<EpPingtree.Web.PingtreeWebservice.ServiceSoap>, EpPingtree.Web.PingtreeWebservice.ServiceSoap {
        
        public ServiceSoapClient() {
        }
        
        public ServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        EpPingtree.Web.PingtreeWebservice.SubmitLeadResponse EpPingtree.Web.PingtreeWebservice.ServiceSoap.SubmitLead(EpPingtree.Web.PingtreeWebservice.SubmitLeadRequest request) {
            return base.Channel.SubmitLead(request);
        }
        
        public EpPingtree.Web.PingtreeWebservice.SellLeadResponse SubmitLead(EpPingtree.Web.PingtreeWebservice.LeadRequest request) {
            EpPingtree.Web.PingtreeWebservice.SubmitLeadRequest inValue = new EpPingtree.Web.PingtreeWebservice.SubmitLeadRequest();
            inValue.Body = new EpPingtree.Web.PingtreeWebservice.SubmitLeadRequestBody();
            inValue.Body.request = request;
            EpPingtree.Web.PingtreeWebservice.SubmitLeadResponse retVal = ((EpPingtree.Web.PingtreeWebservice.ServiceSoap)(this)).SubmitLead(inValue);
            return retVal.Body.SubmitLeadResult;
        }
    }
}
