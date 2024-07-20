using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour
{
    [SerializeField] private TMP_Text Ans;
    [SerializeField] private string answer;
    [SerializeField] private Animator Door;
    [SerializeField] private AudioSource presionarboton ;
    [SerializeField] private AudioSource correcto ;
    [SerializeField] private AudioSource incorrecto ;
    [SerializeField] private TMP_Text abiertaCerrado; 


    public void Number(int number)
    {
        if (Ans.text == "CORRECT")
        {
            return;
        }
        if (Ans.text == "INCORRECT")
        {
            Ans.text = "";
        }

        if (Ans.text.Length < 5)
        {
            Ans.text += number.ToString();
            presionarboton.Play();
        }

    }
    // Start is called before the first frame update
    public void Execute()
    {
        if (Ans.text==answer)
        {
            Ans.text = "CORRECT";
            Door.SetBool("Open", true);
            StartCoroutine("StopDoor");
            correcto.Play();
            abiertaCerrado.text = "OPEN";
        }
        else
        {
            Ans.text = "INCORRECT";
            incorrecto.Play();
        }
    }

    public void Delete()
    {
        if (Ans.text == "CORRECT") { return; } // just ignore
        if (Ans.text == "INCORRECT") { Ans.text = ""; }
        if (Ans.text.Length > 0)
        {
            Ans.text = Ans.text.Remove(Ans.text.Length - 1);
        }
        
    }

    public void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.7f); 
        Door.SetBool("Open", false);
        Door.enabled = false;
    }
}
