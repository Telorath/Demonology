using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartButtonActivate : MonoBehaviour {


    public void Activate()
    {
        SceneManager.LoadScene("BattleScene");
    }

}
