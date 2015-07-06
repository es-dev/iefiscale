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

namespace Web.GUI.AnagraficaAzienda
{
	public partial class AnagraficaAziendaItem : TemplateItem
	{
        public AnagraficaAziendaItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AnagraficaAziendaDto)model;

                    infoImage.Image = "Images.dashboard.anagraficaazienda.png";
                    infoRagioneSociale.Text = obj.RagioneSociale;
                    infoIndirizzo.Text = BusinessLogic.AnagraficaAzienda.GetIndirizzo(obj);
                    infoPartitaIVA.Text = BusinessLogic.AnagraficaAzienda.GetPartitaIva(obj);
                    infoCodice.Text = "AZ";
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
