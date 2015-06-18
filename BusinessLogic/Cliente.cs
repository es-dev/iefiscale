using Library.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfService.Dto;

namespace BusinessLogic
{
    public class Cliente
    {
        public static string GetCodifica(ClienteDto cliente)
        {
            try
            {
                if (cliente != null)
                {
                    var anagraficaAzienda = cliente.AnagraficaAzienda; 
                    var codifica = cliente.IDCliente + " - " + anagraficaAzienda.RagioneSociale;
                    return codifica;
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetPartitaIva(ClienteDto cliente)
        {
            try
            {
                if(cliente!=null)
                {
                    var anagraficaAzienda = cliente.AnagraficaAzienda;
                    if(anagraficaAzienda!=null)
                    {
                        var piva = anagraficaAzienda.PartitaIVA;
                        return piva;
                    }
                }
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
            return null;
        }

        public static string GetIndirizzo(ClienteDto cliente)
        {
            try
            {
                if(cliente!=null)
                {
                    var indirizzo = BusinessLogic.AnagraficaAzienda.GetIndirizzo(cliente.AnagraficaAzienda);
                    return indirizzo;
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
