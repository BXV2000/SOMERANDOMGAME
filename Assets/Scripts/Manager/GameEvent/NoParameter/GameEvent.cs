using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Event/NoParameterEvents", fileName = "newGameEvent")]
public class GameEvent : ScriptableObject
{
    private List<EventListener> listeners = new List<EventListener>();
    public void Invoke()
    {
        foreach (EventListener listener in listeners)
        {
            listener.RaiseEvent();
        }
    }
    public void Register(EventListener listener)
    {
        if(!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }
    public void Deregister(EventListener listener)
    {
        if(listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }
    }
}
