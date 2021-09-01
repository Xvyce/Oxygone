using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NextText : MonoBehaviour
{
    public Text TutorialText;
    int counter = 0;
    void Start()
    {

        TutorialText.text = "Use the [WASD Keys] or the [Arrow Keys] for moving the character.";
        //You are trying\nto save the last remaining trees on Earth.\nThe 3 items below are the needs for the trees\nto survive in the horrid environment.";
    }

    public void NextT()
    {
        ++counter;

        if(counter == 0)
        {
            TutorialText.text = "Use the [WASD Keys] or the [Arrow Keys] for moving the character.";
        }

        else if(counter == 1)
        {
            TutorialText.text = "Press [Spacebar] near 1 of the 3 items: The Watering Can, The Pesticide, and The Fertilizer, to receive it.";
        }

        else if (counter == 2)
        {
            TutorialText.text = "Give the needed item to the tree by pressing [Spacebar] again to improve the environment (Health Bar).";
        }

        else if (counter == 3)
        {
            TutorialText.text = "If not given on time, the tree will permanently die and the Health Bar will decrease faster.";
        }

        else if (counter == 4)
        {
            TutorialText.text = "And giving the wrong item will decrease the Health Bar a bit.";
        }

        else if (counter == 5)
        {
            TutorialText.text = "Repeat the process to earn a lot of points before the Health Bar runs out.";
        }

        else if (counter == 6)
        {
            TutorialText.text = "Make and highest score and have fun!.";
        }

        else if (counter == 7)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void PrevT()
    {
        --counter;

        if(counter < 0)
        {
            counter = 0;
            TutorialText.text = "Use the [WASD Keys] or the [Arrow Keys] for moving the character.";
        }
        else if (counter == 0)
        {
            TutorialText.text = "Use the [WASD Keys] or the [Arrow Keys] for moving the character.";
        }

        else if (counter == 1)
        {
            TutorialText.text = "Press [Spacebar] near 1 of the 3 items: The Watering Can, The Pesticide, and The Fertilizer, to receive it.";
        }

        else if (counter == 2)
        {
            TutorialText.text = "Give the needed item to the tree by pressing [Spacebar] again to improve the environment (Health Bar).";
        }

        else if (counter == 3)
        {
            TutorialText.text = "If not given on time, the tree will permanently die and the Health Bar will decrease faster.";
        }

        else if (counter == 4)
        {
            TutorialText.text = "And giving the wrong item will decrease the Health Bar a bit.";
        }

        else if (counter == 5)
        {
            TutorialText.text = "Repeat the process to earn a lot of points before the Health Bar runs out.";
        }

        else if (counter == 6)
        {
            TutorialText.text = "Make and highest score and have fun! (Pressing next will lead to the gameplay).";
        }

    }
}
