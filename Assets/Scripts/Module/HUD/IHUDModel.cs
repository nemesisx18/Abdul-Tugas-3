using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.HUD
{
    public interface IHUDModel : IBaseModel
    {
        public int Health { get; }
    }
}
