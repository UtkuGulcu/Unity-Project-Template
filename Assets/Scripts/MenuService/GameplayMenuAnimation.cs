using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameplayMenuAnimation : BasePanelAnimation
{
    [SerializeField] private Image backgroundImage;

    protected override void OnMenuPreAppeared()
    {
        base.OnMenuPreAppeared();

        backgroundImage.color = new Color(backgroundImage.color.r, backgroundImage.color.g, backgroundImage.color.b, 0f);

        backgroundImage.DOFade(1f, 0.5f).onComplete += () =>
        {
            OnAppearAnimationFinished?.Invoke();
        };
    }

    protected override void OnMenuPreDisappeared()
    {
        base.OnMenuPreDisappeared();
        OnDisappearAnimationFinished?.Invoke();
    }
}