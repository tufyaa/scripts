using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LightMode : MonoBehaviour
{
    public void PlayGameRest()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1 );
}
}
