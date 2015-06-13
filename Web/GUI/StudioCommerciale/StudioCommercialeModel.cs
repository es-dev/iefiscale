using Library.Code;
using Library.Controls;
using Library.Template.MVVM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Web.Code;

namespace Web.GUI.StudioCommerciale
{
	public partial class StudioCommercialeModel : TemplateModel
	{
        public StudioCommercialeModel()
		{
			InitializeComponent();
		}

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.StudioCommercialeDto)model;
                    infoSubtitle.Text =  obj.Denominazione;
                    infoSubtitleImage.Image = "Images.dashboard.azienda.png";
                    infoTitle.Text = (obj.Id != 0 ? "AZIENDA " + obj.Denominazione : "NUOVA AZIENDA");
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindView(object model)  
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.StudioCommercialeDto)model;
                    editDenominazione.Value = obj.Denominazione;
                    editCAP.Value = obj.Cap;
                    editComune.Value = new Countries.City(obj.Comune, obj.CodiceCatastale, obj.Provincia);
                    editIndirizzo.Value = obj.Indirizzo;
                    editTipoSoftwareContabilita.Value = obj.TipoSoftwareContabilita;
                    editPartitaIVA.Value = obj.PartitaIVA;
                    editTelefono.Value = obj.Telefono;
                    editFAX.Value = obj.Fax;
                    editEmail.Value = obj.Email;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindModel(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.StudioCommercialeDto)model;
                    obj.Denominazione = editDenominazione.Value;
                    obj.Cap = editCAP.Value;
                    obj.Comune = editComune.Value.Description;
                    obj.CodiceCatastale = editComune.Value.Code;
                    obj.Provincia = editComune.Value.County;
                    obj.TipoSoftwareContabilita = editTipoSoftwareContabilita.Value;
                    obj.Indirizzo = editIndirizzo.Value;
                    obj.PartitaIVA = editPartitaIVA.Value;
                    obj.Telefono = editTelefono.Value;
                    obj.Fax = editFAX.Value;
                    obj.Email = editEmail.Value;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
  
	}
}