using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class DevicesRepository              //DeviceRepository links with DevicesController and connects with the Database(CMPG323_P3)
    {
        protected readonly CMPG323_P3Context _context = new CMPG323_P3Context();

        public List<Device> Getall()
        {
            return _context.Device.ToList();
        }
    }
}
