using System.Collections.Generic;
using UnityEngine;

namespace UnityNightPool {
	public class Pool{
	    PoolSetup _setup;

	    public PoolSetup setup
	    {
	        get { return _setup; }
	        private set { _setup = value; }
	    }

        public int id {
			get {
				return setup.id;
			}
		}

		List<PoolObject> spawned=new List<PoolObject>();

		public void ReturnAll() {
			for (int i = 0; i < spawned.Count; i++) {
				if (spawned[i]!=null && !spawned [i].free)
					spawned [i].Return ();
			}
		}

		public Pool (PoolSetup setup) {
			this.setup = setup;
		}


	    PoolObject Create(int index = -1)
	    {
	        GameObject obj = Object.Instantiate(setup.prefab.gameObject) as GameObject;
	        obj.name = setup.prefab.name + "(Pool)";
	        var p = obj.GetComponent<PoolObject>();
	        if (p != null)
	        {
	            p.Init(this);
	            if (index == -1)
	                spawned.Add(p);
	            else
	                spawned[index] = p;
	        }
	        else
	            Object.Destroy(obj);
	        return p;
	    }

	    public PoolObject Get()
	    {
	        for (int i = 0; i < spawned.Count; i++)
	        {
	            if (spawned[i] == null)
	            {
	                Create(i);
	                spawned[i].Push();
	                return spawned[i];
	            }
	            if (spawned[i].free)
	            {
	                spawned[i].Push();
	                return spawned[i];
	            }
	        }
	        var p = Create();
	        p.Push();
	        return p;
	    }
    }
}