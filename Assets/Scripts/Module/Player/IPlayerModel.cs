using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Player{
    public interface IPlayerModel : IBaseModel
    {
        public float maxLeft { get; }
        public float maxRight { get; }
        public float speed { get; }
    }
}