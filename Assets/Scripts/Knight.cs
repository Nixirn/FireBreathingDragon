using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : MonoBehaviour
{
    public GameObject target;
    public float speed = 1.5f;
    public float MaxDist = 10f;
    public float MinDist = 1f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject[] player = GameObject.FindGameObjectsWithTag("Player");
        target = player[0];
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.forward = target.transform.position - transform.position;

        if (Vector3.Distance(transform.position, target.transform.position) >= MinDist)
        {

            transform.position += transform.forward * speed * Time.deltaTime;


            
            if (Vector3.Distance(transform.position, target.transform.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            }
            
        }
    }
}
