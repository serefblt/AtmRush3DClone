using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public Transform _connectedNode;




    private void FixedUpdate()
    {
        transform.position = new Vector3(Mathf.Lerp(transform.position.x, _connectedNode.position.x, Time.deltaTime * 10), 0.94f, _connectedNode.position.z + 1);
    }
}
