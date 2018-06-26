using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGoo : MonoBehaviour {

    // movement support
    Rigidbody2D rb2d;
    BoxCollider2D bc2d;
    Vector2 unitVector = new Vector2(-1, 0);

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        bc2d = GetComponent<BoxCollider2D>();

        rb2d.AddForce(unitVector * GameConstants.GreenGooSpeed, ForceMode2D.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
