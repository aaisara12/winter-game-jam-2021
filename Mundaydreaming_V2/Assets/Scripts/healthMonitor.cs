using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class healthMonitor : MonoBehaviour
{
    public static healthMonitor monitor;

    private void Awake()
    {
        monitor = this;
    }
    public event Action<int> onLowHealthIndicator;
    public void lowHealthIndicator(int id)
    {  
        onLowHealthIndicator?.Invoke(id);
    }

}
