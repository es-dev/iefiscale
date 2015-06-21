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
                var dashboardImport = new DashboardDto("Import", "IMP", "Effettua il download dei files telematici contenenti i documenti contabili dell'azienda gestita dallo studio. Importa i dati nel software di contabilità e verificane i contenuti per l'integrità dei dati...", "Images.dashboard.import.png", "", typeof(ImportView));
                var dashboardExport = new DashboardDto("Export", "EXP", "Crea un export dei tuoi documenti contabili e preparali per la trasmissione telematica allo studio commerciale. Il sistema provvederà in automatico a generare tutto quanto necessario per le operazioni di import/export dati...", "Images.dashboard.export.png", "", typeof(ExportView));

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