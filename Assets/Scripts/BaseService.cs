using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-99)]
public abstract class BaseService : MonoBehaviour
{
    protected virtual void Awake()
    {
        ServiceManager.AddService(this);
    }
}
