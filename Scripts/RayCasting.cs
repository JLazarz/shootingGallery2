using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCasting : MonoBehaviour {
    
    // Start is called before the first frame update
    [SerializeField]
    
    protected Camera cam;

    // Update is called once per frame
    protected void Update() {
        
        if (Input.OnMouseButtonDown(0)) {
            
            Vector2 MousePos = Input.mousePosition;
            Ray ray = cam.ScreenPointToRay(MousePos);

            RaycastHit rch;

            if (Physics.Raycast(ray, out rch)) {

                Debug.Log("Player Clicked On '" + rch.transform.name + "'");
            
            }
        
        }

    }

}
