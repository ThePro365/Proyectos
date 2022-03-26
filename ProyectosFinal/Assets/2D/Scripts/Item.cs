using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool clicked = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit;
<<<<<<< Updated upstream
        if (clicked && Physics.Raycast(castPoint, out hit, Mathf.Infinity, hitLayers))
=======
        if (clicked)
>>>>>>> Stashed changes
        {
            transform.position = hit.point;
        }
    }
}
