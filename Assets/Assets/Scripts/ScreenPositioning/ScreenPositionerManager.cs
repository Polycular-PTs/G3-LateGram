using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPositionerManager : MonoBehaviour
{
    public void MoveTheScreen(int index)
    {
        gameObject.GetComponent<Animator>().SetInteger("Index", 4);
        switch (index)
        {
            case 0:
                gameObject.GetComponent<Animator>().SetInteger("Index", 0);
                break;
            case 1:
                gameObject.GetComponent<Animator>().SetInteger("Index", 1);
                break;
            case 2:
                gameObject.GetComponent<Animator>().SetInteger("Index", 2);
                break;
            case 3:
                gameObject.GetComponent<Animator>().SetInteger("Index", 3);
                break;
        };
        
    }

}
