using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Documento
    {
        public static string GetCodifica(DocumentoDto documento)
        {
            try
            {
                if(documento!=null)
                {
                    var data = UtilityValidation.GetData(documento.Data);
                    var codifica = documento.Numero + " DEL " + data.ToString("dd/MM/yyyy");
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
