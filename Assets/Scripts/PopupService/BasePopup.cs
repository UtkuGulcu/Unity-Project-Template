using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BasePopup : BasePanel
{
    [SerializeField] protected Button backgroundButton;
    [SerializeField] protected Button closeButton;

    protected override void Initialize()
    {
        base.Initialize();

        if (backgroundButton)
        {
            backgroundButton.onClick.AddListener(ClosePopup);
        }

        if (closeButton)
        {
            closeButton.onClick.AddListener(ClosePopup);
        }
    }

    private void OnDestroy()
    {
        if (backgroundButton)
        {
            backgroundButton.onClick.RemoveAllListeners();
        }

        if (closeButton)
        {
            closeButton.onClick.RemoveAllListeners();
        }
    }

    protected override void PostDisappeared()
    {
        base.PostDisappeared();
        Destroy(gameObject);
    }

    private void ClosePopup()
    {
        Disappear();
    }
}
