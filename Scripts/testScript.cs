using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour {
    
    [SerializeField]
    
    protected Camera cam;
    
    [SerializeField]

    private GameObject[] cubeArray;
    
    private List<Vector3> pos;

    [SerializeField]
    
    public GameObject prefab;

    public int cubeAmount = 1;

    bool  isPaused;

    public int score = 0;

    protected void Start() {
        
        pos = new List<Vector3>();

        for (int j = 0; j < cubeArray.Length; j++){
            pos.Add(cubeArray[j].transform.position);
        }
    }
    
    protected void resetPos() {
     for (int y = 0; y < cubeAmount; y++) {
        for (int x = 0; x < cubeAmount; x++) {
             Instantiate(prefab, new Vector3(Random.Range(-10.0f, 10.0f), 15, 2), Quaternion.identity);
         }
     }
 }
    protected void Update() {
        
        if (Input.GetMouseButton(0)) {
            
            Vector2 MousePos = Input.mousePosition;
            
            Ray ray = cam.ScreenPointToRay(MousePos);
            
            RaycastHit rch;

            if (Physics.Raycast(ray, out rch)) {

                Debug.Log("Player Clicked On '" + rch.transform.name + "'");
                Destroy(rch.transform.gameObject);
                resetPos();
                scoreScript.scoreValue += 1;
            }
        }

        //if (Input.GetKeyDown(KeyCode.Escape)) {
         //   Time.timeScale = 0;
        //}

        //if (Input.GetKeyUp(KeyCode.Escape)) {
            //Time.timeScale = 1;
        //}

        if (Input.GetKeyDown(KeyCode.Escape)) {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0 : 1;
        }
    }
    
    protected void OnTriggerEnter(Collider c) {
        //THIS WILL MAKE BALL DISAPPEAR WHEN TOUCHING BARRIER
        c.gameObject.SetActive(false);

        bool success = disableObject(c.gameObject);   
       
        Debug.Log("Trigger Entered! And there was much rejoicing yay!");
        resetPos();

    }

    protected void OnCollisionEnter(Collision c) {
        //THIS IS FOR THING TO HIT EACOTHER TURN OFF "IS TRIGGER"
        Debug.Log("Collision Detected!");
    }

    protected bool disableObject(GameObject obj) {
        
        if (obj == null) return false;

        obj.SetActive(false);

        return true;

    }
}
