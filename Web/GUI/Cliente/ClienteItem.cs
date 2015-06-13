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

namespace Web.GUI.Cliente
{
	public partial class ClienteItem : TemplateItem
	{
        public ClienteItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ClienteDto)model;
                    var anagraficaAzienda = obj.AnagraficaAzienda;
                   
                    infoImage.Image = "Images.dashboard.cliente.png";
                    infoRagioneSociale.Text = anagraficaAzienda.RagioneSociale; //il parent non è mai nullo
                    infoIndirizzoComune.Text = BusinessLogic.AnagraficaAzienda.GetIndirizzo(anagraficaAzienda);
                    infoPartitaIVA.Text = anagraficaAzienda.PartitaIVA;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
	}
}
