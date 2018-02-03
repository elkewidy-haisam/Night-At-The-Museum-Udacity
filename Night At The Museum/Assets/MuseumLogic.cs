using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuseumLogic : MonoBehaviour {

    public GameObject player;
    public GameObject eventSystem;
    public GameObject startPoint;

    public GameObject firstVideoUI;
    public GameObject secondVideoUI;
    public GameObject thirdVideoUI;
    public GameObject fourthVideoUI;



    // Use this for initialization
    void Start () {

        player = player.transform.parent.gameObject;

        player.transform.position = startPoint.transform.position;

        eventSystem.SetActive(true);


    }
	
	// Update is called once per frame
	void Update () {

     

    }

    public void MoveToWaypoint()
    {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Debug.Log("Attempting to define object of contact.");
        if (Physics.Raycast(ray, out hit))
        {

            Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.gameObject.name == "Cube")
            {
                Debug.Log("Object of contact is a cube.");
                GameObject gameObjectCollider = hit.collider.gameObject;
                iTween.MoveTo(player,
                           iTween.Hash(
                               "position", gameObjectCollider.transform.position,
                               "time", 10
                           ));
            }

        }
    }

    public void ToggleFirstUI()
    {

        firstVideoUI.SetActive(!firstVideoUI.activeSelf);
        
    }

    public void ToggleSecondUI()
    {

        secondVideoUI.SetActive(!secondVideoUI.activeSelf);

    }

    public void ToggleThirdUI()
    {

        thirdVideoUI.SetActive(!thirdVideoUI.activeSelf);

    }

    public void ToggleFourthUI()
    {

        fourthVideoUI.SetActive(!fourthVideoUI.activeSelf);

    }
}
