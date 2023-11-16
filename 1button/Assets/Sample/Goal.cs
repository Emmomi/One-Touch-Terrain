using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public static int counter = 0;
    public AudioSource Goal_bgm;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Toy")
        {
            Goal_bgm.Play();
            counter++;
        }
    }

    public static int Score()
    {
        return counter;
    }
}
