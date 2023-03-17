using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectDetection : MonoBehaviour
{
    public TextMeshProUGUI numberPoints;
    public GameObject player;
    Vector3 respawnPosition;
    int point = -1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        point++;
        numberPoints.text = point.ToString();
        if(point >= 1)
        {
            respawnPosition.Set(Random.Range(-90, 90), 20, Random.Range(-90, 90));
            player.transform.position = respawnPosition;
            Debug.Log("Collided!");
        }
        
    }
}