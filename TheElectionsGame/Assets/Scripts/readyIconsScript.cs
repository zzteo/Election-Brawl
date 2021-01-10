using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class readyIconsScript : MonoBehaviour
{

    public GameObject readyIconP1;

   public GameObject readyIconP2;

   
   
    public void ReadyP1()
    {
        readyIconP1.SetActive(true);
    }

    public void NotReadyP1()
    {
        readyIconP1.SetActive(false);
    }

    public void ReadyP2()
    {
        readyIconP2.SetActive(true);
    }

    public void NotReadyP2()
    {
        readyIconP2.SetActive(false);
    }

}
