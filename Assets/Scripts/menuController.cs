using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour

{
    void Start()
    {

    }

    void Update()
    {

    }

    public void StartBtn(string SceneName)
    {

    SceneManager.LoadScene(SceneName); 
    }

}
