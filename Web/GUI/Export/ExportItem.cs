using Library.Code;
using Library.Interfaces;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.Export
{
	public partial class ExportItem : TemplateItem
	{
        public ExportItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ExportDto)model;

                    infoImage.Image = "Images.dashboard.azienda.png";
                    infoExport.Text = "EXPORT N. " + BusinessLogic.Export.GetCodifica(obj);
                    infoComunicazione.Text = "Comunicazione N. " + BusinessLogic.Comunicazione.GetCodifica(obj.Comunicazione);
                    infoData.Text = "Data: " + UtilityValidation.GetStringND(obj.Data); 
                    infoStato.Text ="Stato: "+ obj.Stato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
