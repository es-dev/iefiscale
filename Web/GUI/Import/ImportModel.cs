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
                    var obj = (ImportDto)model;
                    infoSubtitle.Text = BusinessLogic.Import.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.import.png";
                    infoTitle.Text = (obj.Id != 0 ? "IMPORT N." + BusinessLogic.Import.GetCodifica(obj) : "NUOVO IMPORT") + " | " + BusinessLogic.Export.GetCodifica(obj.Export);
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
                    var obj = (ImportDto)model;
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

        private void BindViewExport(ExportDto export)
        {
            try
            {
                editExport.Model = export;
                editExport.Value = BusinessLogic.Export.GetCodifica(export);
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
                    var obj = (ImportDto)model;
                    
                    var viewModel = (ImportViewModel)ViewModel;
                    viewModel.OldImport = obj;

                    obj.Data = editData.Value;
                    obj.TXTMovimenti = editTXTMovimenti.Value;
                    obj.TXTClienti = editTXTClienti.Value;
                    obj.Stato = editStato.Value;

                    var export = (ExportDto)editExport.Model;
                    if (export != null)
                        obj.Id = export.Id;    
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
                BindViewExport(export);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}
