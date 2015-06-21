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
using Web.GUI.Dashboard.Anagrafica;
using Web.GUI.Dashboard.Configurazione;
using Web.GUI.Dashboard.Comunicazione;
using Web.GUI.Dashboard.ImportExport;
using Web.GUI.Dashboard.Documento;
using Web.GUI.Agenda;

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
                var dashboardAgenda = new DashboardDto("Agenda e scadenzario", "AG-SCA", "Organizza il tuo lavoro con una comoda e pratica agenda digitale. Visualizza gli import e gli export effettuati. Pianifica le tue comunicazioni e gestisci i documenti contabili...", "Images.dashboard.agenda.png", "", typeof(SchedulerView), false);
                var dashboardComunicazioni = new DashboardDto("Comunicazioni contabili", "COM", "Gestisci la contabilità aziendale e le comunicazioni delle scadenze IVA, definisci il tipo di azienda e gestisci la documentazione che verrà inviata nelle comunicazioni...", "Images.dashboard.comunicazioni.png", "", typeof(DashboardComunicazioneView), false);
                var dashboardImportExport = new DashboardDto("Import-export", "I-E", "Gestisci i tuoi import e i tuoi export, definisci per ogni comunicazione una o più esportazioni, con un semplice clic potrai allegare alla trasmissione le fatture o i documenti contabili...", "Images.dashboard.importexports.png", "", typeof(DashboardImportExportView), false);
                var dashboardDocumenti = new DashboardDto("Documenti e customers", "DOC", "Visualizza in qualunque momento i documenti contabili importati o esportati. Potrai elencare i customers verso i quali stai eseguendo le comunicazioni IVA delle tue fatture...", "Images.dashboard.documenti.png", "", typeof(DashboardDocumentoView), false);
                //var dashboardReports = new DashboardDto("Reports", "RPT", "Crea un report di import/export economico ed effettua un controllo amministrativo. Potrai tenere sotto controllo le tue comunicazioni, le esportazioni ed eventuali scadenze IVA...", "Images.dashboard.reportjob.png", "", typeof(ReportJobView));
                var dashboardConfigurazione = new DashboardDto("Configurazioni", "CONF", "Definisci le aziende che vuoi gestire nel sistema Enterprise Manager e configura i parametri principali come i Centri di Costo, le Impostazioni Generali...", "Images.dashboard.configurazioni.png", "", typeof(DashboardConfigurazioneView), false);
                var dashboardAnagrafiche = new DashboardDto("Anagrafiche", "ANAG", "Inserisci le anagrafiche dei clienti, dei fornitori e delle aziende gestite. Con un archivio strutturato potrai gestire i tuoi dati ed accedere facilmente alle informazioni di tuo interesse...", "Images.dashboard.anagrafiche.png", "", typeof(DashboardAnagraficaView), false);
                //var dashboardTools = new DashboardDto("Strumenti amministrativi", "TOOLS", "Controlla lo stato del tuo applicativo mediante una serie di strumenti per la verifica degli archivi, delle configurazioni e dell'integrità dei dati...", "Images.dashboard.tools.png", "", typeof(ToolsModel), false);

                dashboards.Add(dashboardAgenda);
                dashboards.Add(dashboardComunicazioni);
                dashboards.Add(dashboardImportExport);
                dashboards.Add(dashboardDocumenti);
                //dashboards.Add(dashboardReports);
                dashboards.Add(dashboardConfigurazione);
                dashboards.Add(dashboardAnagrafiche);
                //dashboards.Add(dashboardTools);

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