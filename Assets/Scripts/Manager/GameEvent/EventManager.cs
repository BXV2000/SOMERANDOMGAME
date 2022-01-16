using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] private List<EventListener> listeners = new List<EventListener>();
    private void Awake()
    {
        foreach (EventListener listener in listeners)
        {
            listener.Register();
        }
    }
    private void OnDestroy()
    {
        foreach (EventListener listener in listeners)
        {
            listener.Deregister();
        }
    }
}
