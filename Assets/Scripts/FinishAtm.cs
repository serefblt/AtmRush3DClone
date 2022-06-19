using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishAtm : MonoBehaviour
{
   
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("money"))
        {
        
            other.transform.SetParent(transform);
            other.transform.position = Vector3.left * 50 * Time.deltaTime;
         


        }
    }
}
