using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Enemy
{
    public class EnemyView : ObjectView<IEnemyModel>
    {
        public float originalX { get; private set; }
        private UnityAction _onMove;

        public void SetCallback(UnityAction OnMove)
        {
            _onMove = OnMove;
        }

        protected override void InitRenderModel(IEnemyModel model)
        {
            originalX = transform.position.x;
            Debug.Log(originalX);
        }

        protected override void UpdateRenderModel(IEnemyModel model)
        {
            
        }

        private void Start()
        {
            
        }

        private void Update()
        {
            _onMove.Invoke();
        }
    }
}