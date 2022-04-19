using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stats : MonoBehaviour
{
    public void da()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5 );
    }
}
