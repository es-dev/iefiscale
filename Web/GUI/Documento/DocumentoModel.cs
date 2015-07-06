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
                    infoTitle.Text = (obj.Id != 0 ? "DOCUMENTO N." + BusinessLogic.Documento.GetCodifica(obj) : "NUOVO DOCUMENTO") + " | " + BusinessLogic.Customer.GetCodifica(obj.Customer) + 
                        " | " + BusinessLogic.Export.GetCodifica(obj.Customer.Export);
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

                    BindViewCustomer(obj.Customer);
                   
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewCustomer(CustomerDto customer)
        {
            try
            {
                editCustomer.Model = customer;
                editCustomer.Value = BusinessLogic.Customer.GetCodifica(customer);
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

                    var customer = (CustomerDto)editCustomer.Model;
                    if (customer != null)
                        obj.CustomerId = customer.Id;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCustomer_ComboClick()
        {
            try
            {
                var view = new Customer.CustomerView();
                view.Title = "SELEZIONA UN CUSTOMER'";
                editCustomer.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editCustomer_ComboConfirm(object model)
        {
            try
            {
                var customer = (CustomerDto)model;
                BindViewCustomer(customer);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}
