using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net47_forms_crud_001.Models
{
    class ClienteModel
    {
        public int id { get; set; }
        public string nombres { get; set; }
        public string ap_paterno { get; set; }
        public string ap_materno { get; set; }
        public string nro_documento { get; set; }
        public string correo { get; set; }
        public string nro_contacto { get; set; }
    }
}
