using Agate.MVC.Base;
using Agate.MVC.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Shield
{
    public class ShieldModel : BaseModel, IShieldModel
    {
        public int HealthShield { get; private set; } = 3;

        public void DamagedShield()
        {
            HealthShield -= 1;
            SetDataAsDirty();
        }
    }
}
