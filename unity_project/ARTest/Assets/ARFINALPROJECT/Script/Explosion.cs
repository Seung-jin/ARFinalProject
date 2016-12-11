using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

    public GameObject house;
    public GameObject explosion;
    public GameObject fire;

    private Object booming;
    private Object burning;
    private bool check_first = true;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnTriggerEnter(Collider Col)
    {
        if (Col.tag == "Bar")
        {
            if (check_first)
            {
                booming = Instantiate(explosion, house.transform.position, house.transform.rotation);
                burning = Instantiate(fire, house.transform.position, house.transform.rotation);

                Destroy(booming, 3f);
                Destroy(burning, 5f);

                check_first = false;
            }
        }
    }
}
