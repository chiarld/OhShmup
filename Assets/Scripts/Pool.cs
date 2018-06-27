using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour {

    // enemy pool support // 
    List<Object> enemies = new List<Object>(3);
    Object enemyPrefab;
    GameObject enemy;
    int countingEnemies;

    float yMinPosition = -4;
    float yMaxPosition = 4;
    float xPosition = 9;
    Vector2 position;

    Timer clock;
    // enemy pool support //

    // laser pool support //
    List<Object> lasers = new List<Object>(1);
    Object laserPrefab;
    GameObject laser;
    int countingLasers;
    // laser pool support //

    private void Awake()
    {
        
        // enemy pool support //
        BuildEnemyPool();
        // enemy pool support //

        // laser pool support //
        BuildLaserPoll();
        // laser pool support //

    }

    // Use this for initialization
    void Start () {

        // enemy pool support //
        enemyPrefab = Resources.Load("Enemy");
        countingEnemies = enemies.Capacity - 1;
        clock = gameObject.AddComponent<Timer>();
        clock.Duration = GameConstants.EnemySpawningTime;
        clock.Run();
        // enemy pool support //

        // laser pool support //
        laserPrefab = Resources.Load("Laser");
        countingLasers = lasers.Capacity - 1;

        EventManager.AddLasersPlacingListener(SpawnLaser);
        // laser pool support //

	}

    // enemy pool support //
    void BuildEnemyPool()
    {
        for (int i = enemies.Capacity - 1; i >= 0; i--)
        {
            enemies.Add(enemyPrefab);
        }
    }
    // enemy pool support //

    // laser pool support //
    void BuildLaserPoll()
    {
        for (int i = lasers.Capacity - 1; i >= 0; i--)
        {
            lasers.Add(enemyPrefab);
        }    
    }
    // laser pool support //


	// Update is called once per frame
	void Update () {

        // enemy pool support //
        if(countingEnemies >= 0 && clock.Finished)
        {
            position.x = xPosition;
            position.y = Random.Range(yMinPosition, yMaxPosition);
            enemy = Instantiate(enemyPrefab, position, Quaternion.identity) as GameObject;
            enemies.Remove(enemies[countingEnemies]);

            countingEnemies--;
            clock.Run();
        }
        else if(countingEnemies < 0)
        {
            BuildEnemyPool();
            countingEnemies = enemies.Capacity - 1;
        }
        // enemy pool support //

        // laser pool support //
        if(countingLasers < 0)
        {
            BuildLaserPoll();
            countingLasers = lasers.Capacity - 1;
        }
        // laser pool support //
	}

    // laser pool support //
    void SpawnLaser(Vector3 position)
    {
        laser = Instantiate(laserPrefab, position, Quaternion.identity) as GameObject;
        lasers.Remove(lasers[countingLasers]);
        countingLasers--;
    }
    // laser pool support //
}
