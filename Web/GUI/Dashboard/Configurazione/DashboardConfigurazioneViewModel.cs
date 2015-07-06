using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using Web.GUI.Account;
using Library.Template.Dashboard;
using Web.GUI.StudioCommerciale;
using Web.GUI.Azienda;
using Web.GUI.Cliente;

namespace Web.GUI.Dashboard.Configurazione
{
    public class DashboardConfigurazioneViewModel : TemplateViewModel<DashboardDto, DashboardConfigurazioneItem>
    {
        
        public DashboardConfigurazioneViewModel() : base() 
        {

        }

       

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardStudioCommerciale = new DashboardDto("Studi commerciali", "SC", "Definisci il tuo studio commerciale, inserisci il logo dello studio, l'intestazione e seleziona il tipo di software utilizzato per la contabilità...", "Images.dashboard.studiocommerciale.png", "", typeof(StudioCommercialeView));
                var dashboardAzienda = new DashboardDto("Aziende", "AZ", "Definisci le aziende per le quali vuoi tenere la contabilità, imposta i dati anagrafici e commerciali, seleziona il tipo di software di fatturazione utilizzato...", "Images.dashboard.azienda.png", "", typeof(AziendaView));
                var dashboardCliente = new DashboardDto("Clienti", "CL", "Visualizza e controlla i clienti associati alle varie aziende, puoi gestire i tuoi archivi per un utilizzo del software semplice e rapido...", "Images.dashboard.cliente.png", "", typeof(ClienteView));
                var dashboardAccount = new DashboardDto("Accounts", "ACC", "Definisci gli accounts specificando le credenziali di accesso ed il ruolo associato ai vari operatori che avranno accesso al sistema...", "Images.dashboard.account.png", "", typeof(AccountView));

                dashboards.Add(dashboardStudioCommerciale);
                dashboards.Add(dashboardAzienda);
                dashboards.Add(dashboardCliente);
                dashboards.Add(dashboardAccount);

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