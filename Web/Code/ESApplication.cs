using Library.Code;
using Library.Template.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Code
{
    public class ESApplication
    {
        internal static void Init(TemplateBase view)
        {
            try
            {
                view.Title = "ES | IMPORT EXPORT FISCALE";
                view.Version = "rev. beta 1";
                view.LogoSoftware = "Images.es.iefiscale.png";
                view.LogoESD = "Images.logoESD.png";
                view.BackgroundImage = "Images.background.png";
                view.UrlHomePortal = "http://www.aifirst.it";
            }
            catch (Exception ex)
            {
                UtilityError.Write(ex);
            }
        }
    }
}