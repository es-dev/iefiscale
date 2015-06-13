using Library.Code;
using Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.GUI.Dashboard;
using Library.Template.Dashboard;
using Web.GUI.StudioCommerciale;
using Web.GUI.AnagraficaAzienda;
using Web.GUI.Azienda;
using Web.GUI.Account;
using Web.GUI.Cliente;
using Web.GUI.Contabilita;
using Web.GUI.Comunicazione;
using Web.GUI.Export;
using Web.GUI.Import;
using Web.GUI.Customer;
using Web.GUI.Documento;

namespace Web.GUI.Dashboard
{
    public class DashboardViewModel: TemplateViewModel<DashboardDto, DashboardItem>
    {

        public DashboardViewModel() : base() 
        {

        }
       
        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardAccount = new DashboardDto("Account", "AC", "...", "Images.dashboard.account.png", "", typeof(AccountView), false);
                var dashboardStudioCommerciale = new DashboardDto("Studio commerciale", "SC", "...", "Images.dashboard.studioCommerciale.png", "", typeof(StudioCommercialeView), false);
                var dashboardAnagraficaAzienda = new DashboardDto("Anagrafica azienda", "AA", "...", "Images.dashboard.anagraficaClienti.png", "", typeof(AnagraficaAziendaView), false);
                var dashboardAzienda = new DashboardDto("Azienda", "A", "...", "Images.dashboard.azienda.png", "", typeof(AziendaView), false);
                var dashboardCliente = new DashboardDto("Cliente", "CL", "...", "Images.dashboard.cliente.png", "", typeof(ClienteView), false);
                var dashboardContabilita = new DashboardDto("Contabilità", "CONT", "...", "Images.dashboard.contabilita.png", "", typeof(ContabilitaView), false);
                var dashboardComunicazione = new DashboardDto("Comunicazione", "COM", "...", "Images.dashboard.comunicazione.png", "", typeof(ComunicazioneView), false);
                var dashboardExport = new DashboardDto("Export", "EX", "...", "Images.dashboard.export.png", "", typeof(ExportView), false);
                var dashboardImport = new DashboardDto("Import", "IM", "...", "Images.dashboard.import.png", "", typeof(ImportView), false);
                var dashboardCustomer = new DashboardDto("Customer", "CU", "...", "Images.dashboard.customer.png", "", typeof(CustomerView), false);
                var dashboardDocumento = new DashboardDto("Documento", "DOC", "...", "Images.dashboard.documento.png", "", typeof(DocumentoView), false);

                dashboards.Add(dashboardAccount);
                dashboards.Add(dashboardStudioCommerciale);
                dashboards.Add(dashboardAnagraficaAzienda);
                dashboards.Add(dashboardAzienda);
                dashboards.Add(dashboardCliente);
                dashboards.Add(dashboardContabilita);
                dashboards.Add(dashboardComunicazione);
                dashboards.Add(dashboardExport);
                dashboards.Add(dashboardImport);
                dashboards.Add(dashboardCustomer);
                dashboards.Add(dashboardDocumento);
                var query = dashboards.AsQueryable();
                return query;
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}