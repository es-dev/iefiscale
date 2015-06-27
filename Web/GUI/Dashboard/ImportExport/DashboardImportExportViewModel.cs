using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using Library.Template.Dashboard;
using Web.GUI.Export;
using Web.GUI.Import;

namespace Web.GUI.Dashboard.ImportExport
{
    public class DashboardImportExportViewModel : TemplateViewModel<DashboardDto, DashboardImportExportItem>
    {

        public DashboardImportExportViewModel()
            : base() 
        {

        }

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardImport = new DashboardDto("Import", "IMP", "Effettua il download dei files contenenti i documenti contabili dell'azienda. Importa i dati nel tuo software di contabilità e verifica l'integrità dei dati e gli importi...", "Images.dashboard.import.png", "", typeof(ImportView));
                var dashboardExport = new DashboardDto("Export", "EXP", "Effettua l'upload dei tuoi documenti contabili e preparali per la trasmissione telematica. Il sistema si occuperà di tutte le fasi necessarie alle operazioni di export dei dati...", "Images.dashboard.export.png", "", typeof(ExportView));

                dashboards.Add(dashboardImport);
                dashboards.Add(dashboardExport);

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