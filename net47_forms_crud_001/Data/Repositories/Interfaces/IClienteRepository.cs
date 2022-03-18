using net47_forms_crud_001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net47_forms_crud_001.Data.Repositories.Interfaces
{
    interface IClienteRepository
    {
        void eliminar(int id);
        bool guardar(ClienteModel c);
        List<ClienteModel> listar();
        ClienteModel obtener(int id);
    }
}
