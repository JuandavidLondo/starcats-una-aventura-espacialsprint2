using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    public GameObject Balaa;
    public float fireRate = 0.5f;
    float NextRate = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > NextRate)
        {
            NextRate = Time.time + fireRate;
            fire();
        }
    }
    void fire()
    {
        Instantiate(Balaa, transform.position, Quaternion.identity);
    }
    
}
