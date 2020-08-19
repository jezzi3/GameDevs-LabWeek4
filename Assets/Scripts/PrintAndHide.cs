using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i;
    int rand;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ": " + i);
        i++;
        
        if(i == 100 && gameObject.tag.Equals("Red"))
        {
            gameObject.SetActive(false);
        } else if (i == rand && gameObject.tag.Equals("Blue"))
        {
            rend.enabled = false;
        }
    }
}
