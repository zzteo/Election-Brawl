using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectingCharacter : MonoBehaviour
{
   

    public int currentSelection;

    [SerializeField]
    private int playerIndex = 0;

    public int GetPlayerIndex()
    {
        return playerIndex;
    }

    private void Start()
    {
        currentSelection = 0;
        Selecting();
    }

    public void Selecting()
    {
        //limits the options to the number of characters available
        if (currentSelection < 0)
        {
            currentSelection = 0;
        }
        else if (currentSelection > transform.childCount - 1)
        {
            currentSelection = transform.childCount - 1;
        }

        //selects the corresponding character
        switch (currentSelection)
        {
            case 0:

                StartCoroutine(fistCharacter());
                break;

            case 1:
                StartCoroutine(secondCharacter());
                break;

        }
    }
    
    private IEnumerator fistCharacter()
    {
        //waits 1 second before the curtains close and open again while selecting
        yield return new WaitForSeconds(1f);
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
    
    }
    private IEnumerator secondCharacter()
    {
        yield return new WaitForSeconds(1f);
        transform.GetChild(1).gameObject.SetActive(true);
        transform.GetChild(0).gameObject.SetActive(false);

    }
}
