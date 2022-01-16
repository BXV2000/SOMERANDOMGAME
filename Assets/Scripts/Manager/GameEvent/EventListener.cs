using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class EventListener 
{
    [SerializeField] private string name;
    [SerializeField] private GameEvent gameEvent;
    public UnityEvent unityEvent; 
    public void Register()
    {
        gameEvent.Register(this);
    }
    public void Deregister()
    {
        gameEvent.Deregister(this);
    }
    public void RaiseEvent()
    {
        unityEvent?.Invoke();
    }
}
