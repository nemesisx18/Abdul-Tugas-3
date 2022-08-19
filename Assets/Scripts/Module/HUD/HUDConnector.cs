using Agate.MVC.Base;
using SpaceInvader.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.HUD
{
    public class HUDConnector : BaseConnector
    {
        private HUDController _hud;

        protected override void Connect()
        {
            Subscribe<ReduceHealthMessage>(_hud.OnUpdateHealth);
        }

        protected override void Disconnect()
        {
            Unsubscribe<ReduceHealthMessage>(_hud.OnUpdateHealth);
        }
    }
}