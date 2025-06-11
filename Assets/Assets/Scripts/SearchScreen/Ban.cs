using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ban : MonoBehaviour
{
    [SerializeField] bool realProfile;
    [SerializeField] GameObject scribble;
    private void OnMouseDown()
    {
        if (realProfile == false)
        {
            scribble.SetActive(true);
        }
        if (realProfile == true)
        {
            SceneManager.LoadScene(0);
        }
    }
}
