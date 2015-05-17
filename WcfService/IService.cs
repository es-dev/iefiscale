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

    }


   
}
