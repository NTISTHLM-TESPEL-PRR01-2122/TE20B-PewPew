using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltController : MonoBehaviour
{

  [SerializeField]
  float speed = 2;

  // Update is called once per frame
  void Update()
  {
    Vector2 movement = Vector2.up * Time.deltaTime * speed;

    transform.Translate(movement);

    if (transform.position.y > 3)
    {
      Destroy(this.gameObject);
    }
  }
}
