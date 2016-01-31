using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TutorialButtonClick : MonoBehaviour {

    public void Activate()
    {
        SceneManager.LoadScene("TutorialScene");
    }

}
