using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    // Shooting Event
    static List<Player> playerShootInvokers = new List<Player>();
    static List<UnityAction> playerShootListeners = new List<UnityAction>();

    public static void AddPlayerShootInvoker(Player invoker)
    {
        playerShootInvokers.Add(invoker);
        foreach(UnityAction listener in playerShootListeners)
        {
            invoker.AddPlayerShootListener(listener);
        }
    }

    public static void AddPlayerShootListener(UnityAction listener)
    {
        playerShootListeners.Add(listener);
        foreach(Player invoker in playerShootInvokers)
        {
            invoker.AddPlayerShootListener(listener);
        }
    }

    // Laser Spawning Event
    static List<Player> laserReadyInvokers = new List<Player>();
    static List<UnityAction<Vector3>> laserReadyListeners = new List<UnityAction<Vector3>>();

    public static void AddLaserReadyInvoker(Player invoker)
    {
        laserReadyInvokers.Add(invoker);
        foreach(UnityAction<Vector3> listener in laserReadyListeners)
        {
            invoker.AddLaserReadyListener(listener);
        }
    }

    public static void AddLaserReadyListener(UnityAction<Vector3> listener)
    {
        laserReadyListeners.Add(listener);
        foreach (Player invoker in laserReadyInvokers)
        {
            invoker.AddLaserReadyListener(listener);
        } 
    }

}
