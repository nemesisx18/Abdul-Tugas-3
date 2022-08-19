using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.HUD
{
    public class HUDModel : BaseModel, IHUDModel
    {
        public int Health { get; private set; } = 3;

        public void SetHealth(int health)
        {
            Health = health;
            SetDataAsDirty();
        }
    }
}