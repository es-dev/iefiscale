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

namespace Web.GUI.Contabilita
{
	public partial class ContabilitaItem : TemplateItem
	{
        public ContabilitaItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ContabilitaDto)model;
                    //var indirizzo = UtilityValidation.GetStringND(obj.Indirizzo);
                    //var cap = UtilityValidation.GetStringND(obj.Cap);
                    //var comune = UtilityValidation.GetStringND(obj.Comune);
                    //var provincia = UtilityValidation.GetStringND(obj.Provincia);
                    //var denominazione = UtilityValidation.GetStringND(obj.RagioneSociale);

                    //infoImage.Image = "Images.dashboard.azienda.png";
                    //infoDenominazione.Text = denominazione;
                    //infoIndirizzo.Text = indirizzo + " - " + cap + " - " + comune + " (" + provincia + ")";
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
