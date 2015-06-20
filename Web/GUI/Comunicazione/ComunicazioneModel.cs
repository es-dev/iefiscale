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

namespace Web.GUI.Comunicazione
{
    public partial class ComunicazioneModel : TemplateModel
    {
        public ComunicazioneModel()
        {
            InitializeComponent();
        }

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.ComunicazioneDto)model;
                    infoSubtitle.Text = BusinessLogic.Comunicazione.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.comunicazione.png";
                    infoTitle.Text = (obj.Id != 0 ? "COMUNICAZIONE N." + BusinessLogic.Comunicazione.GetCodifica(obj) : "NUOVA COMUNICAZIONE") + " | " + BusinessLogic.Contabilita.GetCodifica(obj.Contabilita);
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
                    var obj = (WcfService.Dto.ComunicazioneDto)model;
                    editScadenzaIVA.Value = obj.ScadenzaIVA;
                    editNumero.Value = obj.Numero;

                    BindViewContabilita(obj.Contabilita);

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewContabilita(WcfService.Dto.ContabilitaDto contabilita)
        {
            try
            {
                editContabilita.Model = contabilita;
                editContabilita.Value = BusinessLogic.Contabilita.GetCodifica(contabilita);
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
                    var obj = (WcfService.Dto.ComunicazioneDto)model;
                    obj.ScadenzaIVA = editScadenzaIVA.Value;
                    obj.Numero = editNumero.Value;

                    var contabilita = (WcfService.Dto.ContabilitaDto)editContabilita.Model;
                    if (contabilita != null)
                        obj.ContabilitaId = contabilita.Id;

                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editContabilita_ComboClick()
        {
            try
            {
                var view = new Contabilita.ContabilitaView();
                view.Title = "SELEZIONA UNA CONTABILITA'";
                editContabilita.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editContabilita_ComboConfirm(object model)
        {
            try
            {
                var contabilita = (ContabilitaDto)model;
                BindViewContabilita(contabilita);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

    }
}
