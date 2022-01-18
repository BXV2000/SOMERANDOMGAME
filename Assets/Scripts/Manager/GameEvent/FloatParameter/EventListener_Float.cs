using UnityEngine.Events;
using UnityEngine;

[System.Serializable]
public class UnityEventFloat : UnityEvent<float>{}

[System.Serializable]
public class EventListener_Float 
{
    [SerializeField] private string name;
    [SerializeField] private GameEvent_Float gameEvent;
    public UnityEventFloat unityEvent;

    public void Register()
    {
        gameEvent.Register(this);
    }
    public void Deregister()
    {
        gameEvent.Deregister(this);
    }
    public void RaiseEvent(float value)
    {
        unityEvent?.Invoke(value);
    }
}
