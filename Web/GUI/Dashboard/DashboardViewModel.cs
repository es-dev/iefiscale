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
                var dashboardStudioCommerciale = new DashboardDto("Studio commerciale", "SC", "...", "Images.dashboard.agenda.png", "", typeof(StudioCommercialeView), false);
                var dashboardAnagraficaAzienda = new DashboardDto("Anagrafica azienda", "AA", "...", "Images.dashboard.agenda.png", "", typeof(AnagraficaAziendaView), false);
                var dashboardAzienda = new DashboardDto("Azienda", "A", "...", "Images.dashboard.agenda.png", "", typeof(AziendaView), false);
                var dashboardCliente = new DashboardDto("Cliente", "CL", "...", "Images.dashboard.cliente.png", "", typeof(ClienteView), false);
                var dashboardContabilita = new DashboardDto("Contabilità", "CONT", "...", "Images.dashboard.agenda.png", "", typeof(ContabilitaView), false);
                var dashboardComunicazione = new DashboardDto("Comunicazione", "COM", "...", "Images.dashboard.agenda.png", "", typeof(ComunicazioneView), false);

                dashboards.Add(dashboardAccount);
                dashboards.Add(dashboardStudioCommerciale);
                dashboards.Add(dashboardAnagraficaAzienda);
                dashboards.Add(dashboardAzienda);
                dashboards.Add(dashboardCliente);
                dashboards.Add(dashboardContabilita);
                dashboards.Add(dashboardComunicazione);
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