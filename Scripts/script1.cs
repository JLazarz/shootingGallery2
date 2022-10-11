using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour {
    //INSTATIATING OBJECTS
    [SerializeField]
    protected Transform prefab; 
    
    protected void Start() {
        
        Transform newItem = Instantiate(prefab);

        newItem.position = new Vector3(4,4,4);

        float score = 0;

        string name = "words";

        int meaning = 42;

        meaning = meaning + 42 + 10f;

        float newScore = score + 2.5f;

        int betterScore = score + 3.5f;

        list.Add(3.14159);
        list.Add(42);
        list.RemoveAt(0);

    }   

    // Update is called once per frame
    protected void Update() {
        
        float forward = Input.GetAxis("Vertical");

        bool jump = Input.GetKeyDown(KeyCode.Space);

        jump = Input.GetButtonDown("jump");

        bool fire = Input.GetMouseButtonDown(0);
    }

    
}
