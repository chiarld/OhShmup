using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class HUD : MonoBehaviour {

    [SerializeField]
    Text healthText;
    [SerializeField]
    Text pointsText;

    string healthPrefix = "Health: ";
    string pointsPrefix = "Points: ";

    int playerHealth = GameConstants.PlayerHealth;
    int currentPoints = 0;

    GameOver gameOverEvent = new GameOver();
    Menus goToMenu = Menus.End;

	// Use this for initialization
	void Start () {

        // health setup
        EventManager.AddLoseHealthListeners(UpdateHealth);
        healthText.text = "Health: 1000";

        // points setup
        EventManager.AddLosePointsListener(LosePoints);
        EventManager.AddGainPointsListener(GainPoints);
        pointsText.text = "Points: 0";

        EventManager.AddGameOverInvoker(this);

	}
	
	// Update is called once per frame
	void Update () {
        if(currentPoints == -1000 || playerHealth == 0)
        {
            gameOverEvent.Invoke(goToMenu, currentPoints);
        }
	}

    void UpdateHealth(int damageTaken)
    {
        playerHealth -= damageTaken;
        healthText.text = healthPrefix + playerHealth;
    }

    void LosePoints(int damageTaken)
    {
        currentPoints -= damageTaken;
        pointsText.text = pointsPrefix + currentPoints;
    }

    void GainPoints(int pointsGained)
    {
        currentPoints += pointsGained;
        pointsText.text = pointsPrefix + currentPoints;
    }


    // event related methods
    public void AddGameOverListener(UnityAction<Menus, int> listener)
    {
        gameOverEvent.AddListener(listener);
    }


}
