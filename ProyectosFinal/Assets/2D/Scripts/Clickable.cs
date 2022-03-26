using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickable : MonoBehaviour
{

    public Transform DroppedItem;

    public Vector3 mousePosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        DropItem();
    }

    // Update is called once per frame
    void Update()
    {
         mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    public void DropItem()
    {
        Instantiate(DroppedItem, mousePosition , Quaternion.identity);
    }
}
