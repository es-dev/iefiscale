using BusinessLogic;
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

namespace Web.GUI.Azienda
{
	public partial class AziendaModel : TemplateModel
	{
        public AziendaModel()
		{
			InitializeComponent();
            try
            {
                InitCombo();
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
		}

        private void InitCombo()
        {
            try
            {
                editTipoSoftwareFatturazione.DisplayValues = Library.Code.UtilityEnum.GetDisplayValues<Tipi.SoftwareFatturazione>();
                editTipoContabilita.DisplayValues = Library.Code.UtilityEnum.GetDisplayValues<Tipi.TipoContabilita>();

            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        public override void BindViewTitle(object model)
        {
            try
            {
                if (model != null)
                {
                    var obj = (WcfService.Dto.AziendaDto)model;
                    infoSubtitle.Text = BusinessLogic.Azienda.GetCodifica(obj);
                    infoSubtitleImage.Image = "Images.dashboard.azienda.png";
                    infoTitle.Text = (obj.Id != 0 ? "AZIENDA " + BusinessLogic.Azienda.GetCodifica(obj): "NUOVA AZIENDA");
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
                    var obj = (WcfService.Dto.AziendaDto)model;
                    editTipoContabilita.Value = obj.TipoContabilita;
                    editTipoSoftwareFatturazione.Value = obj.TipoSoftwareFatturazione;
                    editUltimoAggiornamento.Value = obj.UltimoAggiornamento;
                    editMdbFile.Value = obj.MdbFile;
                    editIDAzienda.Value = obj.IDAzienda;

                    BindViewStudioCommerciale(obj.StudioCommerciale);
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
                editRagioneSociale.Value = BusinessLogic.AnagraficaAzienda.GetCodifica(anagraficaAzienda);
                editCAP.Value = anagraficaAzienda.Cap;
                editComune.Value = new Countries.City(anagraficaAzienda.Comune, anagraficaAzienda.CodiceCatastale, anagraficaAzienda.Provincia);
                editIndirizzo.Value = anagraficaAzienda.Indirizzo;
                editCodiceFiscale.Value = anagraficaAzienda.CodiceFiscale;
                editPartitaIVA.Value = anagraficaAzienda.PartitaIVA;
                editTelefono.Value = anagraficaAzienda.Telefono;
                editFAX.Value = anagraficaAzienda.Fax;
                editEmail.Value = anagraficaAzienda.Email;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void BindViewStudioCommerciale(WcfService.Dto.StudioCommercialeDto studioCommerciale)
        {
            try
            {
                editStudioCommerciale.Model = studioCommerciale;
                editStudioCommerciale.Value = BusinessLogic.StudioCommerciale.GetCodifica(studioCommerciale);
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
                    var obj = (WcfService.Dto.AziendaDto)model;
                    obj.TipoContabilita = editTipoContabilita.Value;
                    obj.UltimoAggiornamento = editUltimoAggiornamento.Value;
                    obj.MdbFile = editMdbFile.Value;
                    obj.TipoSoftwareFatturazione = editTipoSoftwareFatturazione.Value;
                    obj.IDAzienda = editIDAzienda.Value;

                    var studioCommerciale = (WcfService.Dto.StudioCommercialeDto)editStudioCommerciale.Model;
                    if (studioCommerciale != null)
                        obj.StudioCommercialeId = studioCommerciale.Id;

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

        private void editStudioCommerciale_ComboClick()
        {
            try
            {
                var view = new StudioCommerciale.StudioCommercialeView();
                view.Title = "SELEZIONA UNO STUDIO COMMERCIALE";
                editStudioCommerciale.Show(view);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private void editStudioCommerciale_ComboConfirm(object model)
        {
            try
            {
                var studioCommerciale = (StudioCommercialeDto)model;
                BindViewStudioCommerciale(studioCommerciale);
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

        private void btnImportConfigurazione_Click(object sender, EventArgs e)
        {
            try
            {
                var utilityCountries = new UtilityCountries();
                var obj = (AziendaDto)Model;
                var studioCommerciale = (StudioCommercialeDto)editStudioCommerciale.Model;
                var fileName = editMdbFile.Value;
                if (obj != null && studioCommerciale != null && fileName != null && fileName.Length > 0)
                {
                    var viewModelAnagraficaAzienda = new AnagraficaAzienda.AnagraficaAziendaViewModel();
                    var pathRepository = UtilityWeb.GetRootPath(Context) + editMdbFile.Repository;
                    var pathFileName = pathRepository + @"\" + fileName;
                    var viewModel = (AziendaViewModel)ViewModel;
                    var nominativi = viewModel.ReadNominativi(pathFileName);
                    if (nominativi != null)
                    {
                        foreach (var nominativo in nominativi)
                        {
                            var partitaIva = nominativo.Partita_IVA;
                            var ragioneSociale = nominativo.Descrizione_1;
                            var provincia = nominativo.ID_Provincia;
                            var comune = nominativo.Citta;
                            var codiceCatastale = utilityCountries.GetCode(comune, provincia);
                            var indirizzo = nominativo.Indirizzo;
                            var cap = nominativo.Cap;
                            var codiceFiscale = nominativo.Codice_Fiscale;
                            var email = nominativo.EMail;
                            var fax = GetFax(nominativo);
                            var telefono = GetTelefono(nominativo);

                            var anagraficaAzienda = viewModelAnagraficaAzienda.Read(partitaIva);
                            if (anagraficaAzienda == null)
                                anagraficaAzienda = new AnagraficaAziendaDto();

                            anagraficaAzienda.RagioneSociale = ragioneSociale;
                            anagraficaAzienda.PartitaIVA = partitaIva;
                            anagraficaAzienda.CodiceCatastale = codiceCatastale;
                            anagraficaAzienda.Comune = comune;
                            anagraficaAzienda.Provincia = provincia;
                            anagraficaAzienda.Indirizzo = indirizzo;
                            anagraficaAzienda.Cap = cap;
                            anagraficaAzienda.CodiceFiscale = codiceFiscale;
                            anagraficaAzienda.Email = email;
                            anagraficaAzienda.Fax = fax;
                            anagraficaAzienda.Telefono = telefono;
                            anagraficaAzienda.StudioCommercialeId = studioCommerciale.Id;

                            viewModel.ImportAnagraficaAzienda(anagraficaAzienda);
                        }
                    }
                    //var clienti = viewModel.ReadClienti(pathFileName);
                    //if (clienti != null)
                    //{
                    //    foreach (var cliente in clienti)
                    //        viewModel.ImportCliente(cliente, obj);
                    //}
                    editUltimoAggiornamento.Value = DateTime.Now;
                    UtilityMessage.Show(this, "INFORMAZIONE", "I nominativi e i clienti del file di configurazione aziendale sono stati importati correttamente nell'archivio centrale. E' possibile procedere con le operazioni di import/export ed effettuare le comunicazioni dei dati di fatturazione...", TypeMessage.Info);
                }
                else
                    UtilityMessage.Show(this, "ATTENZIONE", "Prima di procedere con l'import dei dati nell'archivio centrale, assicurarsi di aver impostato lo studio commerciale, l'azienda corrente e il file di configurazione...", TypeMessage.Alert);
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }

        private string GetFax(DataLayer.DataSetIpsoa.NominativiRow nominativo)
        {
            try
            {
                if (!nominativo.IsFax_1Null())
                    return nominativo.Fax_1;
                else if (!nominativo.IsFax_2Null())
                    return nominativo.Fax_2;
                else if (!nominativo.IsFax_3Null())
                    return nominativo.Fax_3;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        private string GetTelefono(DataLayer.DataSetIpsoa.NominativiRow nominativo)
        {
            try
            {
                if (!nominativo.IsTelefono1_1Null())
                    return nominativo.Telefono1_1;
                else if (!nominativo.IsTelefono1_2Null())
                    return nominativo.Telefono1_2;
                else if (!nominativo.IsTelefono1_3Null())
                    return nominativo.Telefono1_3;
                else if (!nominativo.IsTelefono2_1Null())
                    return nominativo.Telefono2_1;
                else if (!nominativo.IsTelefono2_2Null())
                    return nominativo.Telefono2_2;
                else if (!nominativo.IsTelefono2_3Null())
                    return nominativo.Telefono2_3;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
	}
}
