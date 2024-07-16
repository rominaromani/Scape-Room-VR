using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Vector3 newCameraPosition; 
    //le asigno el objeto que quiero que se mueva 
    public GameObject camera;

    void Start()
    {

    }

    public void MoveCameraPosition()
    {
        camera.transform.position = newCameraPosition;
    }
}
