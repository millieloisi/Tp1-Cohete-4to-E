using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonScript : MonoBehaviour
{
    public GameObject botonGO;
    public CoheteScript coheteScript;

    private void OnMouseDown()
    {
        botonGO.SetActive(false);
        coheteScript.Despegue();
    }

    private void OnMouseUp()
    {
        botonGO.SetActive(true);
    }
}
