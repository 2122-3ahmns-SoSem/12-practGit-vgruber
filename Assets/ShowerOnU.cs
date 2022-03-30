using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowerOnU : showerScript
{
    public GameObject dusche;
    public override void Hit()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
        dusche.SetActive(true);
    }
}
