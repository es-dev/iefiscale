using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Contabilita
    {
        public static string GetCodifica(ContabilitaDto contabilita)
        {
            try
            {
                if(contabilita!=null)
                {
                    var codifica = "ANNO " + contabilita.Anno + " | " + BusinessLogic.Azienda.GetCodifica(contabilita.Azienda);
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }
    }
}
