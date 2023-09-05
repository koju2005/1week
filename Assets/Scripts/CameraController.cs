using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject target;
    void LateUpdate()
    {
        Vector3 dir = target.transform.position;
        this.transform.position =new Vector3(dir.x,dir.y,-10);
    }
}
