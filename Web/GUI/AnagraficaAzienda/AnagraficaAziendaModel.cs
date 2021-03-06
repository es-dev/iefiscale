using Library.Code;
using Library.Controls;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using WcfService.Dto;
using Web.Code;

namespace Web.GUI.AnagraficaAzienda
{
	public partial class AnagraficaAziendaModel : TemplateModel
	{
        public AnagraficaAziendaModel()
		{
			InitializeComponent();
		}

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (AnagraficaAziendaDto)model;
                    infoSubtitle.Text = BusinessLogic.AnagraficaAzienda.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.anagraficaazienda.png";
                    infoTitle.Text = (obj.Id != 0 ? "ANAGRAFICA AZIENDA - " + BusinessLogic.AnagraficaAzienda.GetCodifica(obj) : "NUOVA ANAGRAFICA AZIENDA"); 
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)  
        {
            try
            {
                if (model != null)
                {
                    var obj = (AnagraficaAziendaDto)model;
                    editRagioneSociale.Value = obj.RagioneSociale;
                    editCAP.Value = obj.Cap;
                    editComune.Value = new Countries.City(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editIndirizzo.Value = obj.Indirizzo;
                    editCodiceFiscale.Value = obj.CodiceFiscale;
                    editPartitaIVA.Value = obj.PartitaIVA;
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editEmail.Value = obj.Email;

                    BindViewStudioCommerciale(obj.StudioCommerciale);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewStudioCommerciale(StudioCommercialeDto studioCommerciale)
        {
            try
            {
                editStudioCommerciale.Model = studioCommerciale;
                editStudioCommerciale.Value =  BusinessLogic.StudioCommerciale.GetCodifica(studioCommerciale);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (AnagraficaAziendaDto)model;
                    obj.RagioneSociale = editRagioneSociale.Value;
                    obj.Cap = editCAP.Value;
                    obj.Comune = editComune.Value.Description;
                    obj.CodiceCatastale = editComune.Value.Code;
                    obj.Provincia = editComune.Value.County;
                    obj.CodiceFiscale = editCodiceFiscale.Value;
                    obj.Indirizzo = editIndirizzo.Value;
                    obj.PartitaIVA = editPartitaIVA.Value;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Email = editEmail.Value;

                    var studioCommerciale = (WcfService.Dto.StudioCommercialeDto)editStudioCommerciale.Model;
                    if (studioCommerciale != null)
                        obj.StudioCommercialeId = studioCommerciale.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editStudioCommerciale_ComboClick()
        {
            try
            {
                var view = new StudioCommerciale.StudioCommercialeView();
                view.Title = "SELEZIONA UNO STUDIO COMMERCIALE";
                editStudioCommerciale.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editStudioCommerciale_ComboConfirm(object model)
        {
            try
            {
                var studioCommerciale = (StudioCommercialeDto)model;
                BindViewStudioCommerciale(studioCommerciale);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
