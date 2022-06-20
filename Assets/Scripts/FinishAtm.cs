using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishAtm : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("money"))
        {

            Destroy(other.gameObject);


        }
        if (other.gameObject.CompareTag("GoldMoney2"))
        {

            Destroy(other.gameObject);


        }
        if (other.gameObject.CompareTag("GoldMoney"))
        {

            Destroy(other.gameObject);


        }
        if (other.gameObject.CompareTag("ElmasMoney"))
        {

            Destroy(other.gameObject);


        }
      
    }

   
}
