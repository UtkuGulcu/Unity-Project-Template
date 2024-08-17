using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class ServiceManager
{ 
    private static List<BaseService> serviceList = new List<BaseService>();

    public static void AddService(BaseService service)
    {
        if (serviceList.Contains(service))
        {
            return;
        }

        serviceList.Add(service);
    }

    public static T GetService<T>() where T : BaseService
    {
        return serviceList.OfType<T>().FirstOrDefault();
    }
}
