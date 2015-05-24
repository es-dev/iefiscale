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

namespace Web.GUI.Documento
{
    public partial class DocumentoModel : TemplateModel
    {
        public DocumentoModel()
        {
            InitializeComponent();
        }

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.DocumentoDto)model;
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
                    var obj = (WcfService.Dto.DocumentoDto)model;
                    editIDMovimento.Value = obj.IDMovimento;
                    editIDRegistroIVA.Value = obj.IDRegistroIVA;
                    editIDCausale.Value = obj.IDCausale;
                    editNumero.Value = obj.Numero;
                    editTipo.Value = obj.Tipo;
                    editData.Value = obj.Data;
                    editDataRegistrazione.Value = obj.DataRegistrazione;
                    editIDIVA.Value = obj.IDIVA;
                    editIDCliente.Value = obj.IDCliente;
                    editImponibile.Value = obj.Imponibile;
                    editIVA.Value = obj.IVA;
                    editTotale.Value = obj.Totale;
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
                    var obj = (WcfService.Dto.DocumentoDto)model;
                    obj.IDMovimento = editIDMovimento.Value;
                    obj.IDRegistroIVA = editIDRegistroIVA.Value;
                    obj.IDConto = editIDConto.Value;
                    obj.Numero = editNumero.Value;
                    obj.IDCausale = editIDCausale.Value;
                    obj.Tipo = editTipo.Value;
                    obj.IDIVA = editIDIVA.Value;
                    obj.IDCliente = editIDCliente.Value;
                    obj.Data = editData.Value;
                    obj.DataRegistrazione = editDataRegistrazione.Value;
                    obj.Imponibile = editImponibile.Value;
                    obj.IVA = editIVA.Value;
                    obj.Totale = editTotale.Value;

                    var export = (WcfService.Dto.ExportDto)editExport.Model;
                    if (export != null)
                        obj.ExportId = export.Id;    // todo: da verificare relazione 1:1
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
