using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {
    
    // collision support
    Rigidbody2D rb2d;
    BoxCollider2D bc2d;

    // movement support
    Vector2 unitVector = new Vector2(1, 0);
    bool laserReady = true;

	// Use this for initialization
	void Start () {

        // collision support
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();

        EventManager.AddPlayerShootListener(Shoot);
        EventManager.AddLaserReadyListener(PositionLaser);


	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    // Event related methods
    void Shoot()
    {
        rb2d.AddForce(unitVector * GameConstants.LaserSpeed, ForceMode2D.Impulse);
    }

    void PositionLaser(Vector3 position)
    {
        gameObject.transform.position = position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy") || 
           collision.gameObject.CompareTag("Green Goo"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

}
