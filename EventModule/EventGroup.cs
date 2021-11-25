using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventGroup : MonoBehaviour
{
    [Header(Headers.EventListeners)]
    [SerializeField] UnityEvent EventListeners;

    public void Dispatch()
        => EventListeners.Invoke();

    public void DispatchAfterSeconds(float seconds)
        => TimingFunctions.ActionAfterSeconds(seconds, EventListeners.Invoke);
}
