using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class EventManager
{
    // PlayerShoot Event
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

    // LasersReady Event
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

    // LaserPlacing Event
    static List<Player> lasersPlacingInvokers = new List<Player>();
    static List<UnityAction<Vector3>> lasersPlacingListeners = new List<UnityAction<Vector3>>();

    public static void AddLasersPlacingInvoker(Player invoker)
    {
        lasersPlacingInvokers.Add(invoker);
        foreach (UnityAction<Vector3> listener in lasersPlacingListeners)
        {
            invoker.AddLaserPlacingListener(listener);
        }
    }

    public static void AddLasersPlacingListener(UnityAction<Vector3> listener)
    {
        lasersPlacingListeners.Add(listener);
        foreach (Player invoker in lasersPlacingInvokers)
        {
            invoker.AddLaserPlacingListener(listener);
        }
    }

    // PlayHit Event
    static List<PlayButton> playHitInvokers = new List<PlayButton>();
    static List<UnityAction<Menus, int>> playHitListener = new List<UnityAction<Menus, int>>();

    public static void AddPlayHitInvokers(PlayButton invoker)
    {
        playHitInvokers.Add(invoker);
        foreach (UnityAction<Menus, int> listener in playHitListener)
        {
            invoker.AddPlayHitListener(listener);
        }
    }

    public static void AddPlayHitListeners(UnityAction<Menus, int> listener)
    {
        playHitListener.Add(listener);
        foreach (PlayButton invoker in playHitInvokers)
        {
            invoker.AddPlayHitListener(listener);

        }
    }

    // Health Event
    static List<Player> loseHealthInvokers = new List<Player>();
    static List<UnityAction<int>> loseHealthListeners = new List<UnityAction<int>>();

    public static void AddLoseHealthInvokers(Player invoker)
    {
        loseHealthInvokers.Add(invoker);
        foreach (UnityAction<int> listener in loseHealthListeners)
        {
            invoker.AddHealthListener(listener);
        }
    }

    public static void AddLoseHealthListeners(UnityAction<int> listener)
    {
        loseHealthListeners.Add(listener);
        foreach (Player invoker in loseHealthInvokers)
        {
            invoker.AddHealthListener(listener);

        }
    }

    // LosePoints Event
    static List<Points> losePointsInvokers = new List<Points>();
    static List<UnityAction<int>> losePointsListeners = new List<UnityAction<int>>();

    public static void AddLosePointsInvoker(Points invoker)
    {
        losePointsInvokers.Add(invoker);
        foreach (UnityAction<int> listener in losePointsListeners)
        {
            invoker.AddLosePointsListeners(listener);
        }
    }

    public static void AddLosePointsListener(UnityAction<int> listener)
    {
        losePointsListeners.Add(listener);
        foreach (Points invoker in losePointsInvokers)
        {
            invoker.AddLosePointsListeners(listener);

        }
    }

    // GainPoints Event
    static List<Laser> gainPointsInvokers = new List<Laser>();
    static List<UnityAction<int>> gainPointsListeners = new List<UnityAction<int>>();

    public static void AddGainPointsInvokers (Laser invoker)
    {
        gainPointsInvokers.Add(invoker);
        foreach (UnityAction<int> listener in gainPointsListeners)
        {
            invoker.AddGainPointsListener(listener);
        }
    }

    public static void AddGainPointsListener(UnityAction<int> listener)
    {
        gainPointsListeners.Add(listener);
        foreach (Laser invoker in gainPointsInvokers)
        {
            invoker.AddGainPointsListener(listener);

        }
    }

    // GainPoints Event
    static List<HUD> gameOverInvokers = new List<HUD>();
    static List<UnityAction<Menus, int>> gameOverListeners = new List<UnityAction<Menus, int>>();

    public static void AddGameOverInvoker(HUD invoker)
    {
        gameOverInvokers.Add(invoker);
        foreach (UnityAction<Menus, int> listener in gameOverListeners)
        {
            invoker.AddGameOverListener(listener);
        }
    }

    public static void AddGameOverListener(UnityAction<Menus, int> listener)
    {
        gameOverListeners.Add(listener);
        foreach (HUD invoker in gameOverInvokers)
        {
            invoker.AddGameOverListener(listener);

        }
    }

}
