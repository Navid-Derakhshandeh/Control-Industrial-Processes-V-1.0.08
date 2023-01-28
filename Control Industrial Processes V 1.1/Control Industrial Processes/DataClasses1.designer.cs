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

namespace Control_Industrial_Processes
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Industrial")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCIP(CIP instance);
    partial void UpdateCIP(CIP instance);
    partial void DeleteCIP(CIP instance);
    partial void InsertEfficiency(Efficiency instance);
    partial void UpdateEfficiency(Efficiency instance);
    partial void DeleteEfficiency(Efficiency instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Control_Industrial_Processes.Properties.Settings.Default.IndustrialConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CIP> CIPs
		{
			get
			{
				return this.GetTable<CIP>();
			}
		}
		
		public System.Data.Linq.Table<Efficiency> Efficiencies
		{
			get
			{
				return this.GetTable<Efficiency>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CIP")]
	public partial class CIP : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Issue;
		
		private System.DateTime _Date_Added;
		
		private string _Type;
		
		private string _Des;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnIssueChanging(string value);
    partial void OnIssueChanged();
    partial void OnDate_AddedChanging(System.DateTime value);
    partial void OnDate_AddedChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnDesChanging(string value);
    partial void OnDesChanged();
    #endregion
		
		public CIP()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Issue", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Issue
		{
			get
			{
				return this._Issue;
			}
			set
			{
				if ((this._Issue != value))
				{
					this.OnIssueChanging(value);
					this.SendPropertyChanging();
					this._Issue = value;
					this.SendPropertyChanged("Issue");
					this.OnIssueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date_Added", DbType="DateTime NOT NULL")]
		public System.DateTime Date_Added
		{
			get
			{
				return this._Date_Added;
			}
			set
			{
				if ((this._Date_Added != value))
				{
					this.OnDate_AddedChanging(value);
					this.SendPropertyChanging();
					this._Date_Added = value;
					this.SendPropertyChanged("Date_Added");
					this.OnDate_AddedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(200)")]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Des", DbType="VarChar(MAX)")]
		public string Des
		{
			get
			{
				return this._Des;
			}
			set
			{
				if ((this._Des != value))
				{
					this.OnDesChanging(value);
					this.SendPropertyChanging();
					this._Des = value;
					this.SendPropertyChanged("Des");
					this.OnDesChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Efficiency")]
	public partial class Efficiency : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private System.DateTime _Date;
		
		private int _Water;
		
		private int _Gas;
		
		private int _Power;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    partial void OnWaterChanging(int value);
    partial void OnWaterChanged();
    partial void OnGasChanging(int value);
    partial void OnGasChanged();
    partial void OnPowerChanging(int value);
    partial void OnPowerChanged();
    #endregion
		
		public Efficiency()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Water", DbType="Int NOT NULL")]
		public int Water
		{
			get
			{
				return this._Water;
			}
			set
			{
				if ((this._Water != value))
				{
					this.OnWaterChanging(value);
					this.SendPropertyChanging();
					this._Water = value;
					this.SendPropertyChanged("Water");
					this.OnWaterChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Gas", DbType="Int NOT NULL")]
		public int Gas
		{
			get
			{
				return this._Gas;
			}
			set
			{
				if ((this._Gas != value))
				{
					this.OnGasChanging(value);
					this.SendPropertyChanging();
					this._Gas = value;
					this.SendPropertyChanged("Gas");
					this.OnGasChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Power", DbType="Int NOT NULL")]
		public int Power
		{
			get
			{
				return this._Power;
			}
			set
			{
				if ((this._Power != value))
				{
					this.OnPowerChanging(value);
					this.SendPropertyChanging();
					this._Power = value;
					this.SendPropertyChanged("Power");
					this.OnPowerChanged();
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
