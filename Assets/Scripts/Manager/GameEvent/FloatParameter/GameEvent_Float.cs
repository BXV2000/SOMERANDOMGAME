using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Game Event/FloatEvents", fileName = "newGameEvent")]
public class GameEvent_Float : ScriptableObject
{
   private List<EventListener_Float> listeners = new List<EventListener_Float>();

   public void Invoke(float value)
    {
        foreach (EventListener_Float listener in listeners)
        {
            listener.RaiseEvent(value);
        }
    }
    public void Register(EventListener_Float listener)
    {
        if(!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }
    public void Deregister(EventListener_Float listener)
    {
        if(listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }
    }
}
