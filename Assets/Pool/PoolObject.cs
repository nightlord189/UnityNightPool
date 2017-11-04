using UnityEngine;

namespace UnityNightPool {
	public class PoolObject : MonoBehaviour {
		bool _free=true;
	    bool init = false;
	    bool switchGameObject = true;

        public bool free {
			get {
				return _free;
			}
			private set {
				_free = value;
			}
		}


	    public void Init(Pool pool)
	    {
	        if (!init)
	        {
	            init = true;
	            switchGameObject = pool.setup.switchGameObject;
	            if (switchGameObject) gameObject.SetActive(false);
	        }
	    }

        public void Push() {
			free = false;
            if (switchGameObject) gameObject.SetActive(true);
        }
			
		public void Return() {
		    if (init)
		    {
		        free = true;
		        transform.SetParent(PoolManager.parent);
                if (switchGameObject) gameObject.SetActive(false);
		    }
		    else
		    {
		        Destroy(gameObject);
		    }
        }
	}
}