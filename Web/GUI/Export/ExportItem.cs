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
                    var comunicazione = obj.Comunicazione;
                    var numeroComunicazione = comunicazione.Numero;
                    var data = UtilityValidation.GetStringND(obj.Data);
                    var stato = UtilityValidation.GetStringND(obj.Stato);
                    var progressivo = UtilityValidation.GetStringND(obj.Progressivo);

                    infoImage.Image = "Images.dashboard.azienda.png";
                    infoProgressivo.Text = "EXPORT N. " + progressivo;
                    infoComunicazione.Text = "Comunicazione N. " + numeroComunicazione;
                    infoData.Text ="Data: " + data;
                    infoStato.Text ="Stato: "+ stato;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
