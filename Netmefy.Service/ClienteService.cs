﻿using Netmefy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netmefy.Service
{
    public class ClienteService
    {
        private NETMEFYEntities db = new NETMEFYEntities();

        public Data.cliente buscar(string username)
        {
            //Data.cliente client_found = null;
            LoginService ls = new LoginService();
            var dataLogin = ls.findByUsername(username);
            

            var client_found = db.clientes.Find(dataLogin.SK);

            return client_found;
        }

        public Data.cliente buscarById(int id)
        {
            return db.clientes.Find(id);
        }

        public Data.router getRouterFromClient(int client_sk)
        {
            var router_found = db.routers.Where(x => x.cliente_sk == client_sk && x.router_activo == 1).FirstOrDefault();

            return router_found;
        }

        public List<dispositivo> getDevices(int cliente_sk, int router_sk)
        {
            var devices = db.dispositivos.Where(x => x.cliente_sk == cliente_sk && x.router_sk == router_sk).ToList();

            return devices;
        }


        public int guardarSiEsQueNoExiste(Data.usuario usuario)
        {
            if (!existUser(usuario))
            {

                //int? newUsuario_sk = db.usuarios.Where(x => x.cliente_sk == usuario.cliente_sk).Max(d => d.usuario_sk);

                //if (newUsuario_sk == null)
                //    usuario.usuario_sk = 1;
                //else
                //    usuario.usuario_sk = ((int)newUsuario_sk)+1;

                db.usuarios.Add(usuario);
                db.SaveChanges();

                //pagina p = new pagina();
                //p.entidad_desc = "facebook.com";
                //usuario.paginas.Add(p);
                //db.SaveChanges();

                return usuario.usuario_sk;
            }
            else
            {
                Data.usuario user_found = findUserByEmailAndClient(usuario.usuario_email, usuario.cliente_sk);
                return user_found.usuario_sk;
            }
        }

        public bool existUser(string email)
        {
            return findUserByEmail(email) != null;
        }

        public bool existUser(Data.usuario user)
        {
            return findUserByEmailAndClient(user.usuario_email, user.cliente_sk) != null;
        }




        public Data.usuario findUserByEmail(string email)
        {
            var user_found = db.usuarios.Where(x => x.usuario_email.ToLower().Equals(email.ToLower())).FirstOrDefault();
            return user_found;
        }
        public Data.usuario findUserByEmailAndClient(string email, int cliente_sk)
        {
            var user_found = db.usuarios.Where(x => x.usuario_email.ToLower().Equals(email.ToLower()) && x.cliente_sk == cliente_sk).FirstOrDefault();
            return user_found;
        }

        public Data.usuario findUserById(int usuario_sk)
        {
            return db.usuarios.Where(x => x.usuario_sk == usuario_sk).FirstOrDefault();
        }

        public List<Data.usuario> findUsersByClient(int client_sk)
        {
            return db.usuarios.Where(x => x.cliente_sk == client_sk).ToList();
        }
    }
}