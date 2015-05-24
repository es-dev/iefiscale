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

namespace Web.GUI.StudioCommerciale
{
	public partial class StudioCommercialeItem : TemplateItem
	{
        public StudioCommercialeItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.StudioCommercialeDto)model;
                    var indirizzo = UtilityValidation.GetStringND(obj.Indirizzo);
                    var cap = UtilityValidation.GetStringND(obj.Cap);
                    var comune = UtilityValidation.GetStringND(obj.Comune);
                    var provincia = UtilityValidation.GetStringND(obj.Provincia);
                    var denominazione = UtilityValidation.GetStringND(obj.Denominazione);
                    var tipoSoftwareContabilita = UtilityValidation.GetStringND(obj.TipoSoftwareContabilita);

                    infoImage.Image = "Images.dashboard.azienda.png";
                    infoDenominazione.Text = denominazione;
                    infoIndirizzo.Text = indirizzo + " - " + cap + " - " + comune + " (" + provincia + ")";
                    infoTipoSoftwareContabilita.Text = "Software di contabilità: " + tipoSoftwareContabilita;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
