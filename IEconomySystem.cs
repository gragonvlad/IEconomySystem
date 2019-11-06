using System.Collections.Generic;
using System;
using System.Reflection;
using System.Data;
using UnityEngine;
using Oxide.Core;
using RustProto;

namespace Oxide.Plugins
{
    [Info("EconomySytem", "Daniel25A", "1.0.0", ResourceId = 006)]
    class IEconomySystem : RustLegacyPlugin
    {
        //Colors
        static string Blue = "[color #0099FF]",
                Red = "[color #FF0000]",
                Pink = "[color #CC66FF]",
                Teal = "[color #00FFFF]",
                Green = "[color #009900]",
                Purple = "[color #6600CC]",
                White = "[color #FFFFFF]",
                Yellow = "[color #FFFF00]";
        static int ContadorDeAnuncios = 0;
        static String SystemName = "[IEconomySystem]";
        static Dictionary<ulong, decimal> PlayersMoney = new Dictionary<ulong, decimal>();
        static List<string> Anuncios = new List<string>() { 
        Blue+"IEconomySytem "+Green+"Esta en Faze Beta, Si Encuentra un error reportelo en el Discord del Server",
        Blue+"Una Forma Sencilla "+Green+"De llevar una economia en el server",
        Blue+"Tu Dinero Puedes Canjearlo "+Green+"Directamente en el Discord del Server",
        Blue+"Si Necesitas Ayuda"+Green+" Use /ayuda",
        Red+"IEconomySystem"+Teal+" by "+Yellow+"Daniel25A"
        };
        void Loaded()
        {
            ShowAmmouncerofPlugin();
        }
        void ShowAmmouncerofPlugin()
        {
            timer.Once(7f,() => {
                ShowAmmouncerofPlugin();
                if (ContadorDeAnuncios == (Anuncios.Count - 1))
                    ContadorDeAnuncios = 0;
                rust.BroadcastChat(SystemName, Anuncios[ContadorDeAnuncios]);
            });
        }
        void RegisterPlayer(NetUser Player)
        {
            if (!PlayersMoney.ContainsKey(Player.userID))
            {

            }
        }
    }
}