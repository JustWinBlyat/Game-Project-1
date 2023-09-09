using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //Enemy Movement:
    [SerializeField]
    private float speed = 3.0f;

    //Enemy Component:
    private Rigidbody enemyRigidbody;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        GetEnemyRigidbody();
        GetPlayerObject();
    }

    // Update is called once per frame
    void Update()
    {
        ChasePlayer();
    }

    void ChasePlayer()
    {
        Vector3 lookDirection = ((player.transform.position - transform.position).normalized);
        enemyRigidbody.AddForce(lookDirection * speed);
    }

    //Gets enemy rigidbody component
    void GetEnemyRigidbody()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
    }

    //Gets player object reference
    void GetPlayerObject()
    {
        player = GameObject.Find("Player");
    }
}
