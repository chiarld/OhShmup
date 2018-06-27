using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour {

    Rigidbody2D rb2d;
    BoxCollider2D bc2d;

    // movement support
    Vector3 position = new Vector3();

    // shooting support
    PlayerShoot playerShootEvent = new PlayerShoot();
    LasersReady lasersReadyEvent = new LasersReady();
    LasersPlacing lasersPlacingEvent = new LasersPlacing();

    Vector3 laserPosition = new Vector3();
    GameObject laser;
    bool currentlyShooting = false;

    // health support
    int health;


	// Use this for initialization
	void Start () {

        // movement support
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();
        position = transform.position;

        // shooting support
        EventManager.AddPlayerShootInvoker(this);
        EventManager.AddLaserReadyInvoker(this);
        EventManager.AddLasersPlacingInvoker(this);
        lasersReadyEvent.Invoke(LaserPosition());

        lasersPlacingEvent.Invoke(LaserPosition());

        // health support
        health = GameConstants.PlayerHealth;
	}
	
	// Update is called once per frame
	void Update () {
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            playerShootEvent.Invoke();
            currentlyShooting = true;
        }
        if(GameObject.FindGameObjectWithTag("Laser") == null)
        {
            lasersPlacingEvent.Invoke(LaserPosition());
            currentlyShooting = false;
        }

	}

    private void FixedUpdate()
    {
        
        // move up and down (arrow keys and w/s)
        float verticalMovement = Input.GetAxis("Vertical");

        if(verticalMovement != 0)
        {
            position = transform.position;
            position.y += GameConstants.PlayerSpeed * verticalMovement * Time.deltaTime;
            transform.position = position;
        }

        if (GameObject.FindGameObjectWithTag("Laser") != null && currentlyShooting == false)
        {
            lasersReadyEvent.Invoke(LaserPosition());
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Green Goo"))
        {
            
            health -= 100;
            Destroy(collision.gameObject);

            Debug.Log("Current Health: " + health);

        }
    }

    // event related methods

    Vector3 LaserPosition()
    {
        laserPosition = position;
        laserPosition.x += bc2d.size.x / 2;
        return laserPosition;
    }

    // event listener methods

    public void AddPlayerShootListener(UnityAction listener)
    {
        playerShootEvent.AddListener(listener);
    }

    public void AddLaserReadyListener(UnityAction<Vector3> listener)
    {
        lasersReadyEvent.AddListener(listener);
    }

    public void AddLaserPlacingListener(UnityAction<Vector3> listener)
    {
        lasersPlacingEvent.AddListener(listener);
    }

}
