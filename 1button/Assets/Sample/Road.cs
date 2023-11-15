using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public bool Time;
    string mytag ;
    Collider mycollider;
    // Start is called before the first frame update
    void Start()
    {
        Time = true;
        mytag = this.gameObject.tag;
        mycollider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Change");
            Time = !Time;
        }
        if (mytag == "Light")
        {
            mycollider.isTrigger = !Time;
            GetComponent<Renderer>().enabled = Time;
        }
        if (mytag == "Dark")
        {
            mycollider.isTrigger = Time;
            GetComponent<Renderer>().enabled = !Time;
        }
    }

    public void Change()
    {
        Time = !Time;
    }
}
