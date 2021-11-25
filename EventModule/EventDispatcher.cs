using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventDispatcher : MonoBehaviour
{
    [SerializeField] private UnityEvent[] EventGroups;

    public void DispatchGroup(int group) 
        => EventGroups[group].Invoke();

    public void DispatchGroupAfterSeconds(int group, float seconds)
        => TimingFunctions.ActionAfterSeconds(seconds, () => { DispatchGroup(group); });
}