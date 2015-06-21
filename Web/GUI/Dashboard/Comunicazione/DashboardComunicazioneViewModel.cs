using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using Library.Template.Dashboard;
using Web.GUI.Contabilita;
using Web.GUI.Comunicazione;

namespace Web.GUI.Dashboard.Comunicazione
{
    public class DashboardComunicazioneViewModel : TemplateViewModel<DashboardDto, DashboardComunicazioneItem>
    {

        public DashboardComunicazioneViewModel()
            : base() 
        {

        }

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();

                var dashboardContabilita = new DashboardDto("Contabilità", "CONT", "Definisci la contabilità per la tua azienda, imposta l'anno contabile e il tipo di scadenza IVA. Il sistema provvederà a generare le comunicazioni necessarie per il tipo di contabilità selezionata...", "Images.dashboard.contabilita.png", "", typeof(ContabilitaView));
                var dashboardComunicazione = new DashboardDto("Comunicazione", "COM", "Controlla ed imposta le comunicazioni legate alla scadenza IVA. A seconda del tipo di contabilità si potranno avere una o più comunicazioni, per le quali impostare le scadenze IVA e le evetuali notifiche...", "Images.dashboard.comunicazione.png", "", typeof(ComunicazioneView));

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