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
                    infoSubtitle.Text = BusinessLogic.Cliente.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.cliente.png";
                    infoTitle.Text = (obj.Id != 0 ? "CLIENTE " + BusinessLogic.Cliente.GetCodifica(obj) : "NUOVO CLIENTE");
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

        private void BindViewAnagraficaAzienda(AnagraficaAziendaDto anagraficaAzienda)
        {
            try
            {
                editRagioneSociale.Model = anagraficaAzienda;
                editRagioneSociale.Value = anagraficaAzienda.RagioneSociale;
                editCAP.Value = anagraficaAzienda.Cap;
                editCodiceFiscale.Value = anagraficaAzienda.CodiceFiscale;
                editComune.Value = new Countries.City(anagraficaAzienda.Comune, anagraficaAzienda.CodiceCatastale, anagraficaAzienda.Provincia);
                editEmail.Value = anagraficaAzienda.Email;
                editFAX.Value = anagraficaAzienda.Fax;
                editIndirizzo.Value = anagraficaAzienda.Indirizzo;
                editPartitaIVA.Value = anagraficaAzienda.PartitaIVA;
                editTelefono.Value = anagraficaAzienda.Telefono;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewAzienda(AziendaDto azienda)
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
                    var obj = (WcfService.Dto.ClienteDto)model;
                    obj.IDCliente = editIDCliente.Value;
                    obj.IDConto = editIDConto.Value;

                    var azienda = (WcfService.Dto.AziendaDto)editAzienda.Model;
                    if (azienda != null)
                        obj.AziendaId = azienda.Id;

                    var anagraficaAzienda = (WcfService.Dto.AnagraficaAziendaDto)editRagioneSociale.Model;
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
                BindViewAzienda(azienda);
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
                view.Title = "SELEZIONA UN CLIENTE DALL'ANAGRAFICA";
                editRagioneSociale.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }

        }

        private void editAnagraficaAzienda_ComboConfirm(object model)
        {
            var anagraficaAzienda = (AnagraficaAziendaDto)model;
            BindViewAnagraficaAzienda(anagraficaAzienda);
        }
	}
}
