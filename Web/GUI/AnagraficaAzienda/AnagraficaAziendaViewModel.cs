using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.AnagraficaAzienda
{
    public class AnagraficaAziendaViewModel : Library.Template.MVVM.TemplateViewModel<AnagraficaAziendaView, AnagraficaAziendaItem, AnagraficaAziendaModel, AnagraficaAziendaDto>
    {

        public AnagraficaAziendaViewModel()
            : base() 
        {
            try
            {

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void Load(int skip, int take, string search=null, object advancedSearch=null, OrderBy orderBy=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.LoadAnagraficheAziende(skip, take, search,advancedSearch, orderBy);
                Load(objs);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override int Count(string search = null,  object advancedSearch=null)
        {
            try
            {
                var wcf = new WcfService.Service();
                var count = wcf.CountAnagraficheAziende(search, advancedSearch);
                return count;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return 0;
        }

        public override bool Save(object model, bool creating)
        {
            try
            {
                if (model != null)
                {
                    var wcf = new WcfService.Service();
                    var obj = (AnagraficaAziendaDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateAnagraficaAzienda(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateAnagraficaAzienda(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public override bool Delete(object model)
        {
            try
            {
                if (model != null)
                {
                    var wcf = new WcfService.Service();
                    var obj = (AnagraficaAziendaDto)model;
                    bool performed = wcf.DeleteAnagraficaAzienda(obj);
                    return performed;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return false;
        }

        public override object Read(object id)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadAnagraficaAzienda(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public AnagraficaAziendaDto Read(string partitaIva)
        {
            try
            {
                var wcf = new WcfService.Service();
                var obj = wcf.ReadAnagraficaAzienda(partitaIva);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;

        }

        internal IEnumerable<AnagraficaAziendaDto> ReadAnagraficheAziende()
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadAnagraficheAziende();
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}