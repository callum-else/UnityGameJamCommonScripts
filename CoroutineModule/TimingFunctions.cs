using System;
using System.Collections;
using UnityEngine;

public static class TimingFunctions
{
    private static CoroutineExecutor _coroutineExecutor = new CoroutineExecutor();

    public static void ActionAfterSeconds(float seconds, Action action)
    {
        static IEnumerator ActionAfterSecondsInternal(float seconds, Action action)
        {
            yield return new WaitForSeconds(seconds);
            action();
        }

        _coroutineExecutor.StartCoroutine(ActionAfterSecondsInternal(seconds, action));
    }
}