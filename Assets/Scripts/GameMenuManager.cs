using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameMenuManager : MonoBehaviour
{
    public Transform head;  // Asigna el OVRCameraRig o el CenterEyeAnchor en el Inspector
    public float spawnDistance = 2f;
    public GameObject menu;
    public InputActionProperty showButton;

    void Start()
    {
        // Inicialización si es necesaria
    }

    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
            PositionMenu();
        }

        if (menu.activeSelf)
        {
            RotateMenu();
        }
    }

    void PositionMenu()
    {
        Vector3 headPosition = head.position;
        Vector3 forwardDirection = new Vector3(head.forward.x, 0, head.forward.z).normalized;
        menu.transform.position = headPosition + forwardDirection * spawnDistance;
    }

    void RotateMenu()
    {
        Vector3 lookAtPosition = new Vector3(head.position.x, menu.transform.position.y, head.position.z);
        menu.transform.LookAt(lookAtPosition);
        menu.transform.forward *= -1;
    }
}
