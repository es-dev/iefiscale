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
                    var contabilita = obj.Contabilita;
                    var tipoContabilita = UtilityValidation.GetStringND(contabilita.Tipo);
                    var numero = UtilityValidation.GetStringND(obj.Numero);
                    var scadenzaIVA = UtilityValidation.GetDataND(obj.ScadenzaIVA);

                    infoImage.Image = "Images.dashboard.azienda.png";
                    infoNumero.Text = "Numero comunicazione: " +numero;
                    infoScadenzaIVA.Text = "Scadenza IVA: " + scadenzaIVA;
                    infoContabilita.Text = "Contabilità: " + tipoContabilita;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
