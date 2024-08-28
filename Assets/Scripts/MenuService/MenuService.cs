using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MenuService : PanelService
{
    public override void Show<T>()
    {
        base.Show<T>();

        if (activePanel && activePanel.GetType() == typeof(T))
        {
            return;
        }

        if (activePanel && activePanel.GetType() != typeof(T))
        {
            activePanel.Disappear();
        }

        activePanel = Get<T>();
        activePanel.Appear();
    }
}
