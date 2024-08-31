using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public static Action OnAnyExampleSoundEvent;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            ServiceManager.GetService<MenuService>().Show<HomeMenu>();
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            ServiceManager.GetService<MenuService>().Show<GameplayMenu>();
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            ServiceManager.GetService<PopupService>().Show<ExamplePopup>();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            OnAnyExampleSoundEvent.Invoke();
        }
    }
}
