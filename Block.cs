# Block_Dodge_Game

using UnityEngine;
using System.Collections;

public class Block : MonoBehaviour
  {
      void Start()
      {
         GetComponent<Rigidbody2D>().gravityScale += Time.timeSinceLevelLoad / 20f;

      }
	
	
  	void Update ()
      {
         if (transform.position.y < -2f)
          {
              Destroy(gameObject); 
           }
	
  }


}
