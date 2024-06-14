using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class SelectedObject : MonoBehaviour
{
    public string gameSide;
    public GameObject DrawingGame;
    public GameObject ShootingGame;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(gameSide == "Left")
            {
                DrawingGame.SetActive(false);
            }
            else if (gameSide == "Right")
            {
                ShootingGame.SetActive(false);
            }
        }
    }
}
