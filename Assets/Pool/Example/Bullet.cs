using System.Collections;
using UnityEngine;
using UnityNightPool;

namespace UnityNightPool.Example
{
    public class Bullet : MonoBehaviour
    {

        public float force = 5f;

        public void Shoot()
        {
            Rigidbody rg = GetComponent<Rigidbody>();
            rg.velocity = new Vector3(Random.Range(-force, force), Random.Range(-force, force), Random.Range(-force, force));
            StartCoroutine(Destroy());
        }

        IEnumerator Destroy()
        {
            yield return new WaitForSeconds(3f);
            GetComponent<PoolObject>().Return();
        }
    }
}