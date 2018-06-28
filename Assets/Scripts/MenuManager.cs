using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {
    
    Dictionary<Menus, string> menuSelection = new Dictionary<Menus, string>();

    private void Awake()
    {
        menuSelection.Add(Menus.Start, "startmenu");
        menuSelection.Add(Menus.Playing, "ohshmup");

    }
    // Use this for initialization
    void Start () {
        EventManager.AddPlayHitListeners(ChangeMenu);
        DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	}

    void ChangeMenu(Menus menu)
    {
        SceneManager.LoadScene(menuSelection[menu]);                   
    }

}
