using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMastor : MonoBehaviour
{
    int limit_time;
    public GameObject start;
    //public GameObject end;
    public GameObject Toy;
    public int number;
    public Text text;
    public GameObject button;
    public AudioSource eff_bgm;
    Vector3 ins_pos=new Vector3();
    int Number = 0;
    // Start is called before the first frame update
    void Start()
    {
        Number = number;
        limit_time = 0;
        ins_pos = start.transform.position;
        ins_pos.y += 1;
        button.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (limit_time % 1000 == 0&&number>0)
        {
            Instantiate(Toy, ins_pos,start.transform.rotation);
            number--;
        }
        limit_time++;
        if (GameObject.FindWithTag("Toy") == null && number <= 0)
        {
            text.text = "‰^‚×‚½”F" + Goal.Score();
            if (Goal.Score() == Number)
            {
                text.text +="\nPerfect!!!";
            }
            button.SetActive(true);
        }
    }

    public void ToTitle()
    {
        eff_bgm.Play();
        SceneManager.LoadScene("Title");
    }
}
