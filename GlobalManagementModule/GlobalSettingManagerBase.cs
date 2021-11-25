using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class GlobalSettingManagerBase<TComponent, TSetting, TContext> : MonoBehaviour 
    where TComponent : Component
    where TContext : struct
{
    protected TContext[] _settingContexts;

    private void Start()
    {
        _settingContexts = Object.FindObjectsOfType<TComponent>()
            .Select(xx => CreateSettingContext(xx.GetComponent<TComponent>()))
            .ToArray();
        UpdateAllComponents();
    }

    protected void UpdateAllComponents()
    {
        foreach (TContext context in _settingContexts)
            UpdateSingleComponent(context);
    }

    protected abstract void SetValue(TSetting value);

    protected abstract TContext CreateSettingContext(TComponent component);

    protected abstract void UpdateSingleComponent(TContext context);

    public void ModifySetting(TSetting value)
    {
        SetValue(value);
        UpdateAllComponents();
    }
}
