using UnityEngine;

public class RenewableResources : Resources
{
    [SerializeField] protected Sprite havingMaterialImg;
    [SerializeField] protected Sprite notHavingMaterialImg; 
    protected SpriteRenderer spriteRenderer;  
    void Start()
    {   
        spriteRenderer = GetComponent<SpriteRenderer>();
        itemPrototype = UnityEngine.Resources.Load<GameObject>("Prefabs/Items/ItemPrototype");
        itemPrototype.GetComponent<ItemPrototype>().item = materialsHolding;
        SpawnMaterials();
    }
    protected override void SpawnMaterials()
    {
        Vector2 spawnPosition = new Vector2(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.5f, 0.5f));
        Instantiate(itemPrototype, spawnPosition, Quaternion.identity);
    }
    protected virtual void GainMaterials()
    {

    }
    protected virtual void UpdateResourceStatus()
    {
        if(currentMaterialHolding <= 0)
        {
            spriteRenderer.sprite = notHavingMaterialImg;
        }
        else spriteRenderer.sprite = havingMaterialImg;
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
