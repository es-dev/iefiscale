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
                    var obj = (WcfService.Dto.AziendaDto)model;
                    var anagraficaAzienda = obj.AnagraficaAzienda;
                    var ragioneSocialeAzienda = UtilityValidation.GetStringND(anagraficaAzienda.RagioneSociale);
                    var studioCommerciale= obj.StudioCommerciale;
                    var tipoSoftwareFatturazione = UtilityValidation.GetStringND(obj.TipoSoftwareFatturazione);

                    infoImage.Image = "Images.dashboard.azienda.png";
                    infoRagioneSociale.Text = ragioneSocialeAzienda;
                    infoStudioCommerciale.Text = "Studio commerciale: " + studioCommerciale.Denominazione;
                    infoTipoSoftwareFatturazione.Text = "Software di fatturazioen: " + tipoSoftwareFatturazione;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
