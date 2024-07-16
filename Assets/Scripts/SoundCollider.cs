using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCollider : MonoBehaviour
{
    [SerializeField] private AudioSource touchSound;
    [SerializeField] private AudioSource CollisionSound;

    private AudioSource audioSource;

    void Start()
    {
        // Agrega un componente AudioSource si no existe y guarda la referencia
        audioSource = gameObject.AddComponent<AudioSource>();
    }

    public void OnMouseDown()
    {
        // Reproduce el sonido de toque
        touchSound.Play();

    }

    void OnCollisionEnter(Collision collision)
    {
        CollisionSound.Play();
    }

}
