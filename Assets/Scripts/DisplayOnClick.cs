using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayOnClick : MonoBehaviour
{
    private List<GameObject> allChildren = new List<GameObject>();
    private int currentID;
    private bool blDisplayAllOn;

    void Start()
    {
        print(transform.childCount.ToString());

        currentID = 0;
        blDisplayAllOn = false;

        for (int i = 0; i < transform.childCount; i++)
        {
            GameObject currentChild = transform.GetChild(i).gameObject;
            allChildren.Add(currentChild);
            //currentChild.GetComponent<MeshRenderer>().enabled = false;
            currentChild.SetActive(false);
        }
    }

    public void ToggleDisplayAllOnClick()
    {
        blDisplayAllOn = !blDisplayAllOn;

        if (blDisplayAllOn)
        {
            for (int i = 0; i < allChildren.Count; i++)
            {
                //allChildren[i].GetComponent<MeshRenderer>().enabled = true;
                allChildren[i].SetActive(true);
            }
        }
        else
        {
            for (int i = 0; i < allChildren.Count; i++)
            {
                //allChildren[i].GetComponent<MeshRenderer>().enabled = false;
                allChildren[i].SetActive(false);
            }
            for (int i = 0; i < currentID; i++)
            {
                //allChildren[i].GetComponent<MeshRenderer>().enabled = true;
                allChildren[i].SetActive(true);
            }
        }
    }

    public void GrowOnClick()
    {
        for (int i = 0; i < allChildren.Count; i++)
        {
            //allChildren[i].GetComponent<MeshRenderer>().enabled = false;
            allChildren[i].SetActive(false);
        }

        //print(currentID.ToString());

        if (currentID < allChildren.Count)
        {
            currentID++;
            for (int i = 0; i < currentID; i++)
            {
                //allChildren[i].GetComponent<MeshRenderer>().enabled = true;
                allChildren[i].SetActive(true);
            }
        }
        else
        {
            currentID = 0;
        }
    }

    public void GoBackOnClick()
    {
        for (int i = 0; i < allChildren.Count; i++)
        {
            //allChildren[i].GetComponent<MeshRenderer>().enabled = false;
            allChildren[i].SetActive(false);
        }

        //print(currentID.ToString());

        if (currentID > 0)
        {
            for (int i = 0; i < currentID; i++)
            {
                //allChildren[i].GetComponent<MeshRenderer>().enabled = true;
                allChildren[i].SetActive(true);
            }
            currentID--;
        }
        else
        {
            currentID = allChildren.Count;
        }

    }

}

