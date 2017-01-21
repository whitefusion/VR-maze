using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{

    public void ResetScene(string sceneName) 
	{
        // Reset the scene when the user clicks the sign post
        SceneManager.LoadScene(sceneName);
	}
}