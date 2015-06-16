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
                    var obj = (ContabilitaDto)model;

                    infoImage.Image = "Images.dashboard.contabilita.png";
                    infoContabilitaAnno.Text = "CONTABILITA' ANNO: " + obj.Anno;
                    infoTipoContabilita.Text = "Tipo contabilità: " + obj.Tipo;
                    infoAzienda.Text = "Azienda: " + BusinessLogic.Azienda.GetCodifica(obj.Azienda);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
