using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractScreenMove : MonoBehaviour
{
    [SerializeField] ScreenPositionerManager SPM;
    [SerializeField] int indexInteract;
    [SerializeField] int profileIndex;

    private ShowManager sManager;

    private void Start()
    {
        sManager = GameObject.FindGameObjectWithTag("sManager").GetComponent<ShowManager>();
    }
    private void OnMouseDown()
    {
        SPM.MoveTheScreen(indexInteract);
        if (gameObject.tag == "profileIndicator")
        {
            sManager.SetTheProfile(profileIndex);
        }
    }
}
