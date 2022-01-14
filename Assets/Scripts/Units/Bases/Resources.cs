using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : DamageableObjects, IInteractables, IAutoSpawn
{
    protected int maxMaterialCanHold;
    protected int currentMaterialHolding;
    [SerializeField]protected Items materialsHolding;

    protected void SpawnMaterials()
    {
        
    }
    protected void GainMaterials()
    {

    }
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
    protected override void TakeDmg(int dmg)
    {
        
    }
    protected override void HPEqual0()
    {

    }
}
