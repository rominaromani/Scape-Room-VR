using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CajonSimple : MonoBehaviour
{
    [Header("Settings")]
    public float speed = 1.0f;
    public Vector3 posAbierto;
    public float distancia = 0.8f;

    [Header("Informativo")]

    bool abierto = false;
    bool abriendo = false;
    bool cerrando = false;
    Vector3 posCerrado;
    
    void Start()
    {
        posCerrado = transform.localPosition;
        posAbierto = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + distancia);
    }

    void Update()
    {
        if (abriendo)
        {
           transform.localPosition = Vector3.Lerp(transform.localPosition, posAbierto, Time.deltaTime * speed);
            if(Vector3.Distance(transform.localPosition, posAbierto) < 0.001f)
            {
                abriendo = false;
                abierto = true;
            }
        }

        if (cerrando)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, posCerrado, Time.deltaTime * speed);
            if (Vector3.Distance(transform.localPosition, posCerrado) < 0.001f)
            {
                cerrando = false;
                abierto = false;
            }
        }
    }

    public void AbreCierra()
    {
        if (!abierto)
        {
            abriendo = true;
        }
        else
        {
           cerrando = true;
        }
    }
}
