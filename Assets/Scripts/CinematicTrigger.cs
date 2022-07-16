using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicTrigger : MonoBehaviour
{
    [SerializeField] GameObject cinematicCamera;
    [SerializeField] GameObject cutscene;
    [SerializeField] GameObject fpsController;

    private void OnTriggerEnter(Collider other)
    {
        fpsController.SetActive(false);
        cinematicCamera.SetActive(true);
        cutscene.SetActive(true);
    }

}
