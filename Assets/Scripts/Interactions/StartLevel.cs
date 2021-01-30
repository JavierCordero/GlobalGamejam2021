using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum GameMode { SINGLEPLAYER, MULTIPLAYER };
public class StartLevel : MonoBehaviour
{

    public GameMode _myGameMode;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerInformation>())
        {
            if (_myGameMode == GameMode.SINGLEPLAYER)
                SceneManager.LoadScene("SinglePlayerScene");
            else
                SceneManager.LoadScene("MultiplayerScene");

        }
    }
}
