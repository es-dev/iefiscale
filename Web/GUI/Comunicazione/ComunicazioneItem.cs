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

namespace Web.GUI.Comunicazione
{
	public partial class ComunicazioneItem : TemplateItem
	{
        public ComunicazioneItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ComunicazioneDto)model;

                    infoImage.Image = "Images.dashboard.comunicazione.png";
                    infoNumero.Text = "COMUNICAZIONE N." + BusinessLogic.Comunicazione.GetCodifica(obj);
                    infoScadenzaIVA.Text = "Scadenza IVA: " + obj.ScadenzaIVA;
                    infoContabilita.Text = "Contabilità: " + BusinessLogic.Contabilita.GetCodifica(obj.Contabilita);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
