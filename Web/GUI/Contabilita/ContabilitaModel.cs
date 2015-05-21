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
                    infoSubtitle.Text =  "";
                    infoSubtitleImage.Image = "Images.dashboard.cliente.png";
                    infoTitle.Text = ""; //(obj.Id != 0 ? "AZIENDA " + obj.RagioneSociale : "NUOVA AZIENDA");
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

                private void BindViewAzienda(WcfService.Dto.AziendaDto aziendaDto)
        {
            try
            {
                editAzienda.Model = aziendaDto;
                editAzienda.Value = (aziendaDto != null ? aziendaDto.AnagraficaAzienda.RagioneSociale : null);  //todo: da sistemare
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
                if (azienda != null)
                    editAzienda.Value = azienda.AnagraficaAzienda.RagioneSociale;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

       	}
}
