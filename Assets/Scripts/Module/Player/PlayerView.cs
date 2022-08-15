using Agate.MVC.Base;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace SpaceInvader.Module.Player{
    public class PlayerView : ObjectView<IPlayerModel>
    {

        //private UnityAction _onMovePlayer;

        protected override void InitRenderModel(IPlayerModel model)
        {
            //throw new System.NotImplementedException();
        }

        protected override void UpdateRenderModel(IPlayerModel model)
        {
            //throw new System.NotImplementedException();
        }

         /*public void SetCallBacks(UnityAction onMovePlayer)
        {
            _onMovePlayer = onMovePlayer;
        }*/

        private void Update()
        {
            //_onMovePlayer?.Invoke();
            /*if (Input.GetKey(KeyCode.A) && transform.position.x > _model.maxLeft)
            {
                transform.Translate(_model.speed * Time.deltaTime * Vector2.left);
            }
            if (Input.GetKey(KeyCode.D) && transform.position.x < _model.maxRight)
            {
                transform.Translate(_model.speed * Time.deltaTime * Vector2.right);
            }*/
        }
    }
}
