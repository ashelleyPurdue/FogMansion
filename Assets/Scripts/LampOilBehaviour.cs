using UnityEngine;
using System.Collections;

public class LampOilBehaviour : MonoBehaviour {

    public float distanceBonus = 10f;

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter(Collision col)
    {
        //If it's the player, add to the distance
        PlayerBehaviour player = col.gameObject.GetComponent<PlayerBehaviour>();
        if (player != null)
        {
            //Add to the distance
            player.myFog.distance += distanceBonus;

            //Destroy this
            GameObject.Destroy(this.gameObject);
        }
    }
}
