using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseMenu : BasePanel
{
    private RectTransform rectTransform;
    private Vector2 startPosition;

    protected override void Initialize()
    {
        base.Initialize();

        ServiceManager.GetService<PanelService>().AddPanel(this);

        rectTransform = GetComponent<RectTransform>();
        startPosition = rectTransform.anchoredPosition;
    }

    public override void Appear()
    {
        base.Appear();

        rectTransform.anchoredPosition = Vector2.zero;
    }

    public override void Disappear()
    {
        base.Disappear();

        rectTransform.anchoredPosition = startPosition;
    }
}
