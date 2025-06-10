using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Reflection;

public class SearchBar : MonoBehaviour
{
    public string[] levelIDS;
    public GameObject[] level;

    private bool resetBool;
    private void Update()
    {
        foreach (string ID in levelIDS)
        {
            if (gameObject.GetComponent<TextMeshProUGUI>().text.Contains(ID))
            {
                level[Array.IndexOf(levelIDS, ID)].SetActive(true);
                resetBool = true;
            }
            else if (resetBool == true)
            {
                foreach (GameObject toReset in level)
                {
                    toReset.SetActive(false);
                }
                resetBool = false;
            }


        }
    }
}
