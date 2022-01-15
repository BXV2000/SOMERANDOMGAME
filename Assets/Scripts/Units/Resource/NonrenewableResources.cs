using UnityEngine;

public class NonrenewableResources : Resources
{
    [SerializeField] protected Sprite havingMaterialImg;
    void Start()
    {   
        itemPrototype = UnityEngine.Resources.Load<GameObject>("Prefabs/Items/ItemPrototype");
        itemPrototype.GetComponent<ItemPrototype>().item = materialsHolding;
        SpawnMaterials();
    }
    protected override void SpawnMaterials()
    {
        Vector2 spawnPosition = new Vector2(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.5f, 0.5f));
        Instantiate(itemPrototype, spawnPosition, Quaternion.identity);
        Destroy(gameObject);
    }
    public override void Remove()
    {
        return;
    }
    public override void Spawn()
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
