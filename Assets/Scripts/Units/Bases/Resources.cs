using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Resources : DamageableObjects, IInteracables, IAutoSpawn
{
    protected int maxMaterialCanHold;
    protected int currentMaterialHolding;
    protected Items materialsHolding;

    protected abstract void SpawnMaterials();
    protected abstract void GainMaterials();
    public void Interact()
    {
        return;
    }
    public void Remove()
    {
        return;
    }
    public void Spawn()
    {
        return;
    }
}
