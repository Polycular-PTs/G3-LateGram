using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoHolder : MonoBehaviour
{
    public string info;
    public InfoMode infoModeChecker;

    [SerializeField] GameObject clickedIndicator;
    private void OnMouseDown()
    {
       if (infoModeChecker.isItActive)
        {
            clickedIndicator.SetActive(true);

            if (gameObject.tag == "lowerInfo")
            {
                infoModeChecker.toCheckInfo = info;
            }
            else if (gameObject.tag == "upperInfo")
            {
                infoModeChecker.correctInfo = info;
            }
        }
    }
}
