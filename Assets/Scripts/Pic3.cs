using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pic3 : MonoBehaviour
{
    int counter = 0;


    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

    public void NextSlide()
    {

        ++counter;
        //if (counter == 0)
        //{
        //    gameObject.GetComponent<SpriteRenderer>().enabled = false;

        //}
        
        if (counter == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;

        }
        else if (counter != 2)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }

    }

    public void PrevSlide()
    {
        --counter;

        if (counter == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;

        }
        else if (counter != 2)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;

        }

        if (counter < 0)
        {
            counter = 0;
        }


    }
}
