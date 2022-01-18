using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    [SerializeField] private List<EventListener> listeners = new List<EventListener>();
    [SerializeField] private List<EventListener_Float> listeners_float = new List<EventListener_Float>();
    private void Awake()
    {
        foreach (EventListener listener in listeners)
        {
            listener.Register();
        }

        foreach (EventListener_Float listener in listeners_float)
        {
            listener.Register();
        }
    }
    private void OnDestroy()
    {
        foreach (EventListener_Float listener in listeners_float)
        {
            listener.Deregister();
        }
    }
}
