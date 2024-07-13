using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class drawer : MonoBehaviour
{
    [SerializeField] private Animator Drawer;
    [SerializeField] private AudioSource abrir;
    [SerializeField] private AudioSource cerrar;
    [SerializeField] private float autoCloseDelay = 5.0f; // Tiempo en segundos antes de cerrar automáticamente

    private bool isOpen = false;

    public void Open()
    {
        if (!isOpen)
        {
            Drawer.enabled = true;
            Drawer.SetBool("Open", true);
            abrir.Play();
            isOpen = true;
            StartCoroutine(AutoCloseDrawer());
        }
    }

    public void Close()
    {
        if (isOpen)
        {
            Drawer.SetBool("Open", false);
            cerrar.Play();
            isOpen = false;
            StartCoroutine(StopDrawer());
        }
    }

    void Start()
    {
        Drawer.enabled = false;
    }

    void Update()
    {

    }

    IEnumerator AutoCloseDrawer()
    {
        yield return new WaitForSeconds(autoCloseDelay);
        Close();
    }

    IEnumerator StopDrawer()
    {
        yield return new WaitForSeconds(0.7f);
        Drawer.enabled = false;
    }
}
