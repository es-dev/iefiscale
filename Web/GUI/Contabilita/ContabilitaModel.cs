using Library.Code;
using Library.Controls;
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
	public partial class ContabilitaModel : TemplateModel
	{
        public ContabilitaModel()
		{
			InitializeComponent();
		}

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ContabilitaDto)model;
                    infoSubtitle.Text = BusinessLogic.Azienda.GetCodifica(obj.Azienda);
                    infoSubtitleImage.Image = "Images.dashboard.contabilita.png";
                    infoTitle.Text = (obj.Id != 0 ? "CONTABILITA' ANNO " + obj.Anno : "NUOVA CONTABILITA'") + " | " + BusinessLogic.Azienda.GetCodifica(obj.Azienda);
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
                    var obj = (WcfService.Dto.ContabilitaDto)model;
                    editAnno.Value = obj.Anno;
                    editTipo.Value = obj.Tipo;

                    BindViewAzienda(obj.Azienda);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAzienda(WcfService.Dto.AziendaDto azienda)
        {
            try
            {
                editAzienda.Model = azienda;
                editAzienda.Value = BusinessLogic.Azienda.GetCodifica(azienda);  
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
                    var obj = (WcfService.Dto.ContabilitaDto)model;
                    obj.Anno = editAnno.Value;
                    obj.Tipo = editTipo.Value;

                    var azienda = (WcfService.Dto.AziendaDto)editAzienda.Model;
                    if (azienda != null)
                        obj.AziendaId = azienda.Id;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editAzienda_ComboClick()
        {
            try
            {
                var view = new Azienda.AziendaView();
                view.Title = "SELEZIONA UN'AZIENDA";
                editAzienda.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editAzienda_ComboConfirm(object model)
        {
            try
            {
                var azienda = (AziendaDto)model;
                BindViewAzienda(azienda);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       	}
}
