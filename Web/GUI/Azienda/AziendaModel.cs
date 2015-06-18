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

namespace Web.GUI.Azienda
{
	public partial class AziendaModel : TemplateModel
	{
        public AziendaModel()
		{
			InitializeComponent();
		}

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AziendaDto)model;
                    infoSubtitle.Text = BusinessLogic.Azienda.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.azienda.png";
                    infoTitle.Text = (obj.Id != 0 ? "AZIENDA " + BusinessLogic.Azienda.GetCodifica(obj): "NUOVA AZIENDA");
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
                    var obj = (WcfService.Dto.AziendaDto)model;
                    editTipoContabilita.Value = obj.TipoContabilita;
                    editTipoSoftwareFatturazione.Value = obj.TipoSoftwareFatturazione;
                    editUltimoAggiornamento.Value = obj.UltimoAggiornamento;
                    editMdbFile.Value = obj.MdbFile;
                    editIDAzienda.Value = obj.IDAzienda;

                    BindViewStudioCommerciale(obj.StudioCommerciale);
                    BindViewAnagraficaAzienda(obj.AnagraficaAzienda);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAnagraficaAzienda(AnagraficaAziendaDto anagraficaAzienda)
        {
            try
            {
                editRagioneSociale.Model = anagraficaAzienda;
                editRagioneSociale.Value = BusinessLogic.AnagraficaAzienda.GetCodifica(anagraficaAzienda);
                editCAP.Value = anagraficaAzienda.Cap;
                editComune.Value = new Countries.City(anagraficaAzienda.Comune, anagraficaAzienda.CodiceCatastale, anagraficaAzienda.Provincia);
                editIndirizzo.Value = anagraficaAzienda.Indirizzo;
                editCodiceFiscale.Value = anagraficaAzienda.CodiceFiscale;
                editPartitaIVA.Value = anagraficaAzienda.PartitaIVA;
                editTelefono.Value = anagraficaAzienda.Telefono;
                editFAX.Value = anagraficaAzienda.Fax;
                editEmail.Value = anagraficaAzienda.Email;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewStudioCommerciale(WcfService.Dto.StudioCommercialeDto studioCommerciale)
        {
            try
            {
                editStudioCommerciale.Model = studioCommerciale;
                editStudioCommerciale.Value = BusinessLogic.StudioCommerciale.GetCodifica(studioCommerciale);
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
                    var obj = (WcfService.Dto.AziendaDto)model;
                    obj.TipoContabilita = editTipoContabilita.Value;
                    obj.UltimoAggiornamento = editUltimoAggiornamento.Value;
                    obj.MdbFile = editMdbFile.Value;
                    obj.TipoSoftwareFatturazione = editTipoSoftwareFatturazione.Value;
                    obj.IDAzienda = editIDAzienda.Value;

                    var studioCommerciale = (WcfService.Dto.StudioCommercialeDto)editStudioCommerciale.Model;
                    if (studioCommerciale != null)
                        obj.StudioCommercialeId = studioCommerciale.Id;

                    var anagraficaAzienda = (WcfService.Dto.AnagraficaAziendaDto)editRagioneSociale.Model;
                    if (anagraficaAzienda != null)
                        obj.AnagraficaAziendaId = anagraficaAzienda.Id;
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

        private void editAnagraficaAzienda_ComboClick()
        {
            try
            {
                var view = new AnagraficaAzienda.AnagraficaAziendaView();
                view.Title = "SELEZIONA UN'AZIENDA DALL'ANAGRAFICA";
                editRagioneSociale.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void editAnagraficaAzienda_ComboConfirm(object model)
        {
            var anagraficaAzienda = (AnagraficaAziendaDto)model;
            BindViewAnagraficaAzienda(anagraficaAzienda);
        }
	}
}
