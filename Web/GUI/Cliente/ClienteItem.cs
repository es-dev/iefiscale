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
                    var ragioneSocialeAzienda = UtilityValidation.GetStringND(anagraficaAzienda.RagioneSociale);
                    var idCliente = UtilityValidation.GetStringND(obj.IDCliente);

                    infoImage.Image = "Images.dashboard.cliente.png";
                    infoRagioneSociale.Text = ragioneSocialeAzienda;
                    infoIdCliente.Text = "Id cliente:" + idCliente;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
