using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService
    {
        #region Account
        #region CRUD
        [OperationContract]
        Dto.AccountDto CreateAccount(Dto.AccountDto account);

        [OperationContract]
        IEnumerable<Dto.AccountDto> ReadAccounts();

        [OperationContract]
        bool UpdateAccount(Dto.AccountDto account);

        [OperationContract]
        bool DeleteAccount(Dto.AccountDto account);

        [OperationContract]
        int CountAccounts();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.AccountDto> LoadAccounts(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountAccounts(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.AccountDto ReadAccount(object id);
        #endregion
        #endregion

        #region StudioCommerciale
        #region CRUD
        [OperationContract]
        Dto.StudioCommercialeDto CreateStudioCommerciale(Dto.StudioCommercialeDto studioCommerciale);

        [OperationContract]
        IEnumerable<Dto.StudioCommercialeDto> ReadStudiCommerciali();

        [OperationContract]
        bool UpdateStudioCommerciale(Dto.StudioCommercialeDto studioCommerciale);

        [OperationContract]
        bool DeleteStudioCommerciale(Dto.StudioCommercialeDto studioCommerciale);

        [OperationContract]
        int CountStudiCommerciali();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.StudioCommercialeDto> LoadStudiCommerciali(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountStudiCommerciali(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.StudioCommercialeDto ReadStudioCommerciale(object id);
         #endregion
        #endregion

        #region AnagraficaAzienda
        #region CRUD
        [OperationContract]
        Dto.AnagraficaAziendaDto CreateAnagraficaAzienda(Dto.AnagraficaAziendaDto anagraficaAzienda);

        [OperationContract]
        IEnumerable<Dto.AnagraficaAziendaDto> ReadAnagraficheAziende();

        [OperationContract]
        bool UpdateAnagraficaAzienda(Dto.AnagraficaAziendaDto anagraficaAzienda);

        [OperationContract]
        bool DeleteAnagraficaAzienda(Dto.AnagraficaAziendaDto anagraficaAzienda);

        [OperationContract]
        int CountAnagraficheAziende();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.AnagraficaAziendaDto> LoadAnagraficheAziende(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountAnagraficheAziende(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.AnagraficaAziendaDto ReadAnagraficaAzienda(object id);
        #endregion
        #endregion

        #region Azienda
        #region CRUD
        [OperationContract]
        Dto.AziendaDto CreateAzienda(Dto.AziendaDto azienda);

        [OperationContract]
        IEnumerable<Dto.AziendaDto> ReadAziende();

        [OperationContract]
        bool UpdateAzienda(Dto.AziendaDto azienda);

        [OperationContract]
        bool DeleteAzienda(Dto.AziendaDto azienda);

        [OperationContract]
        int CountAziende();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.AziendaDto> LoadAziende(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountAziende(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.AziendaDto ReadAzienda(object id);
        #endregion
        #endregion

        #region Cliente
        #region CRUD
        [OperationContract]
        Dto.ClienteDto CreateCliente(Dto.ClienteDto cliente);

        [OperationContract]
        IEnumerable<Dto.ClienteDto> ReadClienti();

        [OperationContract]
        bool UpdateCliente(Dto.ClienteDto cliente);

        [OperationContract]
        bool DeleteCliente(Dto.ClienteDto cliente);

        [OperationContract]
        int CountClienti();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.ClienteDto> LoadClienti(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountClienti(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.ClienteDto ReadCliente(object id);
        #endregion
        #endregion

        #region Contabilita
        #region CRUD
        [OperationContract]
        Dto.ContabilitaDto CreateContabilita(Dto.ContabilitaDto contabilita);

        [OperationContract]
        IEnumerable<Dto.ContabilitaDto> ReadContabilitas();

        [OperationContract]
        bool UpdateContabilita(Dto.ContabilitaDto contabilita);

        [OperationContract]
        bool DeleteContabilita(Dto.ContabilitaDto contabilita);

        [OperationContract]
        int CountContabilitas();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.ContabilitaDto> LoadContabilitas(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountContabilitas(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.ContabilitaDto ReadContabilita(object id);
        #endregion
        #endregion

        #region Comunicazione
        #region CRUD
        [OperationContract]
        Dto.ComunicazioneDto CreateComunicazione(Dto.ComunicazioneDto comunicazione);

        [OperationContract]
        IEnumerable<Dto.ComunicazioneDto> ReadComunicazioni();

        [OperationContract]
        bool UpdateComunicazione(Dto.ComunicazioneDto comunicazione);

        [OperationContract]
        bool DeleteComunicazione(Dto.ComunicazioneDto comunicazione);

        [OperationContract]
        int CountComunicazioni();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.ComunicazioneDto> LoadComunicazioni(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountComunicazioni(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.ComunicazioneDto ReadComunicazione(object id);
        #endregion
        #endregion

        #region Export
        #region CRUD
        [OperationContract]
        Dto.ExportDto CreateExport(Dto.ExportDto export);

        [OperationContract]
        IEnumerable<Dto.ExportDto> ReadExports();

        [OperationContract]
        bool UpdateExport(Dto.ExportDto export);

        [OperationContract]
        bool DeleteExport(Dto.ExportDto export);

        [OperationContract]
        int CountExports();
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.ExportDto> LoadExports(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountExports(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.ExportDto ReadExport(object id);
        #endregion
        #endregion

        #region Import
        #region CRUD
        [OperationContract]
        Dto.ImportDto CreateImport(Dto.ImportDto import);

        [OperationContract]
        IEnumerable<Dto.ImportDto> ReadImports();

        [OperationContract]
         bool UpdateImport(Dto.ImportDto import);

        [OperationContract]
        bool DeleteImport(Dto.ImportDto import);

        [OperationContract]
        int CountImports();

        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.ImportDto> LoadImports(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountImports(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.ImportDto ReadImport(object id);

        #endregion
        #endregion

        #region Customer
        #region CRUD
        [OperationContract]
        Dto.CustomerDto CreateCustomer(Dto.CustomerDto customer);

        [OperationContract]
        IEnumerable<Dto.CustomerDto> ReadCustomers();

        [OperationContract]
        bool UpdateCustomer(Dto.CustomerDto customer);

        [OperationContract]
        bool DeleteCustomer(Dto.CustomerDto customer);

        [OperationContract]
        int CountCustomers();

        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.CustomerDto> LoadCustomers(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountCustomers(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.CustomerDto ReadCustomer(object id);

        #endregion
        #endregion

        #region Documento
        #region CRUD
        [OperationContract]
        Dto.DocumentoDto CreateDocumento(Dto.DocumentoDto documento);

        [OperationContract]
        IEnumerable<Dto.DocumentoDto> ReadDocumenti();

        [OperationContract]
        bool UpdateDocumento(Dto.DocumentoDto documento);

        [OperationContract]
        bool DeleteDocumento(Dto.DocumentoDto documento);

        [OperationContract]
        int CountDocumenti();
   
        #endregion
        #region Custom
        [OperationContract]
        IEnumerable<Dto.DocumentoDto> LoadDocumenti(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null);

        [OperationContract]
        int CountDocumenti(string search = null, object advancedSearch = null);

        [OperationContract]
        Dto.DocumentoDto ReadDocumento(object id);
       
        #endregion
        #endregion
    }
 
}
