using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Comunicazione
    {
        public static string GetCodifica(ComunicazioneDto comunicazione)
        {
            try
            {
                if(comunicazione!=null)
                {
                    var data = UtilityValidation.GetData(comunicazione.ScadenzaIVA);
                    var codifica = comunicazione.Numero + " DEL " + data.ToString("dd/MM/yyyy");
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
