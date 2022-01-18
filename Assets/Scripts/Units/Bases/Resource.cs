using UnityEngine;

public abstract class Resource : DamageableObjects, IAutoSpawn
{
    [SerializeField]protected int maxMaterialCanHold;
    protected int currentMaterialHolding;
    protected GameObject itemPrototype;
    [SerializeField]protected Items materialsHolding;

    protected abstract void SpawnMaterials();
    public abstract void Remove();
    public abstract void Spawn();
}
