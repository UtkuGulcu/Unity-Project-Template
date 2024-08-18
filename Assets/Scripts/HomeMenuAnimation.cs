using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeMenuAnimation : BaseMenuAnimation
{
    [SerializeField] private Image image;

    protected override void OnMenuPreAppeared()
    {
        base.OnMenuPreAppeared();

        image.DOFade(1f, 0.5f).onComplete += () =>
        {
            OnAppearAnimationFinished?.Invoke();
        };
    }

    protected override void OnMenuPreDisappeared()
    {
        base.OnMenuPreDisappeared();

        image.DOFade(0f, 0.5f).onComplete += () =>
        {
            OnDisappearAnimationFinished?.Invoke();
        };
    }
}
