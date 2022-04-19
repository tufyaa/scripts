using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
public void PlayGameRest()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
}
public void ExitGame()
{
Application.Quit();
}
}
