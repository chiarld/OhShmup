using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour {

    Rigidbody2D rb2d;
    BoxCollider2D bc2d;

    // movement support
    Vector2 unitVector = new Vector2(-1, 0);

    // shooting support
    Timer clock;
    GameObject greenGoo;
    bool gameJustStarted = true;

	// Use this for initialization
	void Start () {
        
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();

        rb2d.AddForce(unitVector * GameConstants.EnemySpeed, ForceMode2D.Impulse);

        clock = gameObject.AddComponent<Timer>();
        clock.Duration = GameConstants.EnemyShootingTime;
        clock.Run();

	}
	
	// Update is called once per frame
	void Update () {
		
        if(clock.Finished || gameJustStarted)
        {
            Shoot();
            clock.Run();
            gameJustStarted = false;
        }

	}

    void Shoot()
    {
        greenGoo = Instantiate(Resources.Load("Green Goo")) as GameObject;
        greenGoo.transform.position = transform.position;    
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}
