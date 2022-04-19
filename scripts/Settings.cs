using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{
  public void set()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
}
}
