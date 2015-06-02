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

namespace Web.GUI.Cliente
{
	public partial class ClienteModel : TemplateModel
	{
        public ClienteModel()
		{
			InitializeComponent();
		}

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ClienteDto)model;
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
                    var obj = (WcfService.Dto.ClienteDto)model;
                    editIDCliente.Value = obj.IDCliente;
                    editIDConto.Value = obj.IDConto;

                    BindViewAzienda(obj.Azienda);
                    BindViewAnagraficaAzienda(obj.AnagraficaAzienda);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAnagraficaAzienda(AnagraficaAziendaDto anagraficaAziendaDto)
        {
            try
            {
                editAnagraficaAzienda.Model = anagraficaAziendaDto;
                if (anagraficaAziendaDto != null)
                {
                    var ragioneSociale = anagraficaAziendaDto.RagioneSociale;
                    editAnagraficaAzienda.Value = ragioneSociale;
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
                if(aziendaDto!=null)
                {
                    var anagraficaAzienda = aziendaDto.AnagraficaAzienda;
                    if (anagraficaAzienda != null)
                    {
                        var ragioneSociale = anagraficaAzienda.RagioneSociale;
                        editAnagraficaAzienda.Value = ragioneSociale;
                    }
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
                    var obj = (WcfService.Dto.ClienteDto)model;
                    obj.IDCliente = editIDCliente.Value;
                    obj.IDConto = editIDConto.Value;

                    var azienda = (WcfService.Dto.AziendaDto)editAzienda.Model;
                    if (azienda != null)
                        obj.AziendaId = azienda.Id;

                    var anagraficaAzienda = (WcfService.Dto.AnagraficaAziendaDto)editAnagraficaAzienda.Model;
                    if (anagraficaAzienda != null)
                        obj.AnagraficaAziendaId = anagraficaAzienda.Id;
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

        private void editAnagraficaAzienda_ComboClick()
        {
            try
            {
                var view = new AnagraficaAzienda.AnagraficaAziendaView();
                view.Title = "SELEZIONA UN'AZIENDA DALL'ANAGRAFICA";
                editAnagraficaAzienda.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void editAnagraficaAzienda_ComboConfirm(object model)
        {
            var anagraficaAzienda = (AnagraficaAziendaDto)model;
            if (anagraficaAzienda != null)
                editAnagraficaAzienda.Value = anagraficaAzienda.RagioneSociale;
        }
	}
}
