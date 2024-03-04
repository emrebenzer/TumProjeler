﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication16
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DB141111123024")]
	public partial class VerilerDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertIlceler(Ilceler instance);
    partial void UpdateIlceler(Ilceler instance);
    partial void DeleteIlceler(Ilceler instance);
    partial void InsertUlkeler(Ulkeler instance);
    partial void UpdateUlkeler(Ulkeler instance);
    partial void DeleteUlkeler(Ulkeler instance);
    partial void InsertSehirler(Sehirler instance);
    partial void UpdateSehirler(Sehirler instance);
    partial void DeleteSehirler(Sehirler instance);
    partial void InsertSemtMah(SemtMah instance);
    partial void UpdateSemtMah(SemtMah instance);
    partial void DeleteSemtMah(SemtMah instance);
    #endregion
		
		public VerilerDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DB141111123024ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public VerilerDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VerilerDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VerilerDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public VerilerDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Ilceler> Ilcelers
		{
			get
			{
				return this.GetTable<Ilceler>();
			}
		}
		
		public System.Data.Linq.Table<Ulkeler> Ulkelers
		{
			get
			{
				return this.GetTable<Ulkeler>();
			}
		}
		
		public System.Data.Linq.Table<Sehirler> Sehirlers
		{
			get
			{
				return this.GetTable<Sehirler>();
			}
		}
		
		public System.Data.Linq.Table<SemtMah> SemtMahs
		{
			get
			{
				return this.GetTable<SemtMah>();
			}
		}
		
		public System.Data.Linq.Table<ILMESAFESI> ILMESAFESIs
		{
			get
			{
				return this.GetTable<ILMESAFESI>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ilceler")]
	public partial class Ilceler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ilceId;
		
		private int _SehirId;
		
		private string _IlceAdi;
		
		private string _SehirAdi;
		
		private EntitySet<SemtMah> _SemtMahs;
		
		private EntityRef<Sehirler> _Sehirler;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnilceIdChanging(int value);
    partial void OnilceIdChanged();
    partial void OnSehirIdChanging(int value);
    partial void OnSehirIdChanged();
    partial void OnIlceAdiChanging(string value);
    partial void OnIlceAdiChanged();
    partial void OnSehirAdiChanging(string value);
    partial void OnSehirAdiChanged();
    #endregion
		
		public Ilceler()
		{
			this._SemtMahs = new EntitySet<SemtMah>(new Action<SemtMah>(this.attach_SemtMahs), new Action<SemtMah>(this.detach_SemtMahs));
			this._Sehirler = default(EntityRef<Sehirler>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilceId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int ilceId
		{
			get
			{
				return this._ilceId;
			}
			set
			{
				if ((this._ilceId != value))
				{
					this.OnilceIdChanging(value);
					this.SendPropertyChanging();
					this._ilceId = value;
					this.SendPropertyChanged("ilceId");
					this.OnilceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SehirId", DbType="Int NOT NULL")]
		public int SehirId
		{
			get
			{
				return this._SehirId;
			}
			set
			{
				if ((this._SehirId != value))
				{
					if (this._Sehirler.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSehirIdChanging(value);
					this.SendPropertyChanging();
					this._SehirId = value;
					this.SendPropertyChanged("SehirId");
					this.OnSehirIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IlceAdi", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string IlceAdi
		{
			get
			{
				return this._IlceAdi;
			}
			set
			{
				if ((this._IlceAdi != value))
				{
					this.OnIlceAdiChanging(value);
					this.SendPropertyChanging();
					this._IlceAdi = value;
					this.SendPropertyChanged("IlceAdi");
					this.OnIlceAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SehirAdi", DbType="NVarChar(55) NOT NULL", CanBeNull=false)]
		public string SehirAdi
		{
			get
			{
				return this._SehirAdi;
			}
			set
			{
				if ((this._SehirAdi != value))
				{
					this.OnSehirAdiChanging(value);
					this.SendPropertyChanging();
					this._SehirAdi = value;
					this.SendPropertyChanged("SehirAdi");
					this.OnSehirAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ilceler_SemtMah", Storage="_SemtMahs", ThisKey="ilceId", OtherKey="ilceId")]
		public EntitySet<SemtMah> SemtMahs
		{
			get
			{
				return this._SemtMahs;
			}
			set
			{
				this._SemtMahs.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sehirler_Ilceler", Storage="_Sehirler", ThisKey="SehirId", OtherKey="SehirId", IsForeignKey=true)]
		public Sehirler Sehirler
		{
			get
			{
				return this._Sehirler.Entity;
			}
			set
			{
				Sehirler previousValue = this._Sehirler.Entity;
				if (((previousValue != value) 
							|| (this._Sehirler.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Sehirler.Entity = null;
						previousValue.Ilcelers.Remove(this);
					}
					this._Sehirler.Entity = value;
					if ((value != null))
					{
						value.Ilcelers.Add(this);
						this._SehirId = value.SehirId;
					}
					else
					{
						this._SehirId = default(int);
					}
					this.SendPropertyChanged("Sehirler");
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
		
		private void attach_SemtMahs(SemtMah entity)
		{
			this.SendPropertyChanging();
			entity.Ilceler = this;
		}
		
		private void detach_SemtMahs(SemtMah entity)
		{
			this.SendPropertyChanging();
			entity.Ilceler = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Ulkeler")]
	public partial class Ulkeler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UlkeId;
		
		private string _IkiliKod;
		
		private string _UcluKod;
		
		private string _UlkeAdi;
		
		private string _TelKodu;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUlkeIdChanging(int value);
    partial void OnUlkeIdChanged();
    partial void OnIkiliKodChanging(string value);
    partial void OnIkiliKodChanged();
    partial void OnUcluKodChanging(string value);
    partial void OnUcluKodChanged();
    partial void OnUlkeAdiChanging(string value);
    partial void OnUlkeAdiChanged();
    partial void OnTelKoduChanging(string value);
    partial void OnTelKoduChanged();
    #endregion
		
		public Ulkeler()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UlkeId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UlkeId
		{
			get
			{
				return this._UlkeId;
			}
			set
			{
				if ((this._UlkeId != value))
				{
					this.OnUlkeIdChanging(value);
					this.SendPropertyChanging();
					this._UlkeId = value;
					this.SendPropertyChanged("UlkeId");
					this.OnUlkeIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IkiliKod", DbType="NVarChar(2) NOT NULL", CanBeNull=false)]
		public string IkiliKod
		{
			get
			{
				return this._IkiliKod;
			}
			set
			{
				if ((this._IkiliKod != value))
				{
					this.OnIkiliKodChanging(value);
					this.SendPropertyChanging();
					this._IkiliKod = value;
					this.SendPropertyChanged("IkiliKod");
					this.OnIkiliKodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UcluKod", DbType="NVarChar(3) NOT NULL", CanBeNull=false)]
		public string UcluKod
		{
			get
			{
				return this._UcluKod;
			}
			set
			{
				if ((this._UcluKod != value))
				{
					this.OnUcluKodChanging(value);
					this.SendPropertyChanging();
					this._UcluKod = value;
					this.SendPropertyChanged("UcluKod");
					this.OnUcluKodChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UlkeAdi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string UlkeAdi
		{
			get
			{
				return this._UlkeAdi;
			}
			set
			{
				if ((this._UlkeAdi != value))
				{
					this.OnUlkeAdiChanging(value);
					this.SendPropertyChanging();
					this._UlkeAdi = value;
					this.SendPropertyChanged("UlkeAdi");
					this.OnUlkeAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelKodu", DbType="NVarChar(6) NOT NULL", CanBeNull=false)]
		public string TelKodu
		{
			get
			{
				return this._TelKodu;
			}
			set
			{
				if ((this._TelKodu != value))
				{
					this.OnTelKoduChanging(value);
					this.SendPropertyChanging();
					this._TelKodu = value;
					this.SendPropertyChanged("TelKodu");
					this.OnTelKoduChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Sehirler")]
	public partial class Sehirler : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SehirId;
		
		private string _SehirAdi;
		
		private byte _PlakaNo;
		
		private int _TelefonKodu;
		
		private int _RowNumber;
		
		private EntitySet<Ilceler> _Ilcelers;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSehirIdChanging(int value);
    partial void OnSehirIdChanged();
    partial void OnSehirAdiChanging(string value);
    partial void OnSehirAdiChanged();
    partial void OnPlakaNoChanging(byte value);
    partial void OnPlakaNoChanged();
    partial void OnTelefonKoduChanging(int value);
    partial void OnTelefonKoduChanged();
    partial void OnRowNumberChanging(int value);
    partial void OnRowNumberChanged();
    #endregion
		
		public Sehirler()
		{
			this._Ilcelers = new EntitySet<Ilceler>(new Action<Ilceler>(this.attach_Ilcelers), new Action<Ilceler>(this.detach_Ilcelers));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SehirId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SehirId
		{
			get
			{
				return this._SehirId;
			}
			set
			{
				if ((this._SehirId != value))
				{
					this.OnSehirIdChanging(value);
					this.SendPropertyChanging();
					this._SehirId = value;
					this.SendPropertyChanged("SehirId");
					this.OnSehirIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SehirAdi", DbType="NVarChar(20) NOT NULL", CanBeNull=false)]
		public string SehirAdi
		{
			get
			{
				return this._SehirAdi;
			}
			set
			{
				if ((this._SehirAdi != value))
				{
					this.OnSehirAdiChanging(value);
					this.SendPropertyChanging();
					this._SehirAdi = value;
					this.SendPropertyChanged("SehirAdi");
					this.OnSehirAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PlakaNo", DbType="TinyInt NOT NULL")]
		public byte PlakaNo
		{
			get
			{
				return this._PlakaNo;
			}
			set
			{
				if ((this._PlakaNo != value))
				{
					this.OnPlakaNoChanging(value);
					this.SendPropertyChanging();
					this._PlakaNo = value;
					this.SendPropertyChanged("PlakaNo");
					this.OnPlakaNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TelefonKodu", DbType="Int NOT NULL")]
		public int TelefonKodu
		{
			get
			{
				return this._TelefonKodu;
			}
			set
			{
				if ((this._TelefonKodu != value))
				{
					this.OnTelefonKoduChanging(value);
					this.SendPropertyChanging();
					this._TelefonKodu = value;
					this.SendPropertyChanged("TelefonKodu");
					this.OnTelefonKoduChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RowNumber", DbType="Int NOT NULL")]
		public int RowNumber
		{
			get
			{
				return this._RowNumber;
			}
			set
			{
				if ((this._RowNumber != value))
				{
					this.OnRowNumberChanging(value);
					this.SendPropertyChanging();
					this._RowNumber = value;
					this.SendPropertyChanged("RowNumber");
					this.OnRowNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Sehirler_Ilceler", Storage="_Ilcelers", ThisKey="SehirId", OtherKey="SehirId")]
		public EntitySet<Ilceler> Ilcelers
		{
			get
			{
				return this._Ilcelers;
			}
			set
			{
				this._Ilcelers.Assign(value);
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
		
		private void attach_Ilcelers(Ilceler entity)
		{
			this.SendPropertyChanging();
			entity.Sehirler = this;
		}
		
		private void detach_Ilcelers(Ilceler entity)
		{
			this.SendPropertyChanging();
			entity.Sehirler = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SemtMah")]
	public partial class SemtMah : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SemtMahId;
		
		private string _SemtAdi;
		
		private string _MahalleAdi;
		
		private string _PostaKodu;
		
		private int _ilceId;
		
		private EntityRef<Ilceler> _Ilceler;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSemtMahIdChanging(int value);
    partial void OnSemtMahIdChanged();
    partial void OnSemtAdiChanging(string value);
    partial void OnSemtAdiChanged();
    partial void OnMahalleAdiChanging(string value);
    partial void OnMahalleAdiChanged();
    partial void OnPostaKoduChanging(string value);
    partial void OnPostaKoduChanged();
    partial void OnilceIdChanging(int value);
    partial void OnilceIdChanged();
    #endregion
		
		public SemtMah()
		{
			this._Ilceler = default(EntityRef<Ilceler>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SemtMahId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int SemtMahId
		{
			get
			{
				return this._SemtMahId;
			}
			set
			{
				if ((this._SemtMahId != value))
				{
					this.OnSemtMahIdChanging(value);
					this.SendPropertyChanging();
					this._SemtMahId = value;
					this.SendPropertyChanged("SemtMahId");
					this.OnSemtMahIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SemtAdi", DbType="NVarChar(60) NOT NULL", CanBeNull=false)]
		public string SemtAdi
		{
			get
			{
				return this._SemtAdi;
			}
			set
			{
				if ((this._SemtAdi != value))
				{
					this.OnSemtAdiChanging(value);
					this.SendPropertyChanging();
					this._SemtAdi = value;
					this.SendPropertyChanged("SemtAdi");
					this.OnSemtAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MahalleAdi", DbType="NVarChar(100) NOT NULL", CanBeNull=false)]
		public string MahalleAdi
		{
			get
			{
				return this._MahalleAdi;
			}
			set
			{
				if ((this._MahalleAdi != value))
				{
					this.OnMahalleAdiChanging(value);
					this.SendPropertyChanging();
					this._MahalleAdi = value;
					this.SendPropertyChanged("MahalleAdi");
					this.OnMahalleAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PostaKodu", DbType="NVarChar(6) NOT NULL", CanBeNull=false)]
		public string PostaKodu
		{
			get
			{
				return this._PostaKodu;
			}
			set
			{
				if ((this._PostaKodu != value))
				{
					this.OnPostaKoduChanging(value);
					this.SendPropertyChanging();
					this._PostaKodu = value;
					this.SendPropertyChanged("PostaKodu");
					this.OnPostaKoduChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilceId", DbType="Int NOT NULL")]
		public int ilceId
		{
			get
			{
				return this._ilceId;
			}
			set
			{
				if ((this._ilceId != value))
				{
					if (this._Ilceler.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnilceIdChanging(value);
					this.SendPropertyChanging();
					this._ilceId = value;
					this.SendPropertyChanged("ilceId");
					this.OnilceIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Ilceler_SemtMah", Storage="_Ilceler", ThisKey="ilceId", OtherKey="ilceId", IsForeignKey=true)]
		public Ilceler Ilceler
		{
			get
			{
				return this._Ilceler.Entity;
			}
			set
			{
				Ilceler previousValue = this._Ilceler.Entity;
				if (((previousValue != value) 
							|| (this._Ilceler.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Ilceler.Entity = null;
						previousValue.SemtMahs.Remove(this);
					}
					this._Ilceler.Entity = value;
					if ((value != null))
					{
						value.SemtMahs.Add(this);
						this._ilceId = value.ilceId;
					}
					else
					{
						this._ilceId = default(int);
					}
					this.SendPropertyChanged("Ilceler");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ILMESAFESI")]
	public partial class ILMESAFESI
	{
		
		private System.Nullable<int> _id;
		
		private System.Nullable<int> _ilid1;
		
		private System.Nullable<int> _ilid2;
		
		private System.Nullable<int> _mesafe;
		
		public ILMESAFESI()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int")]
		public System.Nullable<int> id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this._id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilid1", DbType="Int")]
		public System.Nullable<int> ilid1
		{
			get
			{
				return this._ilid1;
			}
			set
			{
				if ((this._ilid1 != value))
				{
					this._ilid1 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ilid2", DbType="Int")]
		public System.Nullable<int> ilid2
		{
			get
			{
				return this._ilid2;
			}
			set
			{
				if ((this._ilid2 != value))
				{
					this._ilid2 = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mesafe", DbType="Int")]
		public System.Nullable<int> mesafe
		{
			get
			{
				return this._mesafe;
			}
			set
			{
				if ((this._mesafe != value))
				{
					this._mesafe = value;
				}
			}
		}
	}
}
#pragma warning restore 1591