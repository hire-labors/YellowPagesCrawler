﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YellowPagesCrawler
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WhatsUp")]
	public partial class SQLDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertBusiness(Business instance);
    partial void UpdateBusiness(Business instance);
    partial void DeleteBusiness(Business instance);
    partial void InsertBusinessTemp(BusinessTemp instance);
    partial void UpdateBusinessTemp(BusinessTemp instance);
    partial void DeleteBusinessTemp(BusinessTemp instance);
    partial void InsertAddress(Address instance);
    partial void UpdateAddress(Address instance);
    partial void DeleteAddress(Address instance);
    #endregion
		
		public SQLDataContext() : 
				base(global::YellowPagesCrawler.Properties.Settings.Default.WhatsUpConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SQLDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Business> Businesses
		{
			get
			{
				return this.GetTable<Business>();
			}
		}
		
		public System.Data.Linq.Table<BusinessTemp> BusinessTemps
		{
			get
			{
				return this.GetTable<BusinessTemp>();
			}
		}
		
		public System.Data.Linq.Table<Address> Addresses
		{
			get
			{
				return this.GetTable<Address>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Business")]
	public partial class Business : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.Nullable<int> _CategoryID;
		
		private string _CompanyName;
		
		private int _AddressID1;
		
		private System.Nullable<int> _AddressID2;
		
		private System.Nullable<int> _AddressCorporateID1;
		
		private System.Nullable<int> _AddressCorporateID2;
		
		private string _Email;
		
		private string _Phone;
		
		private string _TollFreePhone;
		
		private string _Fax;
		
		private string _WebSite;
		
		private string _Facebook;
		
		private string _Skype;
		
		private System.Nullable<int> _ManagerContactID;
		
		private System.Nullable<int> _OwnerContactID;
		
		private System.Nullable<int> _OtherContactID;
		
		private string _EstablishedIn;
		
		private System.Nullable<int> _EmployeeCount;
		
		private string _PaymentOptions;
		
		private string _HoursOfOperation;
		
		private string _BusinessTrend;
		
		private System.DateTime _DateCreated;
		
		private System.Nullable<bool> _Verified;
		
		private string _Notes;
		
		private EntityRef<Address> _Address;
		
		private EntityRef<Address> _Address1;
		
		private EntityRef<Address> _Address2;
		
		private EntityRef<Address> _Address3;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCategoryIDChanging(System.Nullable<int> value);
    partial void OnCategoryIDChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnAddressID1Changing(int value);
    partial void OnAddressID1Changed();
    partial void OnAddressID2Changing(System.Nullable<int> value);
    partial void OnAddressID2Changed();
    partial void OnAddressCorporateID1Changing(System.Nullable<int> value);
    partial void OnAddressCorporateID1Changed();
    partial void OnAddressCorporateID2Changing(System.Nullable<int> value);
    partial void OnAddressCorporateID2Changed();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnTollFreePhoneChanging(string value);
    partial void OnTollFreePhoneChanged();
    partial void OnFaxChanging(string value);
    partial void OnFaxChanged();
    partial void OnWebSiteChanging(string value);
    partial void OnWebSiteChanged();
    partial void OnFacebookChanging(string value);
    partial void OnFacebookChanged();
    partial void OnSkypeChanging(string value);
    partial void OnSkypeChanged();
    partial void OnManagerContactIDChanging(System.Nullable<int> value);
    partial void OnManagerContactIDChanged();
    partial void OnOwnerContactIDChanging(System.Nullable<int> value);
    partial void OnOwnerContactIDChanged();
    partial void OnOtherContactIDChanging(System.Nullable<int> value);
    partial void OnOtherContactIDChanged();
    partial void OnEstablishedInChanging(string value);
    partial void OnEstablishedInChanged();
    partial void OnEmployeeCountChanging(System.Nullable<int> value);
    partial void OnEmployeeCountChanged();
    partial void OnPaymentOptionsChanging(string value);
    partial void OnPaymentOptionsChanged();
    partial void OnHoursOfOperationChanging(string value);
    partial void OnHoursOfOperationChanged();
    partial void OnBusinessTrendChanging(string value);
    partial void OnBusinessTrendChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    partial void OnVerifiedChanging(System.Nullable<bool> value);
    partial void OnVerifiedChanged();
    partial void OnNotesChanging(string value);
    partial void OnNotesChanged();
    #endregion
		
		public Business()
		{
			this._Address = default(EntityRef<Address>);
			this._Address1 = default(EntityRef<Address>);
			this._Address2 = default(EntityRef<Address>);
			this._Address3 = default(EntityRef<Address>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryID", DbType="Int")]
		public System.Nullable<int> CategoryID
		{
			get
			{
				return this._CategoryID;
			}
			set
			{
				if ((this._CategoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._CategoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressID1", DbType="Int NOT NULL")]
		public int AddressID1
		{
			get
			{
				return this._AddressID1;
			}
			set
			{
				if ((this._AddressID1 != value))
				{
					if (this._Address.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAddressID1Changing(value);
					this.SendPropertyChanging();
					this._AddressID1 = value;
					this.SendPropertyChanged("AddressID1");
					this.OnAddressID1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressID2", DbType="Int")]
		public System.Nullable<int> AddressID2
		{
			get
			{
				return this._AddressID2;
			}
			set
			{
				if ((this._AddressID2 != value))
				{
					if (this._Address1.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAddressID2Changing(value);
					this.SendPropertyChanging();
					this._AddressID2 = value;
					this.SendPropertyChanged("AddressID2");
					this.OnAddressID2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressCorporateID1", DbType="Int")]
		public System.Nullable<int> AddressCorporateID1
		{
			get
			{
				return this._AddressCorporateID1;
			}
			set
			{
				if ((this._AddressCorporateID1 != value))
				{
					if (this._Address2.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAddressCorporateID1Changing(value);
					this.SendPropertyChanging();
					this._AddressCorporateID1 = value;
					this.SendPropertyChanged("AddressCorporateID1");
					this.OnAddressCorporateID1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddressCorporateID2", DbType="Int")]
		public System.Nullable<int> AddressCorporateID2
		{
			get
			{
				return this._AddressCorporateID2;
			}
			set
			{
				if ((this._AddressCorporateID2 != value))
				{
					if (this._Address3.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnAddressCorporateID2Changing(value);
					this.SendPropertyChanging();
					this._AddressCorporateID2 = value;
					this.SendPropertyChanged("AddressCorporateID2");
					this.OnAddressCorporateID2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(250)")]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TollFreePhone", DbType="VarChar(50)")]
		public string TollFreePhone
		{
			get
			{
				return this._TollFreePhone;
			}
			set
			{
				if ((this._TollFreePhone != value))
				{
					this.OnTollFreePhoneChanging(value);
					this.SendPropertyChanging();
					this._TollFreePhone = value;
					this.SendPropertyChanged("TollFreePhone");
					this.OnTollFreePhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fax", DbType="VarChar(50)")]
		public string Fax
		{
			get
			{
				return this._Fax;
			}
			set
			{
				if ((this._Fax != value))
				{
					this.OnFaxChanging(value);
					this.SendPropertyChanging();
					this._Fax = value;
					this.SendPropertyChanged("Fax");
					this.OnFaxChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WebSite", DbType="VarChar(500)")]
		public string WebSite
		{
			get
			{
				return this._WebSite;
			}
			set
			{
				if ((this._WebSite != value))
				{
					this.OnWebSiteChanging(value);
					this.SendPropertyChanging();
					this._WebSite = value;
					this.SendPropertyChanged("WebSite");
					this.OnWebSiteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Facebook", DbType="VarChar(500)")]
		public string Facebook
		{
			get
			{
				return this._Facebook;
			}
			set
			{
				if ((this._Facebook != value))
				{
					this.OnFacebookChanging(value);
					this.SendPropertyChanging();
					this._Facebook = value;
					this.SendPropertyChanged("Facebook");
					this.OnFacebookChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Skype", DbType="VarChar(200)")]
		public string Skype
		{
			get
			{
				return this._Skype;
			}
			set
			{
				if ((this._Skype != value))
				{
					this.OnSkypeChanging(value);
					this.SendPropertyChanging();
					this._Skype = value;
					this.SendPropertyChanged("Skype");
					this.OnSkypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ManagerContactID", DbType="Int")]
		public System.Nullable<int> ManagerContactID
		{
			get
			{
				return this._ManagerContactID;
			}
			set
			{
				if ((this._ManagerContactID != value))
				{
					this.OnManagerContactIDChanging(value);
					this.SendPropertyChanging();
					this._ManagerContactID = value;
					this.SendPropertyChanged("ManagerContactID");
					this.OnManagerContactIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OwnerContactID", DbType="Int")]
		public System.Nullable<int> OwnerContactID
		{
			get
			{
				return this._OwnerContactID;
			}
			set
			{
				if ((this._OwnerContactID != value))
				{
					this.OnOwnerContactIDChanging(value);
					this.SendPropertyChanging();
					this._OwnerContactID = value;
					this.SendPropertyChanged("OwnerContactID");
					this.OnOwnerContactIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_OtherContactID", DbType="Int")]
		public System.Nullable<int> OtherContactID
		{
			get
			{
				return this._OtherContactID;
			}
			set
			{
				if ((this._OtherContactID != value))
				{
					this.OnOtherContactIDChanging(value);
					this.SendPropertyChanging();
					this._OtherContactID = value;
					this.SendPropertyChanged("OtherContactID");
					this.OnOtherContactIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EstablishedIn", DbType="VarChar(50)")]
		public string EstablishedIn
		{
			get
			{
				return this._EstablishedIn;
			}
			set
			{
				if ((this._EstablishedIn != value))
				{
					this.OnEstablishedInChanging(value);
					this.SendPropertyChanging();
					this._EstablishedIn = value;
					this.SendPropertyChanged("EstablishedIn");
					this.OnEstablishedInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeCount", DbType="Int")]
		public System.Nullable<int> EmployeeCount
		{
			get
			{
				return this._EmployeeCount;
			}
			set
			{
				if ((this._EmployeeCount != value))
				{
					this.OnEmployeeCountChanging(value);
					this.SendPropertyChanging();
					this._EmployeeCount = value;
					this.SendPropertyChanged("EmployeeCount");
					this.OnEmployeeCountChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaymentOptions", DbType="VarChar(MAX)")]
		public string PaymentOptions
		{
			get
			{
				return this._PaymentOptions;
			}
			set
			{
				if ((this._PaymentOptions != value))
				{
					this.OnPaymentOptionsChanging(value);
					this.SendPropertyChanging();
					this._PaymentOptions = value;
					this.SendPropertyChanged("PaymentOptions");
					this.OnPaymentOptionsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoursOfOperation", DbType="VarChar(MAX)")]
		public string HoursOfOperation
		{
			get
			{
				return this._HoursOfOperation;
			}
			set
			{
				if ((this._HoursOfOperation != value))
				{
					this.OnHoursOfOperationChanging(value);
					this.SendPropertyChanging();
					this._HoursOfOperation = value;
					this.SendPropertyChanged("HoursOfOperation");
					this.OnHoursOfOperationChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessTrend", DbType="VarChar(100)")]
		public string BusinessTrend
		{
			get
			{
				return this._BusinessTrend;
			}
			set
			{
				if ((this._BusinessTrend != value))
				{
					this.OnBusinessTrendChanging(value);
					this.SendPropertyChanging();
					this._BusinessTrend = value;
					this.SendPropertyChanged("BusinessTrend");
					this.OnBusinessTrendChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Verified", DbType="Bit")]
		public System.Nullable<bool> Verified
		{
			get
			{
				return this._Verified;
			}
			set
			{
				if ((this._Verified != value))
				{
					this.OnVerifiedChanging(value);
					this.SendPropertyChanging();
					this._Verified = value;
					this.SendPropertyChanged("Verified");
					this.OnVerifiedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Notes", DbType="VarChar(MAX)")]
		public string Notes
		{
			get
			{
				return this._Notes;
			}
			set
			{
				if ((this._Notes != value))
				{
					this.OnNotesChanging(value);
					this.SendPropertyChanging();
					this._Notes = value;
					this.SendPropertyChanged("Notes");
					this.OnNotesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Address_Business", Storage="_Address", ThisKey="AddressID1", OtherKey="ID", IsForeignKey=true)]
		public Address Address
		{
			get
			{
				return this._Address.Entity;
			}
			set
			{
				Address previousValue = this._Address.Entity;
				if (((previousValue != value) 
							|| (this._Address.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Address.Entity = null;
						previousValue.Businesses.Remove(this);
					}
					this._Address.Entity = value;
					if ((value != null))
					{
						value.Businesses.Add(this);
						this._AddressID1 = value.ID;
					}
					else
					{
						this._AddressID1 = default(int);
					}
					this.SendPropertyChanged("Address");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Address_Business1", Storage="_Address1", ThisKey="AddressID2", OtherKey="ID", IsForeignKey=true)]
		public Address Address1
		{
			get
			{
				return this._Address1.Entity;
			}
			set
			{
				Address previousValue = this._Address1.Entity;
				if (((previousValue != value) 
							|| (this._Address1.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Address1.Entity = null;
						previousValue.Businesses1.Remove(this);
					}
					this._Address1.Entity = value;
					if ((value != null))
					{
						value.Businesses1.Add(this);
						this._AddressID2 = value.ID;
					}
					else
					{
						this._AddressID2 = default(Nullable<int>);
					}
					this.SendPropertyChanged("Address1");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Address_Business2", Storage="_Address2", ThisKey="AddressCorporateID1", OtherKey="ID", IsForeignKey=true)]
		public Address Address2
		{
			get
			{
				return this._Address2.Entity;
			}
			set
			{
				Address previousValue = this._Address2.Entity;
				if (((previousValue != value) 
							|| (this._Address2.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Address2.Entity = null;
						previousValue.Businesses2.Remove(this);
					}
					this._Address2.Entity = value;
					if ((value != null))
					{
						value.Businesses2.Add(this);
						this._AddressCorporateID1 = value.ID;
					}
					else
					{
						this._AddressCorporateID1 = default(Nullable<int>);
					}
					this.SendPropertyChanged("Address2");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Address_Business3", Storage="_Address3", ThisKey="AddressCorporateID2", OtherKey="ID", IsForeignKey=true)]
		public Address Address3
		{
			get
			{
				return this._Address3.Entity;
			}
			set
			{
				Address previousValue = this._Address3.Entity;
				if (((previousValue != value) 
							|| (this._Address3.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Address3.Entity = null;
						previousValue.Businesses3.Remove(this);
					}
					this._Address3.Entity = value;
					if ((value != null))
					{
						value.Businesses3.Add(this);
						this._AddressCorporateID2 = value.ID;
					}
					else
					{
						this._AddressCorporateID2 = default(Nullable<int>);
					}
					this.SendPropertyChanged("Address3");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.BusinessTemp")]
	public partial class BusinessTemp : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _CompanyName;
		
		private string _Phone;
		
		private string _BusinessTrend;
		
		private string _Street;
		
		private string _City;
		
		private string _State;
		
		private string _Zip;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCompanyNameChanging(string value);
    partial void OnCompanyNameChanged();
    partial void OnPhoneChanging(string value);
    partial void OnPhoneChanged();
    partial void OnBusinessTrendChanging(string value);
    partial void OnBusinessTrendChanged();
    partial void OnStreetChanging(string value);
    partial void OnStreetChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnZipChanging(string value);
    partial void OnZipChanged();
    #endregion
		
		public BusinessTemp()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CompanyName", DbType="VarChar(200)")]
		public string CompanyName
		{
			get
			{
				return this._CompanyName;
			}
			set
			{
				if ((this._CompanyName != value))
				{
					this.OnCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._CompanyName = value;
					this.SendPropertyChanged("CompanyName");
					this.OnCompanyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phone", DbType="VarChar(50)")]
		public string Phone
		{
			get
			{
				return this._Phone;
			}
			set
			{
				if ((this._Phone != value))
				{
					this.OnPhoneChanging(value);
					this.SendPropertyChanging();
					this._Phone = value;
					this.SendPropertyChanged("Phone");
					this.OnPhoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BusinessTrend", DbType="VarChar(200)")]
		public string BusinessTrend
		{
			get
			{
				return this._BusinessTrend;
			}
			set
			{
				if ((this._BusinessTrend != value))
				{
					this.OnBusinessTrendChanging(value);
					this.SendPropertyChanging();
					this._BusinessTrend = value;
					this.SendPropertyChanged("BusinessTrend");
					this.OnBusinessTrendChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="VarChar(200)")]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this.OnStreetChanging(value);
					this.SendPropertyChanging();
					this._Street = value;
					this.SendPropertyChanged("Street");
					this.OnStreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(100)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(2)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="VarChar(20)")]
		public string Zip
		{
			get
			{
				return this._Zip;
			}
			set
			{
				if ((this._Zip != value))
				{
					this.OnZipChanging(value);
					this.SendPropertyChanging();
					this._Zip = value;
					this.SendPropertyChanged("Zip");
					this.OnZipChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Address")]
	public partial class Address : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Street;
		
		private string _City;
		
		private string _State;
		
		private System.DateTime _DateCreated;
		
		private string _Zip;
		
		private EntitySet<Business> _Businesses;
		
		private EntitySet<Business> _Businesses1;
		
		private EntitySet<Business> _Businesses2;
		
		private EntitySet<Business> _Businesses3;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnStreetChanging(string value);
    partial void OnStreetChanged();
    partial void OnCityChanging(string value);
    partial void OnCityChanged();
    partial void OnStateChanging(string value);
    partial void OnStateChanged();
    partial void OnDateCreatedChanging(System.DateTime value);
    partial void OnDateCreatedChanged();
    partial void OnZipChanging(string value);
    partial void OnZipChanged();
    #endregion
		
		public Address()
		{
			this._Businesses = new EntitySet<Business>(new Action<Business>(this.attach_Businesses), new Action<Business>(this.detach_Businesses));
			this._Businesses1 = new EntitySet<Business>(new Action<Business>(this.attach_Businesses1), new Action<Business>(this.detach_Businesses1));
			this._Businesses2 = new EntitySet<Business>(new Action<Business>(this.attach_Businesses2), new Action<Business>(this.detach_Businesses2));
			this._Businesses3 = new EntitySet<Business>(new Action<Business>(this.attach_Businesses3), new Action<Business>(this.detach_Businesses3));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Street", DbType="VarChar(100)")]
		public string Street
		{
			get
			{
				return this._Street;
			}
			set
			{
				if ((this._Street != value))
				{
					this.OnStreetChanging(value);
					this.SendPropertyChanging();
					this._Street = value;
					this.SendPropertyChanged("Street");
					this.OnStreetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_City", DbType="VarChar(100)")]
		public string City
		{
			get
			{
				return this._City;
			}
			set
			{
				if ((this._City != value))
				{
					this.OnCityChanging(value);
					this.SendPropertyChanging();
					this._City = value;
					this.SendPropertyChanged("City");
					this.OnCityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_State", DbType="VarChar(2)")]
		public string State
		{
			get
			{
				return this._State;
			}
			set
			{
				if ((this._State != value))
				{
					this.OnStateChanging(value);
					this.SendPropertyChanging();
					this._State = value;
					this.SendPropertyChanged("State");
					this.OnStateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DateCreated", DbType="DateTime NOT NULL")]
		public System.DateTime DateCreated
		{
			get
			{
				return this._DateCreated;
			}
			set
			{
				if ((this._DateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._DateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Zip", DbType="VarChar(50)")]
		public string Zip
		{
			get
			{
				return this._Zip;
			}
			set
			{
				if ((this._Zip != value))
				{
					this.OnZipChanging(value);
					this.SendPropertyChanging();
					this._Zip = value;
					this.SendPropertyChanged("Zip");
					this.OnZipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Address_Business", Storage="_Businesses", ThisKey="ID", OtherKey="AddressID1")]
		public EntitySet<Business> Businesses
		{
			get
			{
				return this._Businesses;
			}
			set
			{
				this._Businesses.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Address_Business1", Storage="_Businesses1", ThisKey="ID", OtherKey="AddressID2")]
		public EntitySet<Business> Businesses1
		{
			get
			{
				return this._Businesses1;
			}
			set
			{
				this._Businesses1.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Address_Business2", Storage="_Businesses2", ThisKey="ID", OtherKey="AddressCorporateID1")]
		public EntitySet<Business> Businesses2
		{
			get
			{
				return this._Businesses2;
			}
			set
			{
				this._Businesses2.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Address_Business3", Storage="_Businesses3", ThisKey="ID", OtherKey="AddressCorporateID2")]
		public EntitySet<Business> Businesses3
		{
			get
			{
				return this._Businesses3;
			}
			set
			{
				this._Businesses3.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Businesses(Business entity)
		{
			this.SendPropertyChanging();
			entity.Address = this;
		}
		
		private void detach_Businesses(Business entity)
		{
			this.SendPropertyChanging();
			entity.Address = null;
		}
		
		private void attach_Businesses1(Business entity)
		{
			this.SendPropertyChanging();
			entity.Address1 = this;
		}
		
		private void detach_Businesses1(Business entity)
		{
			this.SendPropertyChanging();
			entity.Address1 = null;
		}
		
		private void attach_Businesses2(Business entity)
		{
			this.SendPropertyChanging();
			entity.Address2 = this;
		}
		
		private void detach_Businesses2(Business entity)
		{
			this.SendPropertyChanging();
			entity.Address2 = null;
		}
		
		private void attach_Businesses3(Business entity)
		{
			this.SendPropertyChanging();
			entity.Address3 = this;
		}
		
		private void detach_Businesses3(Business entity)
		{
			this.SendPropertyChanging();
			entity.Address3 = null;
		}
	}
}
#pragma warning restore 1591