using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showerScript : MonoBehaviour
{
    [SerializeField] private GameObject shower;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(shower);
    }
}
