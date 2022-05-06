using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public void GoMain()
    {
        SceneManager.LoadScene(0);
    }
    public void GoPunto1()
    {
        SceneManager.LoadScene(1);
    }
}
