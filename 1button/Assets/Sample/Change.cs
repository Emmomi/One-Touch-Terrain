using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Toy")
        {
            switch (this.tag)
            {
                case "Right":
                    this.tag = "Left";
                    break;
                case "Left":
                    this.tag = "Right";
                    break;
            }
        }
    }
}
