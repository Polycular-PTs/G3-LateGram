using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InfoMode : MonoBehaviour
{
    public int clicksOnInfo;

    public bool isItActive;
    public string correctInfo;
    public string toCheckInfo;
    public GameObject[] indicators;

    public GameObject previousClickIndicator;

    [SerializeField] GameObject darkener;

    private void OnMouseDown()
    {

        if (isItActive == false)
        {
            darkener.SetActive(true);
            isItActive = true;
        }
        else if (isItActive == true)
        {
            darkener.SetActive(false);

            ResetAllIndicators();

            correctInfo = "";
            toCheckInfo = "";
            isItActive= false;
        }
    }

    public void ResetAllIndicators()
    {
        foreach (GameObject indicator in indicators)
        {
            indicator.SetActive(false);
        }
    }

    private void Update()
    {
        
        if (correctInfo != "" && toCheckInfo != "")
        {
            if (correctInfo.Contains(toCheckInfo))
            {
                Debug.Log("Yo die Info passt");
                correctInfo = "";
                toCheckInfo = "";
            }
            else
            {
                Debug.Log("Nö da stimmt was ned...");
                correctInfo = "";
                toCheckInfo = "";
            }

        }
        if (clicksOnInfo == 3)
        {
            ResetAllIndicators();
            clicksOnInfo = 0;
            correctInfo = "";
            toCheckInfo = "";
        }
    }

   


}
