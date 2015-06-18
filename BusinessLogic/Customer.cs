using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Customer
    {

        public static string GetCodifica(WcfService.Dto.CustomerDto customer)
        {
            try
            {
                if(customer!=null)
                {
                    var codifica = BusinessLogic.Cliente.GetCodifica(customer.Cliente);
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
