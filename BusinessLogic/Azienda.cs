using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Azienda
    {
        public static string GetCodifica(WcfService.Dto.AziendaDto azienda)
        {
            try
            {
                if(azienda !=null)
                {
                    var anagraficaAzienda = azienda.AnagraficaAzienda; //non è mai nullo
                    var codifica = azienda.IDAzienda + " - " + anagraficaAzienda.RagioneSociale;
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
