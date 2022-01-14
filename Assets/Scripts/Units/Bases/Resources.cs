using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resources : DamageableObjects, IInteractables, IAutoSpawn
{
    protected int maxMaterialCanHold;
    protected int currentMaterialHolding;
    protected GameObject itemPrototype;
    [SerializeField]protected Items materialsHolding;

    void Start()
    {
        itemPrototype = UnityEngine.Resources.Load<GameObject>("Prefabs/Items/ItemPrototype");
        itemPrototype.GetComponent<ItemPrototype>().item = materialsHolding;
        SpawnMaterials();
    }
    protected void SpawnMaterials()
    {
        Instantiate(itemPrototype);

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
