using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetChecker : MonoBehaviour
{
    private GameObject myParent;
    void OnTriggerEnter2D(Collider2D col)
    {
        if(myParent && col.gameObject.tag == "Player")
        {
            myParent.GetComponent<Enemies>().DetectTarget(col.gameObject);
            Debug.Log("Player was detected");
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if(myParent && col.gameObject.tag == "Player")
        {
            myParent.GetComponent<Enemies>().DetectTarget(null);
            Debug.Log("Player missing");
        }
    }
    public void SetMyParent(GameObject parent)
    {
        myParent = parent;
    }
}
