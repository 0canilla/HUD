using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotemController : MonoBehaviour
{
    public bool damage = false;
    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (damage == true)
        {
            time += Time.deltaTime;
            if (time > 1)
            {
                Debug.Log("ahora");
                damage = false;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)  
    {
        if (collision.gameObject.tag == "Player")
        {
            damage = true;   
        }
       
    }
}
