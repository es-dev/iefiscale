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
                    var obj = (ExportDto)model;
                    infoSubtitle.Text = BusinessLogic.Export.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.cliente.png";
                    infoTitle.Text = (obj.Id != 0 ? "EXPORT N." + BusinessLogic.Export.GetCodifica(obj) : "NUOVO EXPORT") + " | " + BusinessLogic.Comunicazione.GetCodifica(obj.Comunicazione);
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
                    var obj = (ExportDto)model;
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

        private void BindViewComunicazione(ComunicazioneDto comunicazione)
        {
            try
            {
                editComunicazione.Model = comunicazione;
                editComunicazione.Value = BusinessLogic.Comunicazione.GetCodifica(comunicazione);
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

                    var comunicazione = (ComunicazioneDto)editComunicazione.Model;
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
                BindViewComunicazione(comunicazione);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}
