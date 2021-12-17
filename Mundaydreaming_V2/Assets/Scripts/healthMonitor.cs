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
    public event Action<int> onplayerLowHealth;
    public void playerLowHealth(int id)
    {  
        onplayerLowHealth?.Invoke(id);

    }

    public event Action<int> onToastLowHealth;
    public void toastLowHealth(int id)
    {
        Time.timeScale=0f;
        onToastLowHealth?.Invoke(id);
    }

}
