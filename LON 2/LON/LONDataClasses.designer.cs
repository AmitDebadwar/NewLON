﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LON
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="LON")]
	public partial class LONDataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMainCategoryMaster(MainCategoryMaster instance);
    partial void UpdateMainCategoryMaster(MainCategoryMaster instance);
    partial void DeleteMainCategoryMaster(MainCategoryMaster instance);
    partial void InsertParentCategoryMaster(ParentCategoryMaster instance);
    partial void UpdateParentCategoryMaster(ParentCategoryMaster instance);
    partial void DeleteParentCategoryMaster(ParentCategoryMaster instance);
    partial void InsertProductMaster(ProductMaster instance);
    partial void UpdateProductMaster(ProductMaster instance);
    partial void DeleteProductMaster(ProductMaster instance);
    #endregion
		
		public LONDataClassesDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["LONConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public LONDataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LONDataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LONDataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LONDataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<MainCategoryMaster> MainCategoryMasters
		{
			get
			{
				return this.GetTable<MainCategoryMaster>();
			}
		}
		
		public System.Data.Linq.Table<ParentCategoryMaster> ParentCategoryMasters
		{
			get
			{
				return this.GetTable<ParentCategoryMaster>();
			}
		}
		
		public System.Data.Linq.Table<ProductMaster> ProductMasters
		{
			get
			{
				return this.GetTable<ProductMaster>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MainCategoryMaster")]
	public partial class MainCategoryMaster : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MainCategoryId;
		
		private string _MainCategoryName;
		
		private string _MainCategoryImage;
		
		private System.DateTime _CreatedDate;
		
		private System.Nullable<System.DateTime> _ModifiedDate;
		
		private string _CreatedBy;
		
		private string _ModifiedBy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMainCategoryIdChanging(int value);
    partial void OnMainCategoryIdChanged();
    partial void OnMainCategoryNameChanging(string value);
    partial void OnMainCategoryNameChanged();
    partial void OnMainCategoryImageChanging(string value);
    partial void OnMainCategoryImageChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    partial void OnModifiedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedDateChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    #endregion
		
		public MainCategoryMaster()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainCategoryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int MainCategoryId
		{
			get
			{
				return this._MainCategoryId;
			}
			set
			{
				if ((this._MainCategoryId != value))
				{
					this.OnMainCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._MainCategoryId = value;
					this.SendPropertyChanged("MainCategoryId");
					this.OnMainCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainCategoryName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string MainCategoryName
		{
			get
			{
				return this._MainCategoryName;
			}
			set
			{
				if ((this._MainCategoryName != value))
				{
					this.OnMainCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._MainCategoryName = value;
					this.SendPropertyChanged("MainCategoryName");
					this.OnMainCategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainCategoryImage", DbType="NVarChar(50)")]
		public string MainCategoryImage
		{
			get
			{
				return this._MainCategoryImage;
			}
			set
			{
				if ((this._MainCategoryImage != value))
				{
					this.OnMainCategoryImageChanging(value);
					this.SendPropertyChanging();
					this._MainCategoryImage = value;
					this.SendPropertyChanged("MainCategoryImage");
					this.OnMainCategoryImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedBy", DbType="NVarChar(50)")]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ParentCategoryMaster")]
	public partial class ParentCategoryMaster : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ParentCategoryId;
		
		private string _ParentCategoryName;
		
		private string _ParentCategoryImage;
		
		private int _MainCategoryId;
		
		private System.DateTime _CreatedDate;
		
		private System.Nullable<System.DateTime> _ModifiedDate;
		
		private string _CreatedBy;
		
		private string _ModifiedBy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnParentCategoryIdChanging(int value);
    partial void OnParentCategoryIdChanged();
    partial void OnParentCategoryNameChanging(string value);
    partial void OnParentCategoryNameChanged();
    partial void OnParentCategoryImageChanging(string value);
    partial void OnParentCategoryImageChanged();
    partial void OnMainCategoryIdChanging(int value);
    partial void OnMainCategoryIdChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    partial void OnModifiedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedDateChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    #endregion
		
		public ParentCategoryMaster()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentCategoryId", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ParentCategoryId
		{
			get
			{
				return this._ParentCategoryId;
			}
			set
			{
				if ((this._ParentCategoryId != value))
				{
					this.OnParentCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._ParentCategoryId = value;
					this.SendPropertyChanged("ParentCategoryId");
					this.OnParentCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentCategoryName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ParentCategoryName
		{
			get
			{
				return this._ParentCategoryName;
			}
			set
			{
				if ((this._ParentCategoryName != value))
				{
					this.OnParentCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._ParentCategoryName = value;
					this.SendPropertyChanged("ParentCategoryName");
					this.OnParentCategoryNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentCategoryImage", DbType="NVarChar(50)")]
		public string ParentCategoryImage
		{
			get
			{
				return this._ParentCategoryImage;
			}
			set
			{
				if ((this._ParentCategoryImage != value))
				{
					this.OnParentCategoryImageChanging(value);
					this.SendPropertyChanging();
					this._ParentCategoryImage = value;
					this.SendPropertyChanged("ParentCategoryImage");
					this.OnParentCategoryImageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MainCategoryId", DbType="Int NOT NULL")]
		public int MainCategoryId
		{
			get
			{
				return this._MainCategoryId;
			}
			set
			{
				if ((this._MainCategoryId != value))
				{
					this.OnMainCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._MainCategoryId = value;
					this.SendPropertyChanged("MainCategoryId");
					this.OnMainCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedBy", DbType="NVarChar(50)")]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ProductMaster")]
	public partial class ProductMaster : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ProductId;
		
		private string _ProductName;
		
		private string _ProductNameAlternate;
		
		private decimal _ProductPrice;
		
		private string _ProductThumbnailImageFileName;
		
		private string _ProductDisplayImageFileName;
		
		private string _ProductDescription;
		
		private int _ParentCategoryId;
		
		private int _ProductStatusId;
		
		private System.DateTime _CreatedDate;
		
		private System.Nullable<System.DateTime> _ModifiedDate;
		
		private string _CreatedBy;
		
		private string _ModifiedBy;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnProductNameChanging(string value);
    partial void OnProductNameChanged();
    partial void OnProductNameAlternateChanging(string value);
    partial void OnProductNameAlternateChanged();
    partial void OnProductPriceChanging(decimal value);
    partial void OnProductPriceChanged();
    partial void OnProductThumbnailImageFileNameChanging(string value);
    partial void OnProductThumbnailImageFileNameChanged();
    partial void OnProductDisplayImageFileNameChanging(string value);
    partial void OnProductDisplayImageFileNameChanged();
    partial void OnProductDescriptionChanging(string value);
    partial void OnProductDescriptionChanged();
    partial void OnParentCategoryIdChanging(int value);
    partial void OnParentCategoryIdChanged();
    partial void OnProductStatusIdChanging(int value);
    partial void OnProductStatusIdChanged();
    partial void OnCreatedDateChanging(System.DateTime value);
    partial void OnCreatedDateChanged();
    partial void OnModifiedDateChanging(System.Nullable<System.DateTime> value);
    partial void OnModifiedDateChanged();
    partial void OnCreatedByChanging(string value);
    partial void OnCreatedByChanged();
    partial void OnModifiedByChanging(string value);
    partial void OnModifiedByChanged();
    #endregion
		
		public ProductMaster()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ProductName
		{
			get
			{
				return this._ProductName;
			}
			set
			{
				if ((this._ProductName != value))
				{
					this.OnProductNameChanging(value);
					this.SendPropertyChanging();
					this._ProductName = value;
					this.SendPropertyChanged("ProductName");
					this.OnProductNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductNameAlternate", DbType="NVarChar(50)")]
		public string ProductNameAlternate
		{
			get
			{
				return this._ProductNameAlternate;
			}
			set
			{
				if ((this._ProductNameAlternate != value))
				{
					this.OnProductNameAlternateChanging(value);
					this.SendPropertyChanging();
					this._ProductNameAlternate = value;
					this.SendPropertyChanged("ProductNameAlternate");
					this.OnProductNameAlternateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductPrice", DbType="Decimal(18,2) NOT NULL")]
		public decimal ProductPrice
		{
			get
			{
				return this._ProductPrice;
			}
			set
			{
				if ((this._ProductPrice != value))
				{
					this.OnProductPriceChanging(value);
					this.SendPropertyChanging();
					this._ProductPrice = value;
					this.SendPropertyChanged("ProductPrice");
					this.OnProductPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductThumbnailImageFileName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ProductThumbnailImageFileName
		{
			get
			{
				return this._ProductThumbnailImageFileName;
			}
			set
			{
				if ((this._ProductThumbnailImageFileName != value))
				{
					this.OnProductThumbnailImageFileNameChanging(value);
					this.SendPropertyChanging();
					this._ProductThumbnailImageFileName = value;
					this.SendPropertyChanged("ProductThumbnailImageFileName");
					this.OnProductThumbnailImageFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductDisplayImageFileName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string ProductDisplayImageFileName
		{
			get
			{
				return this._ProductDisplayImageFileName;
			}
			set
			{
				if ((this._ProductDisplayImageFileName != value))
				{
					this.OnProductDisplayImageFileNameChanging(value);
					this.SendPropertyChanging();
					this._ProductDisplayImageFileName = value;
					this.SendPropertyChanged("ProductDisplayImageFileName");
					this.OnProductDisplayImageFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductDescription", DbType="NVarChar(MAX)")]
		public string ProductDescription
		{
			get
			{
				return this._ProductDescription;
			}
			set
			{
				if ((this._ProductDescription != value))
				{
					this.OnProductDescriptionChanging(value);
					this.SendPropertyChanging();
					this._ProductDescription = value;
					this.SendPropertyChanged("ProductDescription");
					this.OnProductDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ParentCategoryId", DbType="Int NOT NULL")]
		public int ParentCategoryId
		{
			get
			{
				return this._ParentCategoryId;
			}
			set
			{
				if ((this._ParentCategoryId != value))
				{
					this.OnParentCategoryIdChanging(value);
					this.SendPropertyChanging();
					this._ParentCategoryId = value;
					this.SendPropertyChanged("ParentCategoryId");
					this.OnParentCategoryIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductStatusId", DbType="Int NOT NULL")]
		public int ProductStatusId
		{
			get
			{
				return this._ProductStatusId;
			}
			set
			{
				if ((this._ProductStatusId != value))
				{
					this.OnProductStatusIdChanging(value);
					this.SendPropertyChanging();
					this._ProductStatusId = value;
					this.SendPropertyChanged("ProductStatusId");
					this.OnProductStatusIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreatedDate
		{
			get
			{
				return this._CreatedDate;
			}
			set
			{
				if ((this._CreatedDate != value))
				{
					this.OnCreatedDateChanging(value);
					this.SendPropertyChanging();
					this._CreatedDate = value;
					this.SendPropertyChanged("CreatedDate");
					this.OnCreatedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifiedDate
		{
			get
			{
				return this._ModifiedDate;
			}
			set
			{
				if ((this._ModifiedDate != value))
				{
					this.OnModifiedDateChanging(value);
					this.SendPropertyChanging();
					this._ModifiedDate = value;
					this.SendPropertyChanged("ModifiedDate");
					this.OnModifiedDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreatedBy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CreatedBy
		{
			get
			{
				return this._CreatedBy;
			}
			set
			{
				if ((this._CreatedBy != value))
				{
					this.OnCreatedByChanging(value);
					this.SendPropertyChanging();
					this._CreatedBy = value;
					this.SendPropertyChanged("CreatedBy");
					this.OnCreatedByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifiedBy", DbType="NVarChar(50)")]
		public string ModifiedBy
		{
			get
			{
				return this._ModifiedBy;
			}
			set
			{
				if ((this._ModifiedBy != value))
				{
					this.OnModifiedByChanging(value);
					this.SendPropertyChanging();
					this._ModifiedBy = value;
					this.SendPropertyChanged("ModifiedBy");
					this.OnModifiedByChanged();
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
}
#pragma warning restore 1591
