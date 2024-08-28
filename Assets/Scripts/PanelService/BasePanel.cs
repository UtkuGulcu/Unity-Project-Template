using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePanel : MonoBehaviour
{
    public Action OnPreAppear;
    public Action OnPostAppear;
    public Action OnPreDisappear;
    public Action OnPostDisappear;

    protected BasePanelAnimation panelAnimation;

    private void Awake()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        panelAnimation = GetComponent<BasePanelAnimation>();

        panelAnimation.OnAppearAnimationFinished += () =>
        {
            OnPostAppear?.Invoke();
            PostAppeared();
        };

        panelAnimation.OnDisappearAnimationFinished += () =>
        {
            OnPostDisappear?.Invoke();
            PostDisappeared();
        };
    }

    public virtual void Appear()
    {
        OnPreAppear?.Invoke();
        PreAppeared();
    }

    public virtual void Disappear()
    {
        OnPreDisappear?.Invoke();
        PreDisappeared();
    }

    protected virtual void PreAppeared()
    {

    }

    protected virtual void PostAppeared()
    {

    }

    protected virtual void PreDisappeared()
    {

    }

    protected virtual void PostDisappeared()
    {

    }
}
