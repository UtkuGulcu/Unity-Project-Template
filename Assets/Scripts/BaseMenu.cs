using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMenu : MonoBehaviour
{
    private RectTransform rectTransform;
    private Vector2 startPosition;

    private void Awake()
    {
        Initialize();
    }

    protected virtual void Initialize()
    {
        rectTransform = GetComponent<RectTransform>();
        ServiceManager.GetService<MenuService>().Add(this);
        startPosition = rectTransform.anchoredPosition;
    }

    public void Appear()
    {
        rectTransform.anchoredPosition = Vector2.zero;
    }

    public void Disappear()
    {
        rectTransform.anchoredPosition = startPosition;
    }
}
