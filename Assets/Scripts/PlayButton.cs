using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour {
    
    PlayHit playHitEvent = new PlayHit();
    bool playButtonExpanded = false;
    string currentScene;

    // player interaction support
    Vector3 changedScale = new Vector3();
    Vector3 normalScale = new Vector3();
    Menus goToMenu;

	// Use this for initialization
	void Start () {
        normalScale = transform.localScale;
        changedScale = normalScale;
        changedScale.x += .5f;
        changedScale.y += .5f;

        EventManager.AddPlayHitInvokers(this);

        currentScene = SceneManager.GetActiveScene().name;

        switch(currentScene)
        {
            case "startmenu":
                goToMenu = Menus.Playing;
                break;
            case "endmenu":
                goToMenu = Menus.Start;
                break;
        }
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnMouseOver()
    {
        if(!playButtonExpanded)
        {
            transform.localScale = changedScale;
            playButtonExpanded = true;
        }
    }

    private void OnMouseExit()
    {
        transform.localScale = normalScale;
        playButtonExpanded = false;
    }

    private void OnMouseDown()
    {
        playHitEvent.Invoke(goToMenu, 0);
        AudioManager.PlayAudio(Audios.ButtonPressed);
    }

    public void AddPlayHitListener(UnityAction<Menus, int> listener)
    {
        playHitEvent.AddListener(listener);
    }
}
