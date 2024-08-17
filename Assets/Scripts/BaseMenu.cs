using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMenu : MonoBehaviour
{
    public Action OnPreAppear;
    public Action OnPostAppear;
    public Action OnPreDisappear;
    public Action OnPostDisappear;

    private BaseMenuAnimation menuAnimation;
    private RectTransform rectTransform;
    private Vector2 startPosition;

    private void Awake()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        menuAnimation = GetComponent<BaseMenuAnimation>();
        rectTransform = GetComponent<RectTransform>();
        ServiceManager.GetService<MenuService>().Add(this);
        startPosition = rectTransform.anchoredPosition;
    }

    protected virtual void Start()
    {
        menuAnimation.OnAppearAnimationFinished += () =>
        {
            OnPostAppear?.Invoke();
            PostAppeared();
        };

        menuAnimation.OnDisappearAnimationFinished += () =>
        {
            OnPostDisappear?.Invoke();
            PostDisappeared();
        };
    }

    public void Appear()
    {
        OnPreAppear?.Invoke();
        PreAppeared();
        rectTransform.anchoredPosition = Vector2.zero;
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

    public void Disappear()
    {
        OnPreDisappear?.Invoke();
        PreDisappeared();
        rectTransform.anchoredPosition = startPosition;
    }
}
