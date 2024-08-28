using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExamplePopupAnimation : BasePanelAnimation
{
    [SerializeField] private Transform contentObject;
    [SerializeField] private Image backgroundImage;

    protected override void OnMenuPreAppeared()
    {
        base.OnMenuPreAppeared();

        contentObject.localScale = Vector3.zero;
        backgroundImage.color = new Color(backgroundImage.color.r, backgroundImage.color.g, backgroundImage.color.b , 0f);

        Sequence appearAnimationSequence = DOTween.Sequence();

        appearAnimationSequence.Append(backgroundImage.DOFade(0.5f, 0.5f));
        appearAnimationSequence.Join(contentObject.DOScale(1f, 0.5f));
        
        appearAnimationSequence.onComplete += () =>
        {
            OnAppearAnimationFinished?.Invoke();
        };
    }
}
