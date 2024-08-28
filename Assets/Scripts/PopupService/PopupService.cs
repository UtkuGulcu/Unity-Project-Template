using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupService : PanelService
{
    [SerializeField] private BasePopup[] popupPrefabArray;

    protected override void Initialize()
    {
        base.Initialize();

        AddPanel(popupPrefabArray);
    }

    public override void Show<T>()
    {
        base.Show<T>();

        activePanel = Get<T>();
        var spawnedPopup = Instantiate(activePanel, transform).GetComponent<BasePopup>();
        spawnedPopup.Appear();
    }
}
