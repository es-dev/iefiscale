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

namespace Web.GUI.Export
{
	public partial class ExportModel : TemplateModel
	{
        public ExportModel()
		{
			InitializeComponent();
		}

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ExportDto)model;
                    infoSubtitle.Text =  "";
                    infoSubtitleImage.Image = "Images.dashboard.cliente.png";
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
                    var obj = (WcfService.Dto.ExportDto)model;
                    editData.Value = obj.Data;
                    editProgressivo.Value = obj.Progressivo;
                    editXMLFile.Value = obj.XmlFile;
                    editStato.Value = obj.Stato;
                    BindViewComunicazione(obj.Comunicazione);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewComunicazione(WcfService.Dto.ComunicazioneDto comunicazioneDto)
        {
            try
            {
                editComunicazione.Model = comunicazioneDto;
                editComunicazione.Value = (comunicazioneDto != null ? comunicazioneDto.Numero : null);  //todo: da sistemare
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
                    var obj = (WcfService.Dto.ExportDto)model;
                    obj.Data = editData.Value;
                    obj.Progressivo = editProgressivo.Value;
                    obj.XmlFile = editXMLFile.Value;
                    obj.Stato = editStato.Value;
                    var comunicazione = (WcfService.Dto.ComunicazioneDto)editComunicazione.Model;
                    if (comunicazione != null)
                        obj.ComunicazioneId = comunicazione.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editComunicazione_ComboClick()
        {
            try
            {
                var view = new Comunicazione.ComunicazioneView();
                view.Title = "SELEZIONA UNA COMUNICAZIONE'";
                editComunicazione.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editComunicazione_ComboConfirm(object model)
        {
            try
            {
                var comunicazione = (ComunicazioneDto)model;
                if (comunicazione != null)
                    editComunicazione.Value = comunicazione.Numero;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       	}
}
