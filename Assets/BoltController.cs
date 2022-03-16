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

    if (transform.position.y > 6)
    {
      Destroy(this.gameObject);
    }
  }

  void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.tag == "Enemy")
    {
      Destroy(this.gameObject);
    }
  }
}
