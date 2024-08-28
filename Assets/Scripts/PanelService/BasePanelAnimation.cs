using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BasePanelAnimation : MonoBehaviour
{
    public Action OnAppearAnimationFinished;
    public Action OnDisappearAnimationFinished;

    private BasePanel basePanel;

    protected virtual void Awake()
    {
        basePanel = GetComponent<BasePanel>();
        basePanel.OnPreAppear += OnMenuPreAppeared;
        basePanel.OnPreDisappear += OnMenuPreDisappeared;
    }

    private void OnDestroy()
    {
        basePanel.OnPreAppear -= OnMenuPreAppeared;
        basePanel.OnPreDisappear -= OnMenuPreDisappeared;
    }

    protected virtual void OnMenuPreAppeared()
    {

    }

    protected virtual void OnMenuPreDisappeared()
    {

    }
}
