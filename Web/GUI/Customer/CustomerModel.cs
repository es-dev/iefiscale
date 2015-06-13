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

namespace Web.GUI.Customer
{
    public partial class CustomerModel : TemplateModel
    {
        public CustomerModel()
        {
            InitializeComponent();
        }

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.CustomerDto)model;
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
                    var obj = (WcfService.Dto.CustomerDto)model;
                    editRagioneSociale.Value = obj.RagioneSociale;
                    editCAP.Value = obj.Cap;
                    editComune.Value = new Countries.City(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editIndirizzo.Value = obj.Indirizzo;
                    editCodiceFiscale.Value = obj.CodiceFiscale;
                    editPartitaIVA.Value = obj.PartitaIVA;
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editEmail.Value = obj.Email;
                    editIDCliente.Value = obj.IDCliente;

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
                    var obj = (WcfService.Dto.CustomerDto)model;
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
                    obj.IDCliente = editIDCliente.Value;

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
