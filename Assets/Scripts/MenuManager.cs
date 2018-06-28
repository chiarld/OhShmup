using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    
    Dictionary<Menus, string> menuSelection = new Dictionary<Menus, string>();
    int points = 0;

    public int Points
    {
        get { return points; }
    }

    private void Awake()
    {
        menuSelection.Add(Menus.Start, "startmenu");
        menuSelection.Add(Menus.Playing, "ohshmup");
        menuSelection.Add(Menus.End, "endmenu");

    }
    // Use this for initialization
    void Start () {
        EventManager.AddPlayHitListeners(ChangeMenu);
        EventManager.AddGameOverListener(ChangeMenu);
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	}

    void ChangeMenu(Menus menu, int pointsAchieved)
    {
        points = pointsAchieved;
        SceneManager.LoadScene(menuSelection[menu]);                   
    }

}
