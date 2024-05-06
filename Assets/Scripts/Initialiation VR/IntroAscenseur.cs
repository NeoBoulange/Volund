using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroAscenseur : MonoBehaviour
{
    [SerializeField]
    private GameObject xrOrigin;
    [SerializeField]
    private GameObject teleportationPoints;
    [SerializeField]
    private GameObject canvasStart;
    [SerializeField]
    private GameObject canvasTutorial;
    [SerializeField]
    private GameObject soundOuputA;
    [SerializeField]
    private GameObject soundOuputB;

    private Animator animator;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    public void StartTheGame()
    {
        animator.SetTrigger("Game Start");
        canvasStart.SetActive(false);
        canvasTutorial.SetActive(false);
    }

    public void ElevatorGoingDown()
    {
        soundOuputA.SetActive(true);
        soundOuputB.SetActive(true);
    }

    private void FreeThePlayer()
    {
        xrOrigin.transform.parent = null;
        teleportationPoints.SetActive(true);
    }
}
