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

namespace Web.GUI.Import
{
	public partial class ImportItem : TemplateItem
	{
        public ImportItem()
		{
			InitializeComponent();
		}

        public override void BindView(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (ImportDto)model;
                    infoImage.Image = "Images.dashboard.import.png";
                    infoImport.Text = BusinessLogic.Import.GetCodifica(obj);
                    infoData.Text = "Generato il " + UtilityValidation.GetDataND(obj.Data);
                    infoStato.Text = obj.Stato;
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
