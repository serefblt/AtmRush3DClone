using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform _connectedNode;

  


    private void Update()
    {


        transform.position = new Vector3(Mathf.Lerp(transform.position.x, _connectedNode.position.x, Time.deltaTime * 10), _connectedNode.position.y, _connectedNode.position.z + 1);

        
    }
}
