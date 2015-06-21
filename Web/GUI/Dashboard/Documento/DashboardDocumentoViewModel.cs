using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using Library.Template.Dashboard;
using Web.GUI.Documento;
using Web.GUI.Customer;

namespace Web.GUI.Dashboard.Documento
{
    public class DashboardDocumentoViewModel : TemplateViewModel<DashboardDto, DashboardDocumentoItem>
    {

        public DashboardDocumentoViewModel()
            : base() 
        {

        }

        public override IQueryable<DashboardDto> QueryDashboards()
        {
            try
            {
                var dashboards = new List<DashboardDto>();
                var dashboardDocumento = new DashboardDto("Documenti contabili", "DOC", "Controlla i documenti contabili di acquisto verso i fornitori e di vandita verso i customers, visualizza gli importi e i dati contabili da trasmettere...", "Images.dashboard.documento.png", "", typeof(DocumentoView));
                var dashboardCustomer = new DashboardDto("Customers", "CU", "Verifica i customer per le fatture di vendita, verifica i dati contabili e l'ID del conto economico associato...", "Images.dashboard.customer.png", "", typeof(CustomerView));

                dashboards.Add(dashboardDocumento);
                dashboards.Add(dashboardCustomer);

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