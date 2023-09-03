using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    
    public Renderer rend;
    private int i;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        
        if (gameObject.CompareTag("Blue"))
        {
            Random.Range(150, 251); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

        if (gameObject.CompareTag("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }

        if (gameObject.CompareTag("Blue") && i >= 150 && i <= 250)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }

    }
}
