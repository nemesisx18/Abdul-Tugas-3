using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;
using SpaceInvader.Module.Player;
using SpaceInvader.Module.Message;
using System;

namespace SpaceInvader.Module.Bullet
{
    public class BulletPoolController : ObjectController<BulletPoolController, BulletPoolModel, IBulletPoolModel, BulletPoolView>
    {
        PlayerController Player;
        
        public void InitBulletPool()
        {
            if (_model.pooledBullets.Count < _model.maxBullet)
            {
                for (int i = 0; i < _model.maxBullet; i++)
                {
                    BulletModel instanceModel = new BulletModel();
                    GameObject bullet = _view.SpawnBullet(_model.enemyScriptableObject.enemyObject);

                    BulletView instanceView = bullet.GetComponent<BulletView>();
                    BulletController instance = new BulletController();


                    InjectDependencies(instance);
                    instance.Init(instanceModel, instanceView);

                    bullet.SetActive(false);
                    _model.AddBullet(bullet);
                }
            }
        }

        public override void SetView(BulletPoolView view)
        {
            base.SetView(view);
            InitBulletPool();
        }

        public void InitPoolBullet(Vector2 _pos)
        {
            SpawnBulletPool(_pos);
        }

        public void SpawnBulletPool(Vector2 pos)
        {
            GameObject bulletPool = PoolBullet();
            SpawnBullet(bulletPool, pos);
        }

        public GameObject PoolBullet()
        {
            for (int i = 0; i < _model.maxBullet; i++)
            {
                if (!_model.pooledBullets[i].activeInHierarchy)
                {
                    Debug.Log("PoolBullet");
                    return _model.pooledBullets[i];
                }
            }
            return null;
        }

        private void SpawnBullet(GameObject bullet, Vector2 pos)
        {
            bullet.transform.position = pos;
            bullet.SetActive(true);
        }
    }
}