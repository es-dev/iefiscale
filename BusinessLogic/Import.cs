using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Import
    {
        public static string GetCodifica(ImportDto import)
        {
            try
            {
                if(import!=null)
                {
                    var codifica = BusinessLogic.Export.GetCodifica(import.Export);
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
