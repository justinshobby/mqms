using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MQMS.Models
{
    public class uomclass
    {
        public long UOMID { get; set; }
        public string UOMName { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DateModified { get; set; }

        mqmsEntities db = new mqmsEntities();

        public List<uom> getuoms()
        {

            var uomlist = db.uoms.AsNoTracking()
                          .ToList();

            db.Dispose();

            return uomlist;
           
        }
        public uom saveuom(uom uomobject)
        {
            if (uomobject.UOMID != 0)
            {
                db.uoms.Attach(uomobject);
                db.Entry(uomobject).State = EntityState.Modified;
                db.SaveChanges();
                db.Dispose();

            }
            else
            {
                db.uoms.Add(uomobject);
                db.SaveChanges();
            }

            return uomobject;
        }

    }   
}