using Agate.MVC.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Module.Player{
    public class PlayerView : ObjectView<IPlayerModel>
    {
        private Vector2 direction;
        private float speed;

        protected override void InitRenderModel(IPlayerModel model)
        {
            direction = Vector2.zero;
        }

        protected override void UpdateRenderModel(IPlayerModel model)
        {
            direction = model.Direction;
            speed = model.speed;
        }

        private void Update()
        {
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }
}
