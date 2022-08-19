using Agate.MVC.Base;
using SpaceInvader.Message;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.HUD
{
    public class HUDController : ObjectController<HUDController, HUDModel, IHUDModel, HUDView>
    {
        public void OnUpdateHealth(ReduceHealthMessage message)
        {
            _model.SetHealth(message.Health);
        }
    }

}