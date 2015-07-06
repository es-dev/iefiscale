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

        public Dto.AnagraficaAziendaDto ReadAnagraficaAzienda(string partitaIva)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var anagraficaAzienda = (from q in ef.AnagraficaAziendas where q.PartitaIVA == partitaIva select q).FirstOrDefault();
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

        #region Azienda
        #region CRUD
        public Dto.AziendaDto CreateAzienda(Dto.AziendaDto azienda)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateAzienda(azienda);
                var newAzienda = wcf.ReadAzienda(dtoKey);
                return newAzienda;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.AziendaDto> ReadAziende()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var aziende = wcf.ReadAziendas();
                return aziende;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateAzienda(Dto.AziendaDto azienda)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateAzienda(azienda);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteAzienda(Dto.AziendaDto azienda)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteAzienda(azienda);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountAziende()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.AziendasCount();
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
        public IEnumerable<Dto.AziendaDto> LoadAziende(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var aziende = QueryAziende(search, advancedSearch, orderBy);
                aziende = (from q in aziende select q).Skip(skip).Take(take);
                var aziendeDto = UtilityPOCO.Assemble<Dto.AziendaDto>(aziende);
                return aziendeDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountAziende(string search = null, object advancedSearch = null)
        {
            try
            {
                var aziende = QueryAziende(search, advancedSearch);
                var count = aziende.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.AziendaDto ReadAzienda(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var azienda = (from q in ef.Aziendas where q.Id == (int)id select q).FirstOrDefault();
                var aziendaDto = UtilityPOCO.Assemble<Dto.AziendaDto>(azienda);
                return aziendaDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Azienda> QueryAziende(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var aziende = (from q in ef.Aziendas select q);

                if (search != null && search.Length > 0)
                    aziende = (from q in aziende
                                          where q.IDAzienda.StartsWith(search) || q.TipoSoftwareFatturazione.StartsWith(search)
                                          select q);

                if (advancedSearch != null)
                    aziende = aziende.Where((Func<DataLayer.Azienda, bool>)advancedSearch).AsQueryable();

                aziende = (from q in aziende orderby q.IDAzienda select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        aziende = aziende.OrderBy((Func<DataLayer.Azienda, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        aziende = aziende.OrderByDescending((Func<DataLayer.Azienda, object>)orderBy.Value).AsQueryable();
                }
                return aziende;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Cliente
        #region CRUD
        public Dto.ClienteDto CreateCliente(Dto.ClienteDto cliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateCliente(cliente);
                var newCliente = wcf.ReadCliente(dtoKey);
                return newCliente;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ClienteDto> ReadClienti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var clienti = wcf.ReadClientes();
                return clienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateCliente(Dto.ClienteDto cliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateCliente(cliente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteCliente(Dto.ClienteDto cliente)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteCliente(cliente);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountClienti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ClientesCount();
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
        public IEnumerable<Dto.ClienteDto> LoadClienti(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var clienti = QueryClienti(search, advancedSearch, orderBy);
                clienti = (from q in clienti select q).Skip(skip).Take(take);
                var clientiDto = UtilityPOCO.Assemble<Dto.ClienteDto>(clienti);
                return clientiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountClienti(string search = null, object advancedSearch = null)
        {
            try
            {
                var clienti = QueryClienti(search, advancedSearch);
                var count = clienti.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ClienteDto ReadCliente(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var cliente = (from q in ef.Clientes where q.Id == (int)id select q).FirstOrDefault();
                var clienteDto = UtilityPOCO.Assemble<Dto.ClienteDto>(cliente);
                return clienteDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Cliente> QueryClienti(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var clienti = (from q in ef.Clientes select q);

                if (search != null && search.Length > 0)
                    clienti = (from q in clienti
                               where q.IDCliente.StartsWith(search) || q.IDConto.StartsWith(search)
                               select q);

                if (advancedSearch != null)
                    clienti = clienti.Where((Func<DataLayer.Cliente, bool>)advancedSearch).AsQueryable();

                clienti = (from q in clienti orderby q.IDCliente select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        clienti = clienti.OrderBy((Func<DataLayer.Cliente, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        clienti = clienti.OrderByDescending((Func<DataLayer.Cliente, object>)orderBy.Value).AsQueryable();
                }
                return clienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Contabilita
        #region CRUD
        public Dto.ContabilitaDto CreateContabilita(Dto.ContabilitaDto contabilita)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateContabilita(contabilita);
                var newContabilita = wcf.ReadContabilita(dtoKey);
                return newContabilita;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ContabilitaDto> ReadContabilitas()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var contabilitas = wcf.ReadContabilitas();
                return contabilitas;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateContabilita(Dto.ContabilitaDto contabilita)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateContabilita(contabilita);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteContabilita(Dto.ContabilitaDto contabilita)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteContabilita(contabilita);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountContabilitas()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ContabilitasCount();
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
        public IEnumerable<Dto.ContabilitaDto> LoadContabilitas(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var contabilitas = QueryContabilitas(search, advancedSearch, orderBy);
                contabilitas = (from q in contabilitas select q).Skip(skip).Take(take);
                var contabilitasDto = UtilityPOCO.Assemble<Dto.ContabilitaDto>(contabilitas);
                return contabilitasDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountContabilitas(string search = null, object advancedSearch = null)
        {
            try
            {
                var contabilita = QueryContabilitas(search, advancedSearch);
                var count = contabilita.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ContabilitaDto ReadContabilita(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var contabilita = (from q in ef.Contabilitas where q.Id == (int)id select q).FirstOrDefault();
                var contabilitaDto = UtilityPOCO.Assemble<Dto.ContabilitaDto>(contabilita);
                return contabilitaDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Contabilita> QueryContabilitas(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var contabilitas = (from q in ef.Contabilitas select q);

                if (search != null && search.Length > 0)
                    contabilitas = (from q in contabilitas
                               where q.Tipo.StartsWith(search) select q);

                if (advancedSearch != null)
                    contabilitas = contabilitas.Where((Func<DataLayer.Contabilita, bool>)advancedSearch).AsQueryable();

                contabilitas = (from q in contabilitas orderby q.Anno select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        contabilitas = contabilitas.OrderBy((Func<DataLayer.Contabilita, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        contabilitas = contabilitas.OrderByDescending((Func<DataLayer.Contabilita, object>)orderBy.Value).AsQueryable();
                }
                return contabilitas;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Comunicazione
        #region CRUD
        public Dto.ComunicazioneDto CreateComunicazione(Dto.ComunicazioneDto comunicazione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateComunicazione(comunicazione);
                var newComunicazione = wcf.ReadComunicazione(dtoKey);
                return newComunicazione;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ComunicazioneDto> ReadComunicazioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var comunicazioni = wcf.ReadComunicaziones();
                return comunicazioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateComunicazione(Dto.ComunicazioneDto comunicazione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateComunicazione(comunicazione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteComunicazione(Dto.ComunicazioneDto comunicazione)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteComunicazione(comunicazione);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountComunicazioni()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ComunicazionesCount();
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
        public IEnumerable<Dto.ComunicazioneDto> LoadComunicazioni(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var comunicazioni = QueryComunicazioni(search, advancedSearch, orderBy);
                comunicazioni = (from q in comunicazioni select q).Skip(skip).Take(take);
                var comunicazioniDto = UtilityPOCO.Assemble<Dto.ComunicazioneDto>(comunicazioni);
                return comunicazioniDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountComunicazioni(string search = null, object advancedSearch = null)
        {
            try
            {
                var comunicazioni = QueryComunicazioni(search, advancedSearch);
                var count = comunicazioni.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ComunicazioneDto ReadComunicazione(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var comunicazione = (from q in ef.Contabilitas where q.Id == (int)id select q).FirstOrDefault();
                var comunicazioneDto = UtilityPOCO.Assemble<Dto.ComunicazioneDto>(comunicazione);
                return comunicazioneDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Comunicazione> QueryComunicazioni(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var comunicazioni = (from q in ef.Comunicaziones select q);

                if (search != null && search.Length > 0)
                    comunicazioni = (from q in comunicazioni
                                     where q.Numero.StartsWith(search) select q);

                if (advancedSearch != null)
                    comunicazioni = comunicazioni.Where((Func<DataLayer.Comunicazione, bool>)advancedSearch).AsQueryable();

                comunicazioni = (from q in comunicazioni orderby q.Numero select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        comunicazioni = comunicazioni.OrderBy((Func<DataLayer.Comunicazione, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        comunicazioni = comunicazioni.OrderByDescending((Func<DataLayer.Comunicazione, object>)orderBy.Value).AsQueryable();
                }
                return comunicazioni;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Export
        #region CRUD
        public Dto.ExportDto CreateExport(Dto.ExportDto export)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateExport(export);
                var newExport = wcf.ReadExport(dtoKey);
                return newExport;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ExportDto> ReadExports()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var exports = wcf.ReadExports();
                return exports;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateExport(Dto.ExportDto export)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateExport(export);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteExport(Dto.ExportDto export)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteExport(export);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountExports()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ExportsCount();
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
        public IEnumerable<Dto.ExportDto> LoadExports(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var exports = QueryExports(search, advancedSearch, orderBy);
                exports = (from q in exports select q).Skip(skip).Take(take);
                var exportsDto = UtilityPOCO.Assemble<Dto.ExportDto>(exports);
                return exportsDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountExports(string search = null, object advancedSearch = null)
        {
            try
            {
                var exports = QueryExports(search, advancedSearch);
                var count = exports.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ExportDto ReadExport(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var export = (from q in ef.Exports where q.Id == (int)id select q).FirstOrDefault();
                var exportDto = UtilityPOCO.Assemble<Dto.ExportDto>(export);
                return exportDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Export> QueryExports(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var exports = (from q in ef.Exports select q);

                if (search != null && search.Length > 0)
                    exports = (from q in exports
                               where q.Stato.StartsWith(search) || q.Progressivo.StartsWith(search)
                                     select q);

                if (advancedSearch != null)
                    exports = exports.Where((Func<DataLayer.Export, bool>)advancedSearch).AsQueryable();

                exports = (from q in exports orderby q.Data select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        exports = exports.OrderBy((Func<DataLayer.Export, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        exports = exports.OrderByDescending((Func<DataLayer.Export, object>)orderBy.Value).AsQueryable();
                }
                return exports;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion
        
        #region Import
        #region CRUD
        public Dto.ImportDto CreateImport(Dto.ImportDto import)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateImport(import);
                var newImport = wcf.ReadImport(dtoKey);
                return newImport;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.ImportDto> ReadImports()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var imports = wcf.ReadImports();
                return imports;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateImport(Dto.ImportDto import)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateImport(import);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteImport(Dto.ImportDto import)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteImport(import);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountImports()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.ImportsCount();
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
        public IEnumerable<Dto.ImportDto> LoadImports(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var imports = QueryImports(search, advancedSearch, orderBy);
                imports = (from q in imports select q).Skip(skip).Take(take);
                var importsDto = UtilityPOCO.Assemble<Dto.ImportDto>(imports);
                return importsDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountImports(string search = null, object advancedSearch = null)
        {
            try
            {
                var imports = QueryImports(search, advancedSearch);
                var count = imports.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.ImportDto ReadImport(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var import = (from q in ef.Imports where q.Id == (int)id select q).FirstOrDefault();
                var importDto = UtilityPOCO.Assemble<Dto.ImportDto>(import);
                return importDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Import> QueryImports(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var imports = (from q in ef.Imports select q);

                if (search != null && search.Length > 0)
                    imports = (from q in imports
                               where q.Stato.StartsWith(search)   select q);

                if (advancedSearch != null)
                    imports = imports.Where((Func<DataLayer.Import, bool>)advancedSearch).AsQueryable();

                imports = (from q in imports orderby q.Data select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        imports = imports.OrderBy((Func<DataLayer.Import, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        imports = imports.OrderByDescending((Func<DataLayer.Import, object>)orderBy.Value).AsQueryable();
                }
                return imports;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion
        
        #region Customer
        #region CRUD
        public Dto.CustomerDto CreateCustomer(Dto.CustomerDto customer)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateCustomer(customer);
                var newCustomer = wcf.ReadCustomer(dtoKey);
                return newCustomer;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.CustomerDto> ReadCustomers()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var customers = wcf.ReadCustomers();
                return customers;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateCustomer(Dto.CustomerDto customer)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateCustomer(customer);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteCustomer(Dto.CustomerDto customer)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteCustomer(customer);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountCustomers()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.CustomersCount();
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
        public IEnumerable<Dto.CustomerDto> LoadCustomers(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var customers = QueryCustomers(search, advancedSearch, orderBy);
                customers = (from q in customers select q).Skip(skip).Take(take);
                var customersDto = UtilityPOCO.Assemble<Dto.CustomerDto>(customers);
                return customersDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountCustomers(string search = null, object advancedSearch = null)
        {
            try
            {
                var customers = QueryCustomers(search, advancedSearch);
                var count = customers.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.CustomerDto ReadCustomer(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var customer = (from q in ef.Customers where q.Id == (int)id select q).FirstOrDefault();
                var customerDto = UtilityPOCO.Assemble<Dto.CustomerDto>(customer);
                return customerDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Customer> QueryCustomers(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var customers = (from q in ef.Customers select q);

                if (search != null && search.Length > 0)
                    customers = (from q in customers
                               where q.Cliente.AnagraficaAzienda.RagioneSociale.StartsWith(search) select q);

                if (advancedSearch != null)
                    customers = customers.Where((Func<DataLayer.Customer, bool>)advancedSearch).AsQueryable();

                customers = (from q in customers orderby q.Cliente.AnagraficaAzienda.RagioneSociale select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        customers = customers.OrderBy((Func<DataLayer.Customer, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        customers = customers.OrderByDescending((Func<DataLayer.Customer, object>)orderBy.Value).AsQueryable();
                }
                return customers;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Documento
        #region CRUD
        public Dto.DocumentoDto CreateDocumento(Dto.DocumentoDto documento)
        {
            try
            {
                var wcf = new EntitiesModelService();
                var dtoKey = wcf.CreateDocumento(documento);
                var newDocumento = wcf.ReadDocumento(dtoKey);
                return newDocumento;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public IEnumerable<Dto.DocumentoDto> ReadDocumenti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var documenti = wcf.ReadDocumentos();
                return documenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public bool UpdateDocumento(Dto.DocumentoDto documento)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.UpdateDocumento(documento);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public bool DeleteDocumento(Dto.DocumentoDto documento)
        {
            try
            {
                var wcf = new EntitiesModelService();
                wcf.DeleteDocumento(documento);
                return true;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public int CountDocumenti()
        {
            try
            {
                var wcf = new EntitiesModelService();
                var count = wcf.DocumentosCount();
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
        public IEnumerable<Dto.DocumentoDto> LoadDocumenti(int skip, int take, string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var documenti = QueryDocumenti(search, advancedSearch, orderBy);
                documenti = (from q in documenti select q).Skip(skip).Take(take);
                var documentiDto = UtilityPOCO.Assemble<Dto.DocumentoDto>(documenti);
                return documentiDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public int CountDocumenti(string search = null, object advancedSearch = null)
        {
            try
            {
                var documenti = QueryDocumenti(search, advancedSearch);
                var count = documenti.Count();
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public Dto.DocumentoDto ReadDocumento(object id)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var documento = (from q in ef.Documentos where q.Id == (int)id select q).FirstOrDefault();
                var documentoDto = UtilityPOCO.Assemble<Dto.DocumentoDto>(documento);
                return documentoDto;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private IQueryable<DataLayer.Documento> QueryDocumenti(string search = null, object advancedSearch = null, OrderBy orderBy = null)
        {
            try
            {
                var ef = new DataLayer.EntitiesModel();
                var documenti = (from q in ef.Documentos select q);

                if (search != null && search.Length > 0)
                    documenti = (from q in documenti
                                 where q.Numero.Contains(search) || q.Customer.Cliente.AnagraficaAzienda.RagioneSociale.Contains(search) ||
                                 q.Tipo.Contains(search) || q.IDCausale.Contains(search) || q.IDIVA.Contains(search) || q.IDMovimento.Contains(search) || q.IDRegistroIVA.Contains(search)
                                 select q);

                if (advancedSearch != null)
                    documenti = documenti.Where((Func<DataLayer.Documento, bool>)advancedSearch).AsQueryable();

                documenti = (from q in documenti orderby q.Data select q);
                if (orderBy != null)
                {
                    if (orderBy.Direction == TypeOrder.Ascending)
                        documenti = documenti.OrderBy((Func<DataLayer.Documento, object>)orderBy.Value).AsQueryable();
                    else if (orderBy.Direction == TypeOrder.Descending)
                        documenti = documenti.OrderByDescending((Func<DataLayer.Documento, object>)orderBy.Value).AsQueryable();
                }
                return documenti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
        #endregion
        #endregion

        #region Ipsoa
        #region Custom

        public DataLayer.DataSetIpsoa.NominativiDataTable ReadNominativi(string pathFileName)
        {
            try
            {
                var adapter = DataLayer.IpsoaDataAdapter.GetDataAdapterNominativi(pathFileName);
                var nominativi = adapter.GetData();
                return nominativi;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public DataLayer.DataSetIpsoa.NClientiDataTable ReadClienti(string pathFileName)
        {
            try
            {
                var adapter = DataLayer.IpsoaDataAdapter.GetDataAdapterClienti(pathFileName);
                var clienti = adapter.GetData();
                return clienti;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public void ImportAnagraficaAzienda(Dto.AnagraficaAziendaDto anagraficaAzienda)
        {
            try
            {
                if (anagraficaAzienda != null)
                {
                    var performed = false;
                    if (anagraficaAzienda.Id > 0)
                        performed = UpdateAnagraficaAzienda(anagraficaAzienda);
                    else
                    {
                        var newAnagraficaAzienda = CreateAnagraficaAzienda(anagraficaAzienda);
                        performed = (newAnagraficaAzienda != null);
                    }

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        #endregion
        #endregion




        
    }
}
