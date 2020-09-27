using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    public static int Score = 0;


    //var rand = Random.Range(-4.5f, 4.5f);
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Animal")
        {
            Debug.Log("Animal Entered");  

            Score++;

            other.transform.position = new Vector3(Random.Range(0, 30), transform.position.y, Random.Range(-20, 20));

        }
        
    }

    void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 100, 40),"Score: " + Score.ToString() );
    }
}
