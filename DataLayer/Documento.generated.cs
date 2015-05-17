#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;
using DataLayer;

namespace DataLayer	
{
	public partial class Documento
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private string _iDCliente;
		public virtual string IDCliente
		{
			get
			{
				return this._iDCliente;
			}
			set
			{
				this._iDCliente = value;
			}
		}
		
		private int _exportId;
		public virtual int ExportId
		{
			get
			{
				return this._exportId;
			}
			set
			{
				this._exportId = value;
			}
		}
		
		private string _tipo;
		public virtual string Tipo
		{
			get
			{
				return this._tipo;
			}
			set
			{
				this._tipo = value;
			}
		}
		
		private DateTime? _data;
		public virtual DateTime? Data
		{
			get
			{
				return this._data;
			}
			set
			{
				this._data = value;
			}
		}
		
		private string _iDMovimento;
		public virtual string IDMovimento
		{
			get
			{
				return this._iDMovimento;
			}
			set
			{
				this._iDMovimento = value;
			}
		}
		
		private string _iDCausale;
		public virtual string IDCausale
		{
			get
			{
				return this._iDCausale;
			}
			set
			{
				this._iDCausale = value;
			}
		}
		
		private string _iDConto;
		public virtual string IDConto
		{
			get
			{
				return this._iDConto;
			}
			set
			{
				this._iDConto = value;
			}
		}
		
		private string _iDRegistroIVA;
		public virtual string IDRegistroIVA
		{
			get
			{
				return this._iDRegistroIVA;
			}
			set
			{
				this._iDRegistroIVA = value;
			}
		}
		
		private string _iDIVA;
		public virtual string IDIVA
		{
			get
			{
				return this._iDIVA;
			}
			set
			{
				this._iDIVA = value;
			}
		}
		
		private decimal? _totale;
		public virtual decimal? Totale
		{
			get
			{
				return this._totale;
			}
			set
			{
				this._totale = value;
			}
		}
		
		private decimal? _imponibile;
		public virtual decimal? Imponibile
		{
			get
			{
				return this._imponibile;
			}
			set
			{
				this._imponibile = value;
			}
		}
		
		private decimal? _iVA;
		public virtual decimal? IVA
		{
			get
			{
				return this._iVA;
			}
			set
			{
				this._iVA = value;
			}
		}
		
		private string _numero;
		public virtual string Numero
		{
			get
			{
				return this._numero;
			}
			set
			{
				this._numero = value;
			}
		}
		
		private DateTime? _dataRegistrazione;
		public virtual DateTime? DataRegistrazione
		{
			get
			{
				return this._dataRegistrazione;
			}
			set
			{
				this._dataRegistrazione = value;
			}
		}
		
		private Export _export;
		public virtual Export Export
		{
			get
			{
				return this._export;
			}
			set
			{
				this._export = value;
			}
		}
		
	}
}
#pragma warning restore 1591
