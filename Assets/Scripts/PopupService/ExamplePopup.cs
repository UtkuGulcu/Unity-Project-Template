using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamplePopup : BasePopup
{
    protected override void PreAppeared()
    {
        base.PreAppeared();
        Debug.Log("ExamplePopup PreAppeared");
    }

    protected override void PostAppeared()
    {
        base.PostAppeared();
        Debug.Log("ExamplePopup PostAppeared");
    }

    protected override void PreDisappeared()
    {
        base.PreDisappeared();
        Debug.Log("ExamplePopup PreDisappeared");
    }

    protected override void PostDisappeared()
    {
        base.PostDisappeared();
        Debug.Log("ExamplePopup PostDisappeared");
    }
}
