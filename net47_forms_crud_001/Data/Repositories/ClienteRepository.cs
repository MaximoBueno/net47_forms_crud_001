using net47_forms_crud_001.Data.Entities;
using net47_forms_crud_001.Data.Repositories.Interfaces;
using net47_forms_crud_001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace net47_forms_crud_001.Data.Repositories
{
    class ClienteRepository : IClienteRepository
    {
        private bd_estacionamientosEntities1 miDb;

        public ClienteRepository()
        {
            miDb = new bd_estacionamientosEntities1();
        }

        public void eliminar(int id)
        {
            clientes clie = (from cli in miDb.clientes
                             where cli.id == id
                             select cli).FirstOrDefault();

            if (clie != null)
            {
                miDb.clientes.Remove(clie);
                miDb.SaveChanges();
            }
        }

        public bool guardar(ClienteModel c)
        {
            try
            {
                if (c.id.ToString() == "" || c.id == 0)
                {
                    clientes clie = new clientes();
                    clie.nombres = c.nombres;
                    clie.ap_paterno = c.ap_paterno;
                    clie.ap_materno = c.ap_materno;
                    clie.correo = c.correo;
                    clie.nro_documento = c.nro_documento;
                    clie.nro_contacto = c.nro_contacto;

                    miDb.clientes.Add(clie);
                    miDb.SaveChanges();
                    return true;
                }
                else
                {
                    clientes clie = (from cli in miDb.clientes
                                     where cli.id == c.id
                                     select cli).FirstOrDefault();

                    clie.nombres = c.nombres;
                    clie.ap_paterno = c.ap_paterno;
                    clie.ap_materno = c.ap_materno;
                    clie.nro_documento = c.nro_documento;

                    clie.correo = c.correo;
                    clie.nro_contacto = c.nro_contacto;

                    miDb.SaveChanges();

                    return true;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public List<ClienteModel> listar()
        {

            try
            {
                var cli = (from clie in miDb.clientes
                           select new ClienteModel
                           {
                               id = clie.id,
                               nombres = clie.nombres,
                               ap_paterno = clie.ap_paterno,
                               ap_materno = clie.ap_materno,
                               nro_documento = clie.nro_documento,
                               correo = clie.correo,
                               nro_contacto = clie.nro_contacto,
                           }).ToList();

                return cli;

            }catch(Exception ex){

                return null;
            }
        }

        public ClienteModel obtener(int id)
        {
            clientes micliente = (from cli in miDb.clientes
                                  where cli.id == id
                                  select cli).FirstOrDefault();
            ClienteModel cliente = new ClienteModel();

            if (micliente != null)
            {
                cliente.id = micliente.id;
                cliente.nombres = micliente.nombres;
                cliente.ap_paterno = micliente.ap_paterno;
                cliente.ap_materno = micliente.ap_materno;
                cliente.nro_documento = micliente.nro_documento;
                cliente.correo = micliente.correo;
                cliente.nro_contacto = micliente.nro_contacto;
            }

            return cliente;
        }
    }
}
