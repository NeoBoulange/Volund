using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Active_Anchor_Point : MonoBehaviour
{
    public List<GameObject> AvailableAP;
    public int ID;
    [SerializeField]
    private GameObject teleportationCollider;
    private GameObject Player;
    private bool checker = false;
    public bool isOnTP = false;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        IsPlayerOnTP();
        UnshowAnchorPoints();
        ShowAnchorPoints();
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            Player.GetComponent<IDTracker>().playerID = ID;
            checker = true;
        }
    }

    public void IsPlayerOnTP()
    {
        if (Player.GetComponent<IDTracker>().playerID == ID)
        {
            isOnTP = true;
        }

        else if (Player.GetComponent<IDTracker>().playerID != ID)
        {
            isOnTP = false;
        }
    }

    public void UnshowAnchorPoints()
    {
        if (!isOnTP && checker == true)
        {
            foreach(GameObject Anchorpoint in AvailableAP)
            {
                Anchorpoint.SetActive(false);
            }
            teleportationCollider.GetComponent<MeshRenderer>().enabled = true;
            teleportationCollider.GetComponent<CapsuleCollider>().enabled = true;
            checker = false;
        }
    }
    public void ShowAnchorPoints()
    {
        if (isOnTP)
        {
            foreach (GameObject Anchorpoint in AvailableAP)
            {
                Anchorpoint.SetActive(true);
            }
            teleportationCollider.GetComponent<MeshRenderer>().enabled = false;
            teleportationCollider.GetComponent<CapsuleCollider>().enabled = false;
            checker = true;
        }
    }

}
