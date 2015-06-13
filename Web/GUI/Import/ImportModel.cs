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

namespace Web.GUI.Import
{
    public partial class ImportModel : TemplateModel
    {
        public ImportModel()
        {
            InitializeComponent();
        }

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ImportDto)model;
                    infoSubtitle.Text = "";
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
                    var obj = (WcfService.Dto.ImportDto)model;
                    editData.Value = obj.Data;
                    editTXTMovimenti.Value = obj.TXTMovimenti;
                    editTXTClienti.Value = obj.TXTClienti;
                    editStato.Value = obj.Stato;

                    BindViewExport(obj.Export);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewExport(WcfService.Dto.ExportDto exportDto)
        {
            try
            {
                editExport.Model = exportDto;
                editExport.Value = (exportDto != null ? exportDto.Progressivo : null);  //todo: da sistemare
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
                    var obj = (WcfService.Dto.ImportDto)model;
                    obj.Data = editData.Value;
                    obj.TXTMovimenti = editTXTMovimenti.Value;
                    obj.TXTClienti = editTXTClienti.Value;
                    obj.Stato = editStato.Value;
                    var export = (WcfService.Dto.ExportDto)editExport.Model;
                    if (export != null)
                        obj.Id = export.Id;    // todo: da verificare relazione 1:1
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editExport_ComboClick()
        {
            try
            {
                var view = new Export.ExportView();
                view.Title = "SELEZIONA UN EXPORT'";
                editExport.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editExport_ComboConfirm(object model)
        {
            try
            {
                var export = (ExportDto)model;
                if (export != null)
                    editExport.Value = export.Progressivo;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}
