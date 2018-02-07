
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnButtonControl : MonoBehaviour {

	public void OpenBaseScene()
    {
        SceneManager.LoadScene("Splash");
    }
}
