using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverHUD : MonoBehaviour {

    [SerializeField]
    Text points;
    string pointsPrefix = "Points: ";

    int pointsValue;

	void Awake () {

        pointsValue = GameObject.FindGameObjectWithTag("Menu Manager").GetComponent<MenuManager>().Points;
        points.text = pointsPrefix + pointsValue;
	}
	
}
