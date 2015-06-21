using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using Library.Template.Dashboard;
using Web.GUI.AnagraficaAzienda;
using Web.GUI.Cliente;

namespace Web.GUI.Dashboard.Anagrafica
{
    public class DashboardAnagraficaViewModel: TemplateViewModel<DashboardDto, DashboardAnagraficaItem>
    {

        public DashboardAnagraficaViewModel()
            : base() 
        {

        }

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardAnagraficaAzienda = new DashboardDto("Anagrafiche aziende", "AA", "Organizza il tuo archivio aziende, specifica le informazioni anagrafiche e contabili, memorizza in un punto centralizzato tutti i dati necessari ad una gestione facile e strutturata...", "Images.dashboard.anagraficaazienda.png", "", typeof(AnagraficaAziendaView));

                dashboards.Add(dashboardAnagraficaAzienda);

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