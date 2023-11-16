using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward*0.01f);
        if (transform.position.y <= -5)
        {
            Destroy(this.gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "goal")
        {
            Destroy(this.gameObject,2f);
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Right")
        {
            Debug.Log("Right");
            transform.Rotate(new Vector3(0, 90, 0));
        }
        if (collider.tag == "Left")
        {
            Debug.Log("Left");
            transform.Rotate(new Vector3(0, -90, 0));
        }
       
    }
}
