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

namespace Web.GUI.Azienda
{
	public partial class AziendaItem : TemplateItem
	{
        public AziendaItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (AziendaDto)model;
                    var anagraficaAzienda = obj.AnagraficaAzienda;
                    if (anagraficaAzienda != null)
                        infoRagioneSociale.Text = anagraficaAzienda.RagioneSociale;

                    infoImage.Image = "Images.dashboard.azienda.png";
                    infoTipoSoftwareFatturazione.Text = "Software di fatturazione: " + obj.TipoSoftwareFatturazione;
                    infoIndirizzo.Text = BusinessLogic.AnagraficaAzienda.GetIndirizzo(obj.AnagraficaAzienda);
                    infoPartitaIVA.Text = BusinessLogic.AnagraficaAzienda.GetPartitaIva(obj.AnagraficaAzienda);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
