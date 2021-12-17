using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class healthMonitor : MonoBehaviour
{
    public static healthMonitor monitor;
    public delegate void help(string s, int i);
    public static help onplayerLowHealth;
    public static help onToastLowHealth;

    private void Awake()
    {
        monitor = this;
    }

    public void playerLowHealth(int id)
    {  
        onplayerLowHealth?.Invoke("Player", id);
    }

    public void toastLowHealth(int id)
    {
        onToastLowHealth?.Invoke("Toast", id);
    }

}
