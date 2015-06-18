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
                    var obj = (DocumentoDto)model;
                    infoSubtitle.Text = BusinessLogic.Documento.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.documento.png";
                    infoTitle.Text = (obj.Id != 0 ? "DOCUMENTO N." + BusinessLogic.Documento.GetCodifica(obj) : "NUOVO DOCUMENTO") + " | " + BusinessLogic.Export.GetCodifica(obj.Export);
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
                    var obj = (DocumentoDto)model;
                    editIDMovimento.Value = obj.IDMovimento;
                    editIDRegistroIVA.Value = obj.IDRegistroIVA;
                    editIDCausale.Value = obj.IDCausale;
                    editNumero.Value = obj.Numero;
                    editTipo.Value = obj.Tipo;
                    editData.Value = obj.Data;
                    editDataRegistrazione.Value = obj.DataRegistrazione;
                    editIDIVA.Value = obj.IDIVA;
                    editImponibile.Value = obj.Imponibile;
                    editIVA.Value = obj.IVA;
                    editTotale.Value = obj.Totale;

                    BindViewCliente(obj.Cliente);
                    BindViewExport(obj.Export);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCliente(ClienteDto cliente)
        {
            try
            {
                editCliente.Model = cliente;
                editCliente.Value = BusinessLogic.Cliente.GetCodifica(cliente);
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
                    var obj = (DocumentoDto)model;
                    obj.IDMovimento = editIDMovimento.Value;
                    obj.IDRegistroIVA = editIDRegistroIVA.Value;
                    obj.Numero = editNumero.Value;
                    obj.IDCausale = editIDCausale.Value;
                    obj.Tipo = editTipo.Value;
                    obj.IDIVA = editIDIVA.Value;
                    obj.Data = editData.Value;
                    obj.DataRegistrazione = editDataRegistrazione.Value;
                    obj.Imponibile = editImponibile.Value;
                    obj.IVA = editIVA.Value;
                    obj.Totale = editTotale.Value;

                    var export = (ExportDto)editExport.Model;
                    if (export != null)
                        obj.ExportId = export.Id;

                    var cliente = (ClienteDto)editCliente.Model;
                    if (cliente != null)
                        obj.ClienteId = cliente.Id;
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

        private void editCliente_ComboClick()
        {
            try
            {
                var view = new Cliente.ClienteView();
                view.Title = "SELEZIONA UN CLIENTE'";
                editCliente.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCliente_ComboConfirm(object model)
        {
            try
            {
                var cliente = (ClienteDto)model;
                BindViewCliente(cliente);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}
