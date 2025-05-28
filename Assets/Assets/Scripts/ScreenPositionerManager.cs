using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenPositionerManager : MonoBehaviour
{
    public void MoveTheScreen(int index)
    {
        switch(index)
        {
            case 0:
                gameObject.transform.position = new Vector3(5.7f, 0, 0);
                break;
            case 1:
                gameObject.transform.position = Vector3.zero;
                break;
            case 2:
                gameObject.transform.position = new Vector3(-5.7f, 0, 0);
                break;

        };
    }

}
