using MQMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MQMS.Controllers
{
    public class uomcontroller
    {
        public List<uom> getuoms()
        {
            uomclass uomsrc = new uomclass();
            return uomsrc.getuoms();
        }

        public string saveuom(uom uomobject)
        {
            uomclass uomsrc = new uomclass();
            string result = string.Empty;

            if (uomobject.UOMID != 0)
            {
                //update
                var check = getuoms()
                                .Where(c => c.UOMID != uomobject.UOMID)
                                .Where(c=> c.UOMName == uomobject.UOMName)
                                .Where(c=>c.IsDeleted == false)
                                .FirstOrDefault();

                if (check != null)
                {
                    result = "UOM TAKEN";
                }
                else
                {
                    var obj = uomsrc.saveuom(uomobject);
                    if (obj != null)
                    {
                        result = "Success";
                    }
                }


            }
            else
            {
                var check = getuoms()
                                .Where(c => c.UOMName == uomobject.UOMName)
                                .Where(c => c.IsDeleted == false)
                                .FirstOrDefault();
                if (check != null)
                {
                    result = "UOM TAKEN";
                }
                else
                {
                    var obj = uomsrc.saveuom(uomobject);
                    if (obj != null)
                    {
                        result = "Success";
                    }
                }
            }

            return result;
        }
    }
}