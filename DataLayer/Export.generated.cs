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
	public partial class Export
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
		
		private int _comunicazioneId;
		public virtual int ComunicazioneId
		{
			get
			{
				return this._comunicazioneId;
			}
			set
			{
				this._comunicazioneId = value;
			}
		}
		
		private DateTime _data;
		public virtual DateTime Data
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
		
		private string _progressivo;
		public virtual string Progressivo
		{
			get
			{
				return this._progressivo;
			}
			set
			{
				this._progressivo = value;
			}
		}
		
		private string _xmlFile;
		public virtual string XmlFile
		{
			get
			{
				return this._xmlFile;
			}
			set
			{
				this._xmlFile = value;
			}
		}
		
		private Comunicazione _comunicazione;
		public virtual Comunicazione Comunicazione
		{
			get
			{
				return this._comunicazione;
			}
			set
			{
				this._comunicazione = value;
			}
		}
		
		private IList<Documento> _documentos = new List<Documento>();
		public virtual IList<Documento> Documentos
		{
			get
			{
				return this._documentos;
			}
		}
		
		private Import _import;
		public virtual Import Import
		{
			get
			{
				return this._import;
			}
			set
			{
				this._import = value;
			}
		}
		
	}
}
#pragma warning restore 1591