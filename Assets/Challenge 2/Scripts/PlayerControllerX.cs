using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float timer;
    private bool canSpawn=true;
    public float spawnInterval=2.0f;
    void Start(){
        timer=spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (canSpawn && Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawn=false;
        }
        if(!canSpawn){
            timer-=Time.deltaTime;
            if(timer < 0){
                timer=spawnInterval;
                canSpawn=true;
            }
        }
    }
}
