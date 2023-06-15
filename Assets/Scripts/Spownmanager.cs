using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spownmanager : MonoBehaviour
{
    public GameObject[] obstaclePrefab;
    private Vector3 spownPos= new Vector3(25, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
        InvokeRepeating("ObstacleSpown", startDelay,repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ObstacleSpown()
    {
        if(playerControllerScript.gameover==false)
        {
            int index = Random.Range(0, obstaclePrefab.Length);
            Instantiate(obstaclePrefab[index], spownPos, obstaclePrefab[index].transform.rotation);

        }
    }
}
