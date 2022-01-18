using UnityEngine;

public class RenewableResources : Resource
{
    protected int defaultHP;
    [SerializeField] protected Sprite havingMaterialImg;
    [SerializeField] protected Sprite notHavingMaterialImg;
    protected int renewTime;
    protected float cooldown; 
    protected SpriteRenderer spriteRenderer;  
    void Start()
    {   
        defaultHP = hp;
        cooldown = renewTime;
        currentMaterialHolding = maxMaterialCanHold;
        
        spriteRenderer = GetComponent<SpriteRenderer>();
        
        itemPrototype = UnityEngine.Resources.Load<GameObject>("Prefabs/Items/ItemPrototype");
        itemPrototype.GetComponent<ItemPrototype>().item = materialsHolding;
        
        InvokeRepeating("UpdateResourceStatus", 0, 0.5f);
    }
    void Update()
    {
        GainMaterials();
    }
    protected override void SpawnMaterials()
    {   
        Vector2 spawnPosition = new Vector2(transform.position.x + Random.Range(-0.5f, 0.5f), transform.position.y + Random.Range(-0.5f, 0.5f));
        Instantiate(itemPrototype, spawnPosition, Quaternion.identity);
        currentMaterialHolding--;
    }
    protected virtual void GainMaterials()
    {
        if(currentMaterialHolding < maxMaterialCanHold)
        {
            if(cooldown <= 0)
            {
                currentMaterialHolding++;
                cooldown = renewTime;
            }
            else
                cooldown -= Time.deltaTime; 
        }
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
        if(currentMaterialHolding > 0)
        {
        hp -= dmg;
        HPEqual0();
        }
    }
    protected override void HPEqual0()
    {
        if(hp <= 0)
        {
            SpawnMaterials();
            hp = defaultHP;
        }
    }
}
