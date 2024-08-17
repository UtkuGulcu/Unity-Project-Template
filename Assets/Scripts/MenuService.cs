using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class MenuService : BaseService
{
    private List<BaseMenu> menuList = new List<BaseMenu>();
    private BaseMenu activeMenu;

    protected override void Awake()
    {
        base.Awake();
    }

    public void Add(BaseMenu baseMenu)
    {
        menuList.Add(baseMenu);
    }

    public T Get<T>() where T : BaseMenu
    {
        return menuList.OfType<T>().FirstOrDefault();
    }

    public void Show<T>() where T : BaseMenu
    {
        if (activeMenu && activeMenu.GetType() == typeof(T))
        {
            return;
        }

        if (activeMenu && activeMenu.GetType() != typeof(T))
        {
            activeMenu.Disappear();
        }

        activeMenu = Get<T>();
        activeMenu.Appear();
    }
}
