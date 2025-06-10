using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowManager : MonoBehaviour
{
    public GameObject[] profiles;
    
    public void SetTheProfile(int profileIndex)
    {
        foreach (GameObject profile in profiles)
        {
            profile.SetActive(false);
        }
        profiles[profileIndex].SetActive(true);
    }

}
