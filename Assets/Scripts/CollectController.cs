using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectController : MonoBehaviour
{
    //public static float _score;
    //[SerializeField] Text _scoreText;

    //private void Update()
    //{
    //    _scoreText.text = _score.ToString();
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("money"))
        {
            other.gameObject.transform.position = transform.position + Vector3.forward;
           Destroy( gameObject.GetComponent<CollectController>());
            other.gameObject.AddComponent<CollectController>();
            other.gameObject.GetComponent<BoxCollider>().isTrigger = false;
            other.gameObject.AddComponent<NodeMovement>();
            other.gameObject.GetComponent<NodeMovement>()._connectedNode = transform;
            //other.gameObject.tag = "Dolar";
            //_score++;
            //_scoreText.text = _score.ToString();
        }
        if (other.gameObject.CompareTag("GoldMoney"))
        {
            other.gameObject.transform.position = transform.position + Vector3.forward;
        }
        if (other.gameObject.CompareTag("ElmasMoney"))
        {
            other.gameObject.transform.position = transform.position + Vector3.forward;
        }

    }
}
