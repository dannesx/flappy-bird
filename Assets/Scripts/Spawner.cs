using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float timer;
    public float amplitude;
    private float currentTime = 0f;

    void Start(){
        Spawn();
    }

    void FixedUpdate(){
        currentTime += Time.deltaTime;

        if(currentTime > timer){
            Spawn();
            currentTime = 0f;
        }
    }

    void Spawn(){
        float randomY = Random.Range(-amplitude, amplitude);
        Vector3 position = new Vector3(transform.position.x, randomY, 0f);
        Instantiate(prefab, position, transform.rotation);
    }
}
