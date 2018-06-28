using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Points : MonoBehaviour {

    LosePoints losePointsEvent = new LosePoints();

	// Use this for initialization
	void Start () {
        EventManager.AddLosePointsInvoker(this);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {
        losePointsEvent.Invoke(GameConstants.EnemyDamage);
    }

    // event related scripts

    public void AddLosePointsListeners(UnityAction<int> listener)
    {
        losePointsEvent.AddListener(listener);
    }
}
