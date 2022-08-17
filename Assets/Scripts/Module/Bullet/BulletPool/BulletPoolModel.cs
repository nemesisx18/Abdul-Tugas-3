using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace SpaceInvader.Module.Bullet
{
    public class BulletPoolModel : BaseModel, IBulletPoolModel
    {
        public EnemyScriptableObject enemyScriptableObject { get; private set; }

        public int amountToPool { get; set; }
        public int maxBullet { get; set; } = 5;

        public List<GameObject> pooledBullets { get; set; } = new List<GameObject>();

        public BulletPoolModel()
        {
            enemyScriptableObject = Resources.Load<EnemyScriptableObject>("BulletData");
        }

        public void AddBullet(GameObject bullet)
        {
            pooledBullets.Add(bullet);
            SetDataAsDirty();
        }

        public void RemoveBullet(GameObject bullet)
        {
            pooledBullets.Remove(bullet);
            SetDataAsDirty();
        }
    }
}
