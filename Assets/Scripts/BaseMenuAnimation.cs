using Cysharp.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMenuAnimation : MonoBehaviour
{
    public Action OnAppearAnimationFinished;
    public Action OnDisappearAnimationFinished;

    private BaseMenu baseMenu;

    protected virtual void Awake()
    {
        baseMenu = GetComponent<BaseMenu>();
    }

    private void Start()
    {
        baseMenu.OnPreAppear += OnMenuPreAppeared;
        baseMenu.OnPreDisappear += OnMenuPreDisappeared;
    }

    private void OnDestroy()
    {
        baseMenu.OnPreAppear -= OnMenuPreAppeared;
        baseMenu.OnPreDisappear -= OnMenuPreDisappeared;
    }

    protected virtual void OnMenuPreAppeared()
    {
        //Play Animation / DoTween

        StartCoroutine(WaitForDelay());

        IEnumerator WaitForDelay()
        {
            yield return new WaitForSeconds(1f);
            OnAppearAnimationFinished?.Invoke();
        }
    }

    protected virtual void OnMenuPreDisappeared()
    {
        //Play Animation / DoTween

        StartCoroutine(WaitForDelay());

        IEnumerator WaitForDelay()
        {
            yield return new WaitForSeconds(1f);
            OnDisappearAnimationFinished?.Invoke();
        }
    }
}
