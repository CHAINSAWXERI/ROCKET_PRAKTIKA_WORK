using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveWithDelay : MonoBehaviour
{
    [SerializeField] private GameObject ObjectWithDelay;
    public void SetActiveDelay(float delay)
    {
        Invoke("Delay", delay);
    }

    private void Delay()
    {
        ObjectWithDelay.SetActive(true);
    }
}
