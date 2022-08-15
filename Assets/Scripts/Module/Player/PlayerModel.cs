using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceInvader.Module.Player{
    public class PlayerModel : BaseModel, IPlayerModel
    {
        public float maxLeft { get; private set; } = -8f;
        public float maxRight { get; private set; }  = 8f;

        public float speed { get; private set; } = 10;
    }
}
