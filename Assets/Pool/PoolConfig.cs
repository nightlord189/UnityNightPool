using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityNightPool {
	[CreateAssetMenu(fileName="PoolConfig")]
	public class PoolConfig : ScriptableObject {
		[SerializeField] List<PoolSetup> _pools = new List<PoolSetup>();

		public static List<PoolSetup> pools {
			get {
				return instance._pools;
			}
		}

		static PoolConfig _instance;
		public static PoolConfig instance {
			get {
				if (_instance==null) {
					_instance = (PoolConfig)Resources.Load ("PoolConfig");
					if (_instance == null) {
						_instance = PoolConfig.CreateInstance<PoolConfig> ();
					}
				}
				return _instance;
			}
		}
	}

}