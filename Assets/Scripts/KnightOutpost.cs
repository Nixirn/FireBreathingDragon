using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightOutpost : MonoBehaviour
{
    // private bool spawned;
    public GameObject knight;
    public float spawnOffset;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")            // Check if player enters the radius
        {
            Debug.Log("Collision detected with player");
            // spawned = true;
            transform.GetChild(1).Rotate(0, 90, 0);

            Vector3 doorPos = transform.position;
            Vector3 doorDirection = transform.forward;
            Quaternion doorRotation = transform.rotation;
            float spawnDistance = .5f;

            Vector3 spawnPos = doorPos + doorDirection * spawnDistance;

            GameObject go = Instantiate<GameObject>(knight, spawnPos, doorRotation);
            go.transform.Rotate(0, 90, 0);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")            // Check if player enters the radius
        {
            Debug.Log("Collision detected with player");
            // spawned = true;
            transform.GetChild(1).Rotate(0, -90, 0);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // spawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
