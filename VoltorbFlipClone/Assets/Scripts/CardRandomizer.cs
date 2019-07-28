using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardRandomizer : MonoBehaviour
{
    TextMesh cardText;
    private void Start()
    {
        int casenum = Random.Range(0, 4);

        cardText = this.GetComponent<TextMesh>();
        switch (casenum)
        {
            case 0:
                cardText.text = "0";
                break;
            case 1:
                cardText.text = "1";
                break;
            case 2:
                cardText.text = "2";
                break;
            case 3:
                cardText.text = "3";
                break;
            default:
                Debug.Log("This case does not exist.");
                break;
        }
    }
}
