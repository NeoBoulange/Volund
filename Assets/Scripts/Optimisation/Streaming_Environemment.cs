using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Streaming_Environemment : MonoBehaviour
{
    public List<GameObject> toLoad;
    [SerializeField]
    private Active_Anchor_Point anchorPoint;
    private bool safety = true;

    void Update()
    {
        if (anchorPoint.isOnTP == false && safety == false)
        {
            UnloadSector();
        }
       
        else if (anchorPoint.isOnTP == true)
        {
            LoadSector();
        }
    }

    private void LoadSector()
    {
        foreach (GameObject objects in toLoad)
        {
            objects.SetActive(true);
            safety = false;
        }
    }

    private void UnloadSector()
    {
        foreach (GameObject objects in toLoad)
        {
            objects.SetActive(false);
            safety = true;
        }
    }
}
