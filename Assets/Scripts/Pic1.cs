using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pic1 : MonoBehaviour
{

    int counter = 0;
   

    public void NextSlide()
    {
        ++counter;

        if (counter == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;

        }
        else if (counter != 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }



    }

    public void PrevSlide()
    {
        
        --counter;

        if (counter == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;

        }
        else if (counter < 0)
        {
            counter = 0;
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            
            
        }
        else if (counter != 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }

    }
}
