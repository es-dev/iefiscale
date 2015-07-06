#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using DataLayer;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WcfService.Dto
{
	public interface IDtoWithKey
	{
		string DtoKey { get; set; }
	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(AccountDto))]
	[KnownType(typeof(AziendaDto))]
	[KnownType(typeof(AnagraficaAziendaDto))]
	public partial class StudioCommercialeDto : IDtoWithKey
	{
		public StudioCommercialeDto()
		{
		}
		
		public StudioCommercialeDto(int _id, string _denominazione, string _tipoSoftwareContabilita, string _partitaIVA, string _indirizzo, string _comune, string _provincia, string _cap, string _email, string _telefono, string _fax, string _codiceCatastale, IList<AccountDto> _accounts, IList<AziendaDto> _aziendas, IList<AnagraficaAziendaDto> _anagraficaAziendas)
		{
			this.Id = _id;
			this.Denominazione = _denominazione;
			this.TipoSoftwareContabilita = _tipoSoftwareContabilita;
			this.PartitaIVA = _partitaIVA;
			this.Indirizzo = _indirizzo;
			this.Comune = _comune;
			this.Provincia = _provincia;
			this.Cap = _cap;
			this.Email = _email;
			this.Telefono = _telefono;
			this.Fax = _fax;
			this.CodiceCatastale = _codiceCatastale;
			this.Accounts = _accounts;
			this.Aziendas = _aziendas;
			this.AnagraficaAziendas = _anagraficaAziendas;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string Denominazione { get;set; }

		[DataMember]
		public virtual string TipoSoftwareContabilita { get;set; }

		[DataMember]
		public virtual string PartitaIVA { get;set; }

		[DataMember]
		public virtual string Indirizzo { get;set; }

		[DataMember]
		public virtual string Comune { get;set; }

		[DataMember]
		public virtual string Provincia { get;set; }

		[DataMember]
		public virtual string Cap { get;set; }

		[DataMember]
		public virtual string Email { get;set; }

		[DataMember]
		public virtual string Telefono { get;set; }

		[DataMember]
		public virtual string Fax { get;set; }

		[DataMember]
		public virtual string CodiceCatastale { get;set; }

		[DataMember]
		public virtual IList<AccountDto> Accounts { get;set; }

		[DataMember]
		public virtual IList<AziendaDto> Aziendas { get;set; }

		[DataMember]
		public virtual IList<AnagraficaAziendaDto> AnagraficaAziendas { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(StudioCommercialeDto))]
	[KnownType(typeof(AnagraficaAziendaDto))]
	[KnownType(typeof(AccountDto))]
	[KnownType(typeof(ContabilitaDto))]
	[KnownType(typeof(ClienteDto))]
	public partial class AziendaDto : IDtoWithKey
	{
		public AziendaDto()
		{
		}
		
		public AziendaDto(int _id, string _tipoContabilita, string _tipoSoftwareFatturazione, string _iDAzienda, int _studioCommercialeId, int _anagraficaAziendaId, string _mdbFile, DateTime? _ultimoAggiornamento, StudioCommercialeDto _studioCommerciale, AnagraficaAziendaDto _anagraficaAzienda, IList<AccountDto> _accounts, IList<ContabilitaDto> _contabilitas, IList<ClienteDto> _clientes)
		{
			this.Id = _id;
			this.TipoContabilita = _tipoContabilita;
			this.TipoSoftwareFatturazione = _tipoSoftwareFatturazione;
			this.IDAzienda = _iDAzienda;
			this.StudioCommercialeId = _studioCommercialeId;
			this.AnagraficaAziendaId = _anagraficaAziendaId;
			this.MdbFile = _mdbFile;
			this.UltimoAggiornamento = _ultimoAggiornamento;
			this.StudioCommerciale = _studioCommerciale;
			this.AnagraficaAzienda = _anagraficaAzienda;
			this.Accounts = _accounts;
			this.Contabilitas = _contabilitas;
			this.Clientes = _clientes;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string TipoContabilita { get;set; }

		[DataMember]
		public virtual string TipoSoftwareFatturazione { get;set; }

		[DataMember]
		public virtual string IDAzienda { get;set; }

		[DataMember]
		public virtual int StudioCommercialeId { get;set; }

		[DataMember]
		public virtual int AnagraficaAziendaId { get;set; }

		[DataMember]
		public virtual string MdbFile { get;set; }

		[DataMember]
		public virtual DateTime? UltimoAggiornamento { get;set; }

		[DataMember]
		public virtual StudioCommercialeDto StudioCommerciale { get;set; }

		[DataMember]
		public virtual AnagraficaAziendaDto AnagraficaAzienda { get;set; }

		[DataMember]
		public virtual IList<AccountDto> Accounts { get;set; }

		[DataMember]
		public virtual IList<ContabilitaDto> Contabilitas { get;set; }

		[DataMember]
		public virtual IList<ClienteDto> Clientes { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(AziendaDto))]
	[KnownType(typeof(ComunicazioneDto))]
	public partial class ContabilitaDto : IDtoWithKey
	{
		public ContabilitaDto()
		{
		}
		
		public ContabilitaDto(int _id, string _anno, string _tipo, int _aziendaId, AziendaDto _azienda, IList<ComunicazioneDto> _comunicaziones)
		{
			this.Id = _id;
			this.Anno = _anno;
			this.Tipo = _tipo;
			this.AziendaId = _aziendaId;
			this.Azienda = _azienda;
			this.Comunicaziones = _comunicaziones;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string Anno { get;set; }

		[DataMember]
		public virtual string Tipo { get;set; }

		[DataMember]
		public virtual int AziendaId { get;set; }

		[DataMember]
		public virtual AziendaDto Azienda { get;set; }

		[DataMember]
		public virtual IList<ComunicazioneDto> Comunicaziones { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(ContabilitaDto))]
	[KnownType(typeof(ExportDto))]
	public partial class ComunicazioneDto : IDtoWithKey
	{
		public ComunicazioneDto()
		{
		}
		
		public ComunicazioneDto(int _id, int _contabilitaId, string _numero, DateTime? _scadenzaIVA, ContabilitaDto _contabilita, IList<ExportDto> _exports)
		{
			this.Id = _id;
			this.ContabilitaId = _contabilitaId;
			this.Numero = _numero;
			this.ScadenzaIVA = _scadenzaIVA;
			this.Contabilita = _contabilita;
			this.Exports = _exports;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int ContabilitaId { get;set; }

		[DataMember]
		public virtual string Numero { get;set; }

		[DataMember]
		public virtual DateTime? ScadenzaIVA { get;set; }

		[DataMember]
		public virtual ContabilitaDto Contabilita { get;set; }

		[DataMember]
		public virtual IList<ExportDto> Exports { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(CustomerDto))]
	public partial class DocumentoDto : IDtoWithKey
	{
		public DocumentoDto()
		{
		}
		
		public DocumentoDto(int _id, string _tipo, DateTime? _data, string _iDMovimento, string _iDCausale, string _iDRegistroIVA, string _iDIVA, decimal? _totale, decimal? _imponibile, decimal? _iVA, string _numero, DateTime? _dataRegistrazione, int _customerId, CustomerDto _customer)
		{
			this.Id = _id;
			this.Tipo = _tipo;
			this.Data = _data;
			this.IDMovimento = _iDMovimento;
			this.IDCausale = _iDCausale;
			this.IDRegistroIVA = _iDRegistroIVA;
			this.IDIVA = _iDIVA;
			this.Totale = _totale;
			this.Imponibile = _imponibile;
			this.IVA = _iVA;
			this.Numero = _numero;
			this.DataRegistrazione = _dataRegistrazione;
			this.CustomerId = _customerId;
			this.Customer = _customer;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual string Tipo { get;set; }

		[DataMember]
		public virtual DateTime? Data { get;set; }

		[DataMember]
		public virtual string IDMovimento { get;set; }

		[DataMember]
		public virtual string IDCausale { get;set; }

		[DataMember]
		public virtual string IDRegistroIVA { get;set; }

		[DataMember]
		public virtual string IDIVA { get;set; }

		[DataMember]
		public virtual decimal? Totale { get;set; }

		[DataMember]
		public virtual decimal? Imponibile { get;set; }

		[DataMember]
		public virtual decimal? IVA { get;set; }

		[DataMember]
		public virtual string Numero { get;set; }

		[DataMember]
		public virtual DateTime? DataRegistrazione { get;set; }

		[DataMember]
		public virtual int CustomerId { get;set; }

		[DataMember]
		public virtual CustomerDto Customer { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(StudioCommercialeDto))]
	[KnownType(typeof(AziendaDto))]
	public partial class AccountDto : IDtoWithKey
	{
		public AccountDto()
		{
		}
		
		public AccountDto(int _id, int _studioCommercialeId, int _aziendaId, string _username, string _password, string _nickname, string _ruolo, string _note, DateTime? _creazione, bool? _abilitato, StudioCommercialeDto _studioCommerciale, AziendaDto _azienda)
		{
			this.Id = _id;
			this.StudioCommercialeId = _studioCommercialeId;
			this.AziendaId = _aziendaId;
			this.Username = _username;
			this.Password = _password;
			this.Nickname = _nickname;
			this.Ruolo = _ruolo;
			this.Note = _note;
			this.Creazione = _creazione;
			this.Abilitato = _abilitato;
			this.StudioCommerciale = _studioCommerciale;
			this.Azienda = _azienda;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int StudioCommercialeId { get;set; }

		[DataMember]
		public virtual int AziendaId { get;set; }

		[DataMember]
		public virtual string Username { get;set; }

		[DataMember]
		public virtual string Password { get;set; }

		[DataMember]
		public virtual string Nickname { get;set; }

		[DataMember]
		public virtual string Ruolo { get;set; }

		[DataMember]
		public virtual string Note { get;set; }

		[DataMember]
		public virtual DateTime? Creazione { get;set; }

		[DataMember]
		public virtual bool? Abilitato { get;set; }

		[DataMember]
		public virtual StudioCommercialeDto StudioCommerciale { get;set; }

		[DataMember]
		public virtual AziendaDto Azienda { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(ExportDto))]
	public partial class ImportDto : IDtoWithKey
	{
		public ImportDto()
		{
		}
		
		public ImportDto(int _id, DateTime? _data, string _tXTMovimenti, string _tXTClienti, string _stato, ExportDto _export)
		{
			this.Id = _id;
			this.Data = _data;
			this.TXTMovimenti = _tXTMovimenti;
			this.TXTClienti = _tXTClienti;
			this.Stato = _stato;
			this.Export = _export;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual DateTime? Data { get;set; }

		[DataMember]
		public virtual string TXTMovimenti { get;set; }

		[DataMember]
		public virtual string TXTClienti { get;set; }

		[DataMember]
		public virtual string Stato { get;set; }

		[DataMember]
		public virtual ExportDto Export { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(ComunicazioneDto))]
	[KnownType(typeof(CustomerDto))]
	[KnownType(typeof(ImportDto))]
	public partial class ExportDto : IDtoWithKey
	{
		public ExportDto()
		{
		}
		
		public ExportDto(int _id, int _comunicazioneId, DateTime? _data, string _progressivo, string _xmlFile, string _stato, ComunicazioneDto _comunicazione, IList<CustomerDto> _customers, ImportDto _import)
		{
			this.Id = _id;
			this.ComunicazioneId = _comunicazioneId;
			this.Data = _data;
			this.Progressivo = _progressivo;
			this.XmlFile = _xmlFile;
			this.Stato = _stato;
			this.Comunicazione = _comunicazione;
			this.Customers = _customers;
			this.Import = _import;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int ComunicazioneId { get;set; }

		[DataMember]
		public virtual DateTime? Data { get;set; }

		[DataMember]
		public virtual string Progressivo { get;set; }

		[DataMember]
		public virtual string XmlFile { get;set; }

		[DataMember]
		public virtual string Stato { get;set; }

		[DataMember]
		public virtual ComunicazioneDto Comunicazione { get;set; }

		[DataMember]
		public virtual IList<CustomerDto> Customers { get;set; }

		[DataMember]
		public virtual ImportDto Import { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(StudioCommercialeDto))]
	[KnownType(typeof(AziendaDto))]
	[KnownType(typeof(ClienteDto))]
	public partial class AnagraficaAziendaDto : IDtoWithKey
	{
		public AnagraficaAziendaDto()
		{
		}
		
		public AnagraficaAziendaDto(int _id, int _studioCommercialeId, string _ragioneSociale, string _codiceFiscale, string _partitaIVA, string _indirizzo, string _comune, string _provincia, string _email, string _telefono, string _fax, string _cap, string _codiceCatastale, StudioCommercialeDto _studioCommerciale, IList<AziendaDto> _aziendas, IList<ClienteDto> _clientes)
		{
			this.Id = _id;
			this.StudioCommercialeId = _studioCommercialeId;
			this.RagioneSociale = _ragioneSociale;
			this.CodiceFiscale = _codiceFiscale;
			this.PartitaIVA = _partitaIVA;
			this.Indirizzo = _indirizzo;
			this.Comune = _comune;
			this.Provincia = _provincia;
			this.Email = _email;
			this.Telefono = _telefono;
			this.Fax = _fax;
			this.Cap = _cap;
			this.CodiceCatastale = _codiceCatastale;
			this.StudioCommerciale = _studioCommerciale;
			this.Aziendas = _aziendas;
			this.Clientes = _clientes;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int StudioCommercialeId { get;set; }

		[DataMember]
		public virtual string RagioneSociale { get;set; }

		[DataMember]
		public virtual string CodiceFiscale { get;set; }

		[DataMember]
		public virtual string PartitaIVA { get;set; }

		[DataMember]
		public virtual string Indirizzo { get;set; }

		[DataMember]
		public virtual string Comune { get;set; }

		[DataMember]
		public virtual string Provincia { get;set; }

		[DataMember]
		public virtual string Email { get;set; }

		[DataMember]
		public virtual string Telefono { get;set; }

		[DataMember]
		public virtual string Fax { get;set; }

		[DataMember]
		public virtual string Cap { get;set; }

		[DataMember]
		public virtual string CodiceCatastale { get;set; }

		[DataMember]
		public virtual StudioCommercialeDto StudioCommerciale { get;set; }

		[DataMember]
		public virtual IList<AziendaDto> Aziendas { get;set; }

		[DataMember]
		public virtual IList<ClienteDto> Clientes { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(AziendaDto))]
	[KnownType(typeof(AnagraficaAziendaDto))]
	[KnownType(typeof(CustomerDto))]
	public partial class ClienteDto : IDtoWithKey
	{
		public ClienteDto()
		{
		}
		
		public ClienteDto(int _id, int _aziendaId, string _iDCliente, int _anagraficaAziendaId, string _iDConto, AziendaDto _azienda, AnagraficaAziendaDto _anagraficaAzienda, IList<CustomerDto> _customers)
		{
			this.Id = _id;
			this.AziendaId = _aziendaId;
			this.IDCliente = _iDCliente;
			this.AnagraficaAziendaId = _anagraficaAziendaId;
			this.IDConto = _iDConto;
			this.Azienda = _azienda;
			this.AnagraficaAzienda = _anagraficaAzienda;
			this.Customers = _customers;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int AziendaId { get;set; }

		[DataMember]
		public virtual string IDCliente { get;set; }

		[DataMember]
		public virtual int AnagraficaAziendaId { get;set; }

		[DataMember]
		public virtual string IDConto { get;set; }

		[DataMember]
		public virtual AziendaDto Azienda { get;set; }

		[DataMember]
		public virtual AnagraficaAziendaDto AnagraficaAzienda { get;set; }

		[DataMember]
		public virtual IList<CustomerDto> Customers { get;set; }

	}
	
	[DataContract(IsReference = true)]
	[KnownType(typeof(ExportDto))]
	[KnownType(typeof(ClienteDto))]
	[KnownType(typeof(DocumentoDto))]
	public partial class CustomerDto : IDtoWithKey
	{
		public CustomerDto()
		{
		}
		
		public CustomerDto(int _id, int _exportId, int _clienteId, ExportDto _export, ClienteDto _cliente, IList<DocumentoDto> _documentos)
		{
			this.Id = _id;
			this.ExportId = _exportId;
			this.ClienteId = _clienteId;
			this.Export = _export;
			this.Cliente = _cliente;
			this.Documentos = _documentos;
		}
		
		[DataMember]
		public virtual string DtoKey { get; set; }
		
		[DataMember]
		public virtual int Id { get;set; }

		[DataMember]
		public virtual int ExportId { get;set; }

		[DataMember]
		public virtual int ClienteId { get;set; }

		[DataMember]
		public virtual ExportDto Export { get;set; }

		[DataMember]
		public virtual ClienteDto Cliente { get;set; }

		[DataMember]
		public virtual IList<DocumentoDto> Documentos { get;set; }

	}
	
}
#pragma warning restore 1591
