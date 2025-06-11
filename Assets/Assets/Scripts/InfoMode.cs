using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InfoMode : MonoBehaviour
{
    private bool check;

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

            foreach (GameObject indicator in indicators)
            {
                indicator.SetActive(false);
            }

            correctInfo = "";
            toCheckInfo = "";
            isItActive= false;
            check = false;
        }
    }
    private void Update()
    {
        
        if (correctInfo != "" && toCheckInfo != "" && check == false)
        {
            if (correctInfo.Contains(toCheckInfo))
            {
                Debug.Log("Yo die Info passt");
                check = true;
            }
            else
            {
                Debug.Log("Nö da stimmt was ned...");
                check = true;
            }

        }
    }

   


}
