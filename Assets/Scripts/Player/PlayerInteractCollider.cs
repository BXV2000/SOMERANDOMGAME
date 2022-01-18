using UnityEngine;

public class PlayerInteractCollider : MonoBehaviour
{
    private PlayerController playerController;

    void Start()
    {
        playerController = GetComponentInParent<PlayerController>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        playerController.interactGO = collision.GetComponent<IInteractables>();
    }
    void OnTriggerExit2D(Collider2D collsion)
    {
        playerController.interactGO = null;
    }
}
