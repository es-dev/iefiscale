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

namespace Web.GUI.Documento
{
	public partial class DocumentoItem : TemplateItem
	{
        public DocumentoItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.DocumentoDto)model;
                    infoImage.Image = "Images.dashboard.documento.png";
                    infoDocumento.Text = BusinessLogic.Documento.GetCodifica(obj);
                    infoCliente.Text = BusinessLogic.Cliente.GetCodifica(obj.Cliente);
                    infoPartitaIva.Text = BusinessLogic.Cliente.GetPartitaIva(obj.Cliente);
                    infoExport.Text = BusinessLogic.Export.GetCodifica(obj.Export);
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       
	}
}
