using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i;
    int randI;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        randI = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i = i + 1;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.tag == "Red" && i == 100)
        {

            gameObject.SetActive(false);

        }else if(gameObject.tag == "Blue" && i == randI)
        {

            gameObject.SetActive(false);

        }
    }
}
