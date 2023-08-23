using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Interact : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI itemDescription;
    [SerializeField] private float maxDistance = 2f;
    [SerializeField] private KeyCode interactKey = KeyCode.E;

    private void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position,transform.forward,out hit, maxDistance,LayerMask.GetMask("Interact")))
        {
            itemDescription.text = "[" + hit.transform.GetComponent<Interactable>().itemDescription + "]";
            if (Input.GetKeyDown(interactKey))
            {
                if(hit.collider.gameObject.CompareTag("PilotSeat"))
                {
                    hit.collider.GetComponent<Pilot>().SwitchViews(true);
                }
            }
        }
        else
        {
            itemDescription.text = "";
        }
    }

}
