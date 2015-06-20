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
                    infoImage.Image = "Images.dashboard.studiocommerciale.png";
                    infoDenominazione.Text = obj.Denominazione;
                    infoIndirizzo.Text = BusinessLogic.StudioCommerciale.GetIndirizzo(obj);
                    infoTipoSoftwareContabilita.Text = "Software di contabilità: " + obj.TipoSoftwareContabilita;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
      
	}
}
