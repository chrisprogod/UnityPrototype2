using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectCollision : MonoBehaviour
{
    public AudioSource Punchsound;
    public HealthManager healthManager;
    public PointManager pointManager;
    void Start()
    {
        Punchsound = GetComponent<AudioSource>();
        healthManager = GameObject.Find("HealthManager").GetComponent<HealthManager>();
        pointManager = GameObject.Find("PointManager").GetComponent<PointManager>();
    }


private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has been hit!");
            Punchsound.Play();
            Destroy(gameObject, Punchsound.clip.length);
            healthManager.TakeDamage();
        }

        if(other.CompareTag("Steak"))
        {
            pointManager.GetPoints();
            Destroy(gameObject);
            Destroy(other.gameObject);
        }
    }
}
