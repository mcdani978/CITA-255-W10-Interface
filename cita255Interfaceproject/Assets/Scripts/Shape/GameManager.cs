using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    Vector3 GetMouseWorldPosition()
    {
        Vector3 result = Input.mousePosition;

        //translate result.z to something the world can understand
        result.z = Camera.main.WorldToScreenPoint(transform.position).z;

        //Convert the entire thing to a world position
        result = Camera.main.ScreenToWorldPoint(result);

        return result;
    }
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = GetMouseWorldPosition();

            Collider2D collider2D = Physics2D.OverlapPoint(mousePos);

            if(collider2D != null)
            {
                //I clicked on a 2D collider!

                //using try get component to avoid having an object that doesn't implement Iinteract

                if(collider2D.TryGetComponent(out Iinteract interact))
                {
                    interact.Interact();
                }
            }
        }

    }
}
