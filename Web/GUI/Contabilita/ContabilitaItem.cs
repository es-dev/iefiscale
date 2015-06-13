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
                    var azienda = obj.Azienda;
                    var aziendaRagioneSociale = UtilityValidation.GetStringND(azienda.AnagraficaAzienda.RagioneSociale);
                    var tipoContabilita = UtilityValidation.GetStringND(obj.Tipo);
                    var contabilitaAnno = UtilityValidation.GetStringND(obj.Anno);

                    infoImage.Image = "Images.dashboard.contabilita.png";
                    infoContabilitaAnno.Text ="CONTABILITA' ANNO: " + contabilitaAnno;
                    infoTipoContabilita.Text = "Tipo contabilità: "+ tipoContabilita;
                    infoAzienda.Text = aziendaRagioneSociale;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
