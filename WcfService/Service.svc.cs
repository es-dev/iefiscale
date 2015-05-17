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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        #region Account
        #region CRUD
        public Dto.AccountDto CreateAccount(Dto.AccountDto account)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAccount(account);
                var newAccount = wcf.ReadAccount(dtoKey);
                return newAccount;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AccountDto> ReadAccounts()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var accounts = wcf.ReadAccounts();
                return accounts;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAccount(Dto.AccountDto account)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAccount(account);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAccount(Dto.AccountDto account)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAccount(account);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAccounts()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AccountsCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.AccountDto> LoadAccounts(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var accounts = QueryAccounts(search, advancedSearch, orderBy);
                accounts = (from q in accounts select q).Skip(skip).Take(take);
                var accountsDto = UtilityPOCO.Assemble<Dto.AccountDto>(accounts);
                return accountsDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAccounts(string search = null, object advancedSearch = null)
        {
            try
            {
                var accounts = QueryAccounts(search, advancedSearch);
                var count = accounts.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AccountDto ReadAccount(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var account = (from q in ef.Accounts where q.Id == (int)id select q).FirstOrDefault();
                var accountDto = UtilityPOCO.Assemble<Dto.AccountDto>(account);
                return accountDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Account> QueryAccounts(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var accounts = (from q in ef.Accounts select q);

                if (search != null && search.Length > 0)
                    accounts = (from q in accounts
                                where q.Nickname.StartsWith(search) || q.Username.Contains(search)
                                select q);

                if (advancedSearch != null)
                    accounts = accounts.Where((Func<DataLayer.Account, bool>)advancedSearch).AsQueryable();

                accounts = (from q in accounts orderby q.Username select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        accounts = accounts.OrderBy((Func<DataLayer.Account, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        accounts = accounts.OrderByDescending((Func<DataLayer.Account, object>)orderBy.Value).AsQueryable();
                }
                return accounts;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region StudioCommerciale
        #region CRUD
        public Dto.StudioCommercialeDto CreateStudioCommerciale(Dto.StudioCommercialeDto studioCommerciale)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateStudioCommerciale(studioCommerciale);
                var newStudioCommerciale = wcf.ReadStudioCommerciale(dtoKey);
                return newStudioCommerciale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.StudioCommercialeDto> ReadStudiCommerciali()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var studiCommerciali = wcf.ReadStudioCommerciales();
                return studiCommerciali;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateStudioCommerciale(Dto.StudioCommercialeDto studioCommerciale)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateStudioCommerciale(studioCommerciale);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteStudioCommerciale(Dto.StudioCommercialeDto studioCommerciale)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteStudioCommerciale(studioCommerciale);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountStudiCommerciali()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.StudioCommercialesCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.StudioCommercialeDto> LoadStudiCommerciali(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var studiCommerciali = QueryStudiCommerciali(search, advancedSearch, orderBy);
                studiCommerciali = (from q in studiCommerciali select q).Skip(skip).Take(take);
                var studiCommercialiDto = UtilityPOCO.Assemble<Dto.StudioCommercialeDto>(studiCommerciali);
                return studiCommercialiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountStudiCommerciali(string search = null, object advancedSearch = null)
        {
            try
            {
                var studiCommerciali = QueryStudiCommerciali(search, advancedSearch);
                var count = studiCommerciali.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.StudioCommercialeDto ReadStudioCommerciale(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var studioCommerciale = (from q in ef.StudioCommerciales where q.Id == (int)id select q).FirstOrDefault();
                var studioCommercialeDto = UtilityPOCO.Assemble<Dto.StudioCommercialeDto>(studioCommerciale);
                return studioCommercialeDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.StudioCommerciale> QueryStudiCommerciali(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var studiCommerciali = (from q in ef.StudioCommerciales select q);

                if (search != null && search.Length > 0)
                    studiCommerciali = (from q in studiCommerciali
                                where q.Denominazione.StartsWith(search) select q);

                if (advancedSearch != null)
                    studiCommerciali = studiCommerciali.Where((Func<DataLayer.StudioCommerciale, bool>)advancedSearch).AsQueryable();

                studiCommerciali = (from q in studiCommerciali orderby q.Denominazione select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        studiCommerciali = studiCommerciali.OrderBy((Func<DataLayer.StudioCommerciale, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        studiCommerciali = studiCommerciali.OrderByDescending((Func<DataLayer.StudioCommerciale, object>)orderBy.Value).AsQueryable();
                }
                return studiCommerciali;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region AnagraficaAzienda
        #region CRUD
        public Dto.AnagraficaAziendaDto CreateAnagraficaAzienda(Dto.AnagraficaAziendaDto anagraficaAzienda)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAnagraficaAzienda(anagraficaAzienda);
                var newAnagraficaAzienda = wcf.ReadAnagraficaAzienda(dtoKey);
                return newAnagraficaAzienda;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AnagraficaAziendaDto> ReadAnagraficheAziende()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var anagraficheAziende = wcf.ReadAnagraficaAziendas();
                return anagraficheAziende;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAnagraficaAzienda(Dto.AnagraficaAziendaDto anagraficaAzienda)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAnagraficaAzienda(anagraficaAzienda);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAnagraficaAzienda(Dto.AnagraficaAziendaDto anagraficaAzienda)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAnagraficaAzienda(anagraficaAzienda);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAnagraficheAziende()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AnagraficaAziendasCount();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }
        #endregion
        #region Custom
        public IEnumerable<Dto.AnagraficaAziendaDto> LoadAnagraficheAziende(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var anagraficheAziende = QueryAnagraficheAziende(search, advancedSearch, orderBy);
                anagraficheAziende = (from q in anagraficheAziende select q).Skip(skip).Take(take);
                var anagraficheAziendeDto = UtilityPOCO.Assemble<Dto.AnagraficaAziendaDto>(anagraficheAziende);
                return anagraficheAziendeDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAnagraficheAziende(string search = null, object advancedSearch = null)
        {
            try
            {
                var anagraficheAziende = QueryAnagraficheAziende(search, advancedSearch);
                var count = anagraficheAziende.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AnagraficaAziendaDto ReadAnagraficaAzienda(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficaAzienda = (from q in ef.AnagraficaAziendas where q.Id == (int)id select q).FirstOrDefault();
                var anagraficaAziendaDto = UtilityPOCO.Assemble<Dto.AnagraficaAziendaDto>(anagraficaAzienda);
                return anagraficaAziendaDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.AnagraficaAzienda> QueryAnagraficheAziende(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficheAziende = (from q in ef.AnagraficaAziendas select q);

                if (search != null && search.Length > 0)
                    anagraficheAziende = (from q in anagraficheAziende
                                        where q.RagioneSociale.StartsWith(search) || q.PartitaIVA.StartsWith(search)
                                        select q);

                if (advancedSearch != null)
                    anagraficheAziende = anagraficheAziende.Where((Func<DataLayer.AnagraficaAzienda, bool>)advancedSearch).AsQueryable();

                anagraficheAziende = (from q in anagraficheAziende orderby q.RagioneSociale select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        anagraficheAziende = anagraficheAziende.OrderBy((Func<DataLayer.AnagraficaAzienda, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        anagraficheAziende = anagraficheAziende.OrderByDescending((Func<DataLayer.AnagraficaAzienda, object>)orderBy.Value).AsQueryable();
                }
                return anagraficheAziende;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

    }
}
