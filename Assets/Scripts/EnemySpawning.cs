using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour {

    // spawning support
    float yMinPosition = -4;
    float yMaxPosition = 4;
    float xPosition = 9;
    Vector2 position;
    GameObject enemy;

    Timer clock;

	// Use this for initialization
	void Start () {
        clock = gameObject.AddComponent<Timer>();
        clock.Duration = 2f;
        clock.Run();
	}
	
	// Update is called once per frame
	void Update () {
        if(clock.Finished)
        {
            position.x = xPosition;
            position.y = Random.Range(yMinPosition, yMaxPosition);
            enemy = Instantiate(Resources.Load("Enemy")) as GameObject;
            enemy.transform.position = position;

            clock.Run();
        }
	}
}
