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
                    var obj = (CustomerDto)model;
                    infoSubtitle.Text = BusinessLogic.Customer.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.cliente.png";
                    infoTitle.Text = (obj.Id != 0 ? "CUSTOMER " + BusinessLogic.Customer.GetCodifica(obj) : "NUOVO CUSTOMER") + " | " + BusinessLogic.Export.GetCodifica(obj.Export);
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
                    var obj = (CustomerDto)model;
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
                if (cliente != null)
                {
                    var anagraficaAzienda = cliente.AnagraficaAzienda;
                    if (anagraficaAzienda != null)
                    {
                        editCliente.Model = anagraficaAzienda;
                        editCliente.Value = BusinessLogic.AnagraficaAzienda.GetCodifica(anagraficaAzienda);
                        editCAP.Value = anagraficaAzienda.Cap;
                        editComune.Value = new Countries.City(anagraficaAzienda.Comune, anagraficaAzienda.CodiceCatastale, anagraficaAzienda.Provincia);
                        editIndirizzo.Value = anagraficaAzienda.Indirizzo;
                        editCodiceFiscale.Value = anagraficaAzienda.CodiceFiscale;
                        editPartitaIVA.Value = anagraficaAzienda.PartitaIVA;
                        editTelefono.Value = anagraficaAzienda.Telefono;
                        editFax.Value = anagraficaAzienda.Fax;
                        editEmail.Value = anagraficaAzienda.Email;
                    }
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
                    var obj = (CustomerDto)model;

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
