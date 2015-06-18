using Library.Code;
using Library.Interfaces;
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
	public partial class CustomerItem : TemplateItem
	{
        public CustomerItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (CustomerDto)model;
                    infoImage.Image = "Images.dashboard.azienda.png";
                    infoDenominazione.Text = BusinessLogic.Customer.GetCodifica(obj);
                    infoPartitaIva.Text = BusinessLogic.Cliente.GetPartitaIva(obj.Cliente);
                    infoIndirizzo.Text = BusinessLogic.Cliente.GetIndirizzo(obj.Cliente);
                    infoExport.Text = BusinessLogic.Export.GetCodifica(obj.Export);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
