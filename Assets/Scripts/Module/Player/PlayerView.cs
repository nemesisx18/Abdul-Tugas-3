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
        private float maxLeft, maxRight;

        private UnityAction _onTriggerWithBulletEnemy;

        public void SetCallbacks(UnityAction onTriggerWithBulletEnemy)
        {
            _onTriggerWithBulletEnemy = onTriggerWithBulletEnemy;
        }

        protected override void InitRenderModel(IPlayerModel model)
        {
            //transform.position = _model.Position;
            direction = Vector2.zero;
            speed = model.speed;
            maxLeft = model.maxLeft;
            maxRight = model.maxRight;
        }

        protected override void UpdateRenderModel(IPlayerModel model)
        {
            direction = model.Direction;

        }

        private void Update()
        {
            movePosition();
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            bool isTriggerWithBulletEnemy = collision.gameObject.CompareTag("BulletEnemy");
            if (isTriggerWithBulletEnemy)
            {
                _onTriggerWithBulletEnemy?.Invoke();
            }
        }

        private void movePosition()
        {
            float _x = transform.position.x + direction.x;
            if (_x <= maxLeft || _x >= maxRight) return;
            transform.Translate(direction * Time.deltaTime * speed);
        }
    }
}
