using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 33;
    public float lowerBound = -14;
    public HealthManager healthManager;

    // Start is called before the first frame update
    void Start()
    {
        healthManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();
    }


    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Animal Escaped out of bounds.");
            healthManager.TakeDamage();
            Destroy(gameObject);
        }
    }
}
