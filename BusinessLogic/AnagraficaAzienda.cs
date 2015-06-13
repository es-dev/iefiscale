using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class AnagraficaAzienda
    {
        public static string GetIndirizzo(AnagraficaAziendaDto anagraficaAzienda)
        {
            try
            {
                if(anagraficaAzienda!=null)
                {
                    var indirizzo = anagraficaAzienda.Indirizzo + ", " + anagraficaAzienda.Cap + " " +
                        anagraficaAzienda.Comune + " (" + anagraficaAzienda.Provincia + ")";
                    return indirizzo;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetCodifica(AnagraficaAziendaDto anagraficaAzienda)
        {
            try
            {
                if(anagraficaAzienda!=null)
                {
                    var codifica = anagraficaAzienda.Id.ToString("000") + " - " + anagraficaAzienda.RagioneSociale; //codice - denominazione
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
