using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int frameCounter = 3;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        frameCounter = frameCounter + 1;
        Debug.Log(gameObject.name + ":" + frameCounter);

        if (gameObject.CompareTag("Red") && frameCounter >= 100)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.CompareTag("Blue") && (frameCounter >= 150 && frameCounter <= 250))
        {
            rend.enabled = false;
        }
    }
}
