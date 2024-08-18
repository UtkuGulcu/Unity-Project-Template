using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayMenu : BaseMenu
{
    protected override void PreAppeared()
    {
        base.PreAppeared();
        Debug.Log("GameplayMenu PreAppeared");
    }

    protected override void PostAppeared()
    {
        base.PostAppeared();
        Debug.Log("GameplayMenu PostAppeared");
    }

    protected override void PreDisappeared()
    {
        base.PreDisappeared();
        Debug.Log("GameplayMenu PreDisappeared");
    }

    protected override void PostDisappeared()
    {
        base.PostDisappeared();
        Debug.Log("GameplayMenu PostDisappeared");
    }
}
