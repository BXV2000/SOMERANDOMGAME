using UnityEngine;

public class ItemPrototype : MonoBehaviour, IInteracables
{

    public Items item;
    private SpriteRenderer spriteRenderer;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void UpdateItemPrototypeData()
    {
        spriteRenderer.sprite = item.icon;
    }

    public void Interact()
    {
        PickUp();
    }

    void PickUp()
    {
        Bag.bag.AddItem(item);
    }
}
