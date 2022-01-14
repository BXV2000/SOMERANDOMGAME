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
        Vector2 spawnPosition = new Vector2(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.5f, 0.5f));
        Instantiate(itemPrototype, spawnPosition, Quaternion.identity);
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
