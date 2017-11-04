using System.Collections.Generic;
using UnityEngine;

namespace UnityNightPool {
	public static class PoolManager{
		static List<Pool> pools = new List<Pool>();
		static bool init = false;
		static Transform _parent;

		public static Transform parent {
			get {
				return _parent;
			}
			private set {
				_parent = value;
			}
		}

		public static PoolObject Get(int key) {
			Init ();
			var p = pools.Find (x => x.id == key);
			if (p != null)
				return p.Get ();
			return null;
		}


		static void Init() {
			if (!init) {
				parent = (new GameObject ("Pools")).transform;
				Object.DontDestroyOnLoad (parent.gameObject);
				for (int i = 0; i < PoolConfig.pools.Count; i++) {
					if (PoolConfig.pools [i].prefab != null) {
						Pool p = new Pool (PoolConfig.pools [i]);
						pools.Add (p);
					}
				}
				init = true;
			}
		}
	}
}