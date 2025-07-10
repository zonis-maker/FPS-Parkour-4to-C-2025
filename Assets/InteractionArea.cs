using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{
    public GameObject interactionMessage;
    public MercanciaScript mercancia;

    void Start()
    {
        interactionMessage.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (mercancia && mercancia.moneyManager != null)
            {
                mercancia.moneyManager.UpdateMoney(-mercancia.cost);
                Destroy(mercancia.gameObject);
                StopInteraction();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name);
        mercancia = other.GetComponent<MercanciaScript>();

        if (mercancia)
        {
            interactionMessage.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        StopInteraction();
    }

    void StopInteraction()
    {
        interactionMessage.SetActive(false);
        mercancia = null;
    }
}
