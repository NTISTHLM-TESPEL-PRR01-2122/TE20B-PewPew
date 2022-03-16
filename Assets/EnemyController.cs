using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
  [SerializeField]
  float speed = 2;

  [SerializeField]
  GameObject explosionPrefab;

  // Update is called once per frame
  void Update()
  {
    Vector2 movement = Vector2.down * Time.deltaTime * speed;

    transform.Translate(movement);

    if (transform.position.y < -6)
    {
      Destroy(this.gameObject);
    }

  }

  void OnCollisionEnter2D(Collision2D other)
  {
    if (other.gameObject.tag == "Bullet")
    {
      Instantiate(explosionPrefab, transform.position, Quaternion.identity);
      Destroy(this.gameObject);
    }
  }

}
