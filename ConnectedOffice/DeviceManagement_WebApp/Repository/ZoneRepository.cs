using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Repository                //ZoneRepository links with ZoneController and connects with the Database(CMPG323_P3)
{
    public class ZoneRepository
    {
        protected readonly CMPG323_P3Context _context = new CMPG323_P3Context();

        public List<Zone> Getall()
        {
            return _context.Zone.ToList();
        }
    }
}
