using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeMenu : BaseMenu
{
    protected override void PreAppeared()
    {
        base.PreAppeared();
        Debug.Log("HomeMenu PreAppeared");
    }

    protected override void PostAppeared()
    {
        base.PostAppeared();
        Debug.Log("HomeMenu PostAppeared");
    }

    protected override void PreDisappeared()
    {
        base.PreDisappeared();
        Debug.Log("HomeMenu PreDisappeared");
    }

    protected override void PostDisappeared()
    {
        base.PostDisappeared();
        Debug.Log("HomeMenu PostDisappeared");
    }
}
