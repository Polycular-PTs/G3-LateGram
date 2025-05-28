using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractScreenMove : MonoBehaviour
{
    [SerializeField] ScreenPositionerManager SPM;
    [SerializeField] int indexInteract;

    private void OnMouseDown()
    {
        SPM.MoveTheScreen(indexInteract);
    }
}
