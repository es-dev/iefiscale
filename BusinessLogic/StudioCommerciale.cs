using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
   public class StudioCommerciale
    {
       public static string GetIndirizzo(StudioCommercialeDto studioCommerciale)
        {
            try
            {
                if (studioCommerciale != null)
                {
                    var indirizzo = studioCommerciale.Indirizzo + ", " + studioCommerciale.Cap + " " +
                        studioCommerciale.Comune + " (" + studioCommerciale.Provincia + ")";
                    return indirizzo;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

       public static string GetCodifica(StudioCommercialeDto studioCommerciale)
       {
           try
           {
               if (studioCommerciale != null)
               {
                   var codifica = studioCommerciale.Denominazione;
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
