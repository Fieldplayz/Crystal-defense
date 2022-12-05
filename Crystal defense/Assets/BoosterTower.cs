using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoosterTower : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Ballista" || other.gameObject.tag == "Turret")
        {
            Debug.Log("Tower spotted");
        }
    }
}
