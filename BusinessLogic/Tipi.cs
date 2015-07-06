using Library.Code;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Tipi
    {
        public enum TipoAccount
        {
            None,
            Supervisore,
            Amministratore,
            Operatore
        }

        public enum SoftwareContabilita
        {
            [Description("Sistema Ipsoa Professionisti")]
            Ipsoa
        }

        public enum SoftwareFatturazione
        {
            [Description("Danea Easy Fatturazione")]
            EasyFatt,
            [Description("Visual GM Browse Informatica")]
            GM2000
        }

        public enum TipoContabilita
        {
            [Description("Contabilita IVA con periodicità mensile")]
            IVA1,
            [Description("Contabilità IVA con periodicità trimestrale")]
            IVA3
        }
    }
}
