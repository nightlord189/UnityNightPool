namespace UnityNightPool {
	[System.Serializable]
	public class PoolSetup{
		public PoolObject prefab;
		public int id;
	    public bool switchGameObject = true;

        public PoolSetup(PoolObject prefab, int id) {
			this.prefab = prefab;
			this.id = id;
		}

	    public PoolSetup(PoolObject prefab, int id, bool switchGameObject)
	    {
	        this.prefab = prefab;
	        this.id = id;
	        this.switchGameObject = switchGameObject;
	    }
    }
}