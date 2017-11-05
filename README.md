# UnityNightPool
Simple object pooling plugin for Unity3D game engine

## Quick start
#### 1. [Download](https://github.com/alexdebur/UnityNightPool/releases) and import package to your project (Assets->Import Package->Custom Package).
![ex](http://screenshot.ru/upload/images/2017/11/05/1b2fb1.jpg)

#### 2. Add PoolObject script to all your prefabs that you need to use in pool
![ex](http://screenshot.ru/upload/images/2017/11/05/298a05.jpg)

#### 3. Create Resources folder in your Assets folder (if not exist)

#### 4. Create PoolConfig scriptable object in your Resources folder. Right mouse click in Resources->Create->Pool Config.
![ex](http://screenshot.ru/upload/images/2017/11/05/30fac5.jpg)

#### 5. Add all your prefabs to this scriptable object and set custom id for each.
![ex](http://screenshot.ru/upload/images/2017/11/05/4345d1.jpg)

#### 6. Add plugin namespace to your .cs file:

    using UnityNightPool;

#### 7. All ready! Now for spawn object add only one line (instead of Instantiate method):

    PoolManager.Get(int key);
    
    For return to pool:
   
    GetComponent<PoolObject>().Return();
    
#### Don't call Destroy on your pool prefab, only PoolObject.Return()!

