using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollo : MonoBehaviour
{
    public float cameraSpeed;
    public float yOffset;
    public float xOffset;
    public Transform target;
    void Update()
    {
        Vector3 newPos = new Vector3(target.position.x+xOffset,target.position.y+yOffset,-10f);
        transform.position = Vector3.Slerp(transform.position,newPos,cameraSpeed*Time.deltaTime);
    }
}
