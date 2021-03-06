﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Netmefy.Api.Models
{
    public class clientInfoModel
    {
        public int id { get; set; }
        public string username { get; set; }
        public int mb_contratado { get; set; }
        public int mb_umbral { get; set; }
        public string nombre { get; set; }
        public routerInfoModel router { get; set; }
    }

    public class clientIDModel
    {
        public int sk { get; set; }
        public string id { get; set; }
        public string username { get; set; }
    }

    public class webModel
    {
        public int id { get; set; }
        public string ip { get; set; }
        public string url { get; set; }
        public string nombre { get; set; }
        public int resid_imagen { get; set; }
    }

    public class webBloqModel
    {
        public int cliente_sk { get; set; }
        public int router_sk { get; set; }
        //public int web_sk { get; set; }
        //public List<webABloquearModel> webs { get; set; }
        public string webs { get; set; }
    }
    public class webABloquearModel
    {
        public int web_sk { get; set; }
        public bool web_bloqueado { get; set; }
    }

    public class routerInfoModel
    {
        public int router_sk { get; set; }
        public string modelo { get; set; }
        public string ssid { get; set; }
        public string password { get; set; }
        public List<dispositivoInfoModel> devices { get; set; }
        public List<webModel> webs_bloqueadas { get; set; }
    }


    public class router2Model
    {
        public int cliente_sk { get; set; }
        public int router_sk { get; set; }
        public string router_modelo { get; set; }
        public string router_ssid { get; set; }
        public string router_psw { get; set; }
    }

    public class dispositivoInfoModel
    {
        public int dispositivo_sk { get; set; }
        public string mac { get; set; }
        public string ip { get; set; }
        public string tipo { get; set; }
        public bool bloqueado { get; set; }
        public string foto { get; set; }
        public string apodo { get; set; }

        public static List<dispositivoInfoModel> ConvertTo(List<Data.dispositivo> dispositivos)
        {
            List<dispositivoInfoModel> list = new List<dispositivoInfoModel>();

            foreach (Data.dispositivo d in dispositivos)
            {
                list.Add(new dispositivoInfoModel {
                    dispositivo_sk = d.dispositivo_sk,
                    mac = d.dispositivo_mac,
                    ip = d.dispositivo_ip, 
                    tipo = d.dispositivo_tipo, 
                    bloqueado = d.dispositivo_bloq != 0, 
                    apodo = d.dispositivo_apodo

                });
            }

            return list;
        }
    }
}