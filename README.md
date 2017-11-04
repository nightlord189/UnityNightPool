# UnityNightPool
Simple object pooling plugin for Unity3D game engine

## Quick start
#### 1. [Download](https://github.com/alexdebur/UnityNightPool/releases) and import package to your project (Assets->Import Package->Custom Package).

#### 2. Add PoolObject script to all your prefabs that you need to use in pool

#### 3. Create Resources folder in your Assets folder (if not exist)

#### 4. Create PoolConfig scriptable object in your Resources folder. Right mouse click in Resources->Create->Pool Config.

#### 5. Add all your prefabs to this scriptable object and set custom id for each.

#### 6. All ready! Now for spawn object add only one line (instead of Instantiate method):

    PoolManager.Get(int key);
    
    For return to pool:
   
    GetComponent<PoolObject>().Return();
    
#### Don't call Destroy on your pool prefab, only PoolObject.Return()!

