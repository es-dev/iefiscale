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
                    infoSubtitle.Text =  "";
                    infoSubtitleImage.Image = "Images.dashboard.azienda.png";
                    infoTitle.Text = ""; //(obj.Id != 0 ? "AZIENDA " + obj.RagioneSociale : "NUOVA AZIENDA");
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

                    BindViewStudioCommerciale(obj.StudioCommerciale);
                    BindViewAnagraficaAzienda(obj.AnagraficaAzienda);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAnagraficaAzienda(AnagraficaAziendaDto anagraficaAziendaDto)
        {
            try
            {
                editAnagraficaAzienda.Model = anagraficaAziendaDto;
                editAnagraficaAzienda.Value = (anagraficaAziendaDto != null ? anagraficaAziendaDto.RagioneSociale : null);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewStudioCommerciale(WcfService.Dto.StudioCommercialeDto studioCommercialeDto)
        {
            try
            {
                editStudioCommerciale.Model = studioCommercialeDto;
                editStudioCommerciale.Value = (studioCommercialeDto != null ? studioCommercialeDto.Denominazione : null);
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

                    var studioCommerciale = (WcfService.Dto.StudioCommercialeDto)editStudioCommerciale.Model;
                    if (studioCommerciale != null)
                        obj.StudioCommercialeId = studioCommerciale.Id;

                    var anagraficaAzienda = (WcfService.Dto.AnagraficaAziendaDto)editAnagraficaAzienda.Model;
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
                if (studioCommerciale != null)
                    editStudioCommerciale.Value = studioCommerciale.Denominazione;
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
                editAnagraficaAzienda.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void editAnagraficaAzienda_ComboConfirm(object model)
        {
            var anagraficaAzienda = (AnagraficaAziendaDto)model;
            if (anagraficaAzienda != null)
                editAnagraficaAzienda.Value = anagraficaAzienda.RagioneSociale;
        }
	}
}
