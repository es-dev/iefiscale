﻿using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfService.Dto;

namespace Web.GUI.Azienda
{
    public class AziendaViewModel : Library.Template.MVVM.TemplateViewModel<AziendaView, AziendaItem, AziendaModel, AziendaDto>
    {

        public AziendaViewModel()
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
                var objs = wcf.LoadAziende(skip, take, search,advancedSearch, orderBy);
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
                var count = wcf.CountAziende(search, advancedSearch);
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
                    var obj = (AziendaDto)model;
                    bool performed = false;
                    if (creating)
                    {
                        var newObj = wcf.CreateAzienda(obj);
                        performed = (newObj != null);
                        if (performed)
                            Update(obj, newObj);
                    }
                    else //updating
                        performed = wcf.UpdateAzienda(obj);
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
                    var obj = (AziendaDto)model;
                    bool performed = wcf.DeleteAzienda(obj);
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
                var obj = wcf.ReadAzienda(id);
                return obj;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal IEnumerable<AziendaDto> ReadAziende()
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadAziende();
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal DataLayer.DataSetIpsoa.NominativiDataTable ReadNominativi(string pathFileName)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadNominativi(pathFileName);
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal DataLayer.DataSetIpsoa.NClientiDataTable ReadClienti(string pathFileName)
        {
            try
            {
                var wcf = new WcfService.Service();
                var objs = wcf.ReadClienti(pathFileName);
                return objs;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        internal void ImportAnagraficaAzienda(AnagraficaAziendaDto anagraficaAzienda)
        {
            try
            {
                var wcf = new WcfService.Service();
                wcf.ImportAnagraficaAzienda(anagraficaAzienda);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}