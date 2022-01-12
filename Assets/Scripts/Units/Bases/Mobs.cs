using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mobs : Creatures, IAutoSpawn
{
    protected GameObject target;
    public void Remove()
    {
        return;
    }
    public void Spawn()
    {
        return;
    }
    protected void UpdateTarget()
    {
        return;
    }
}
