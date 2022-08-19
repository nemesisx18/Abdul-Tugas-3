using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Shield
{
    public interface IShieldModel : IBaseModel
    {
        public int HealthShield { get; }
    }
}