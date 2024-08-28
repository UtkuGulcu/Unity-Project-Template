using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public abstract class PanelService : BaseService
{
    private static List<BasePanel> panelList = new List<BasePanel>();
    protected BasePanel activePanel;

    public void AddPanel(BasePanel panelToAdd)
    {
        panelList.Add(panelToAdd);
    }

    public void AddPanel(BasePanel[] panelToAddArray)
    {
        panelList.AddRange(panelToAddArray);
    }

    public T Get<T>() where T : BasePanel
    {
        return panelList.OfType<T>().LastOrDefault();
    }

    public virtual void Show<T>() where T : BasePanel
    {

    }
}
