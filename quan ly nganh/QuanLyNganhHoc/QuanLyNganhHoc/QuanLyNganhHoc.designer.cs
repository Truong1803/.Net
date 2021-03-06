﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyNganhHoc
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="QLNganh")]
	public partial class QuanLyNganhHocDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertNganh(Nganh instance);
    partial void UpdateNganh(Nganh instance);
    partial void DeleteNganh(Nganh instance);
    #endregion
		
		public QuanLyNganhHocDataContext() : 
				base(global::QuanLyNganhHoc.Properties.Settings.Default.QLNganhConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyNganhHocDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyNganhHocDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyNganhHocDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public QuanLyNganhHocDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Nganh> Nganhs
		{
			get
			{
				return this.GetTable<Nganh>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Nganh")]
	public partial class Nganh : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MaNganh;
		
		private string _TenNganhTA;
		
		private string _TenNganhTV;
		
		private string _KhoaQuanLy;
		
		private System.DateTime _NgayMo;
		
		private string _MoTa;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaNganhChanging(string value);
    partial void OnMaNganhChanged();
    partial void OnTenNganhTAChanging(string value);
    partial void OnTenNganhTAChanged();
    partial void OnTenNganhTVChanging(string value);
    partial void OnTenNganhTVChanged();
    partial void OnKhoaQuanLyChanging(string value);
    partial void OnKhoaQuanLyChanged();
    partial void OnNgayMoChanging(System.DateTime value);
    partial void OnNgayMoChanged();
    partial void OnMoTaChanging(string value);
    partial void OnMoTaChanged();
    #endregion
		
		public Nganh()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaNganh", DbType="Char(5) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MaNganh
		{
			get
			{
				return this._MaNganh;
			}
			set
			{
				if ((this._MaNganh != value))
				{
					this.OnMaNganhChanging(value);
					this.SendPropertyChanging();
					this._MaNganh = value;
					this.SendPropertyChanged("MaNganh");
					this.OnMaNganhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNganhTA", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNganhTA
		{
			get
			{
				return this._TenNganhTA;
			}
			set
			{
				if ((this._TenNganhTA != value))
				{
					this.OnTenNganhTAChanging(value);
					this.SendPropertyChanging();
					this._TenNganhTA = value;
					this.SendPropertyChanged("TenNganhTA");
					this.OnTenNganhTAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenNganhTV", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TenNganhTV
		{
			get
			{
				return this._TenNganhTV;
			}
			set
			{
				if ((this._TenNganhTV != value))
				{
					this.OnTenNganhTVChanging(value);
					this.SendPropertyChanging();
					this._TenNganhTV = value;
					this.SendPropertyChanged("TenNganhTV");
					this.OnTenNganhTVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KhoaQuanLy", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string KhoaQuanLy
		{
			get
			{
				return this._KhoaQuanLy;
			}
			set
			{
				if ((this._KhoaQuanLy != value))
				{
					this.OnKhoaQuanLyChanging(value);
					this.SendPropertyChanging();
					this._KhoaQuanLy = value;
					this.SendPropertyChanged("KhoaQuanLy");
					this.OnKhoaQuanLyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayMo", DbType="Date NOT NULL")]
		public System.DateTime NgayMo
		{
			get
			{
				return this._NgayMo;
			}
			set
			{
				if ((this._NgayMo != value))
				{
					this.OnNgayMoChanging(value);
					this.SendPropertyChanging();
					this._NgayMo = value;
					this.SendPropertyChanged("NgayMo");
					this.OnNgayMoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MoTa", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MoTa
		{
			get
			{
				return this._MoTa;
			}
			set
			{
				if ((this._MoTa != value))
				{
					this.OnMoTaChanging(value);
					this.SendPropertyChanging();
					this._MoTa = value;
					this.SendPropertyChanged("MoTa");
					this.OnMoTaChanged();
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
