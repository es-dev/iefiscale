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
                    var obj = (ExportDto)model;

                    infoImage.Image = "Images.dashboard.export.png";
                    infoExport.Text = "EXPORT N." + BusinessLogic.Export.GetCodifica(obj);
                    infoComunicazione.Text = "Comunicazione N." + BusinessLogic.Comunicazione.GetCodifica(obj.Comunicazione);
                    infoData.Text = "Eseguito il " + UtilityValidation.GetStringND(obj.Data); 
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
