using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
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
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            ServiceManager.GetService<MenuService>().Get<HomeMenu>().Disappear();
        }
    }
}
