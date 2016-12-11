using UnityEngine;
using System.Collections;

public class CollisionCheck : MonoBehaviour {

    private Animator anim;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {

	}

    void OnTriggerStay(Collider Col)
    {
        if (Col.tag == "Bar")
        {
            //event -> success
            Debug.Log("Collision Success: BAR");
            anim.SetBool("Next", true);
        }
    }
}
