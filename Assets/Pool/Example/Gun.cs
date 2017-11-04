using UnityEngine;
using UnityNightPool;

namespace UnityNightPool.Example
{
    public class Gun : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetMouseButton(0))
            {
                PoolObject bullet = PoolManager.Get(1);
                bullet.transform.position = transform.position;
                bullet.GetComponent<Bullet>().Shoot();
            }
        }
    }
}