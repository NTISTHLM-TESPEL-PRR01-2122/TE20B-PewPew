using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField]
  float speed = 3;

  [SerializeField]
  GameObject boltPrefab;

  [SerializeField]
  Transform gunPosition;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

    // Läs in input
    float axisX = Input.GetAxisRaw("Horizontal");
    float axisY = Input.GetAxisRaw("Vertical");

    // Flytta baserat på input
    Vector2 movement = new Vector2(axisX, axisY) * Time.deltaTime * speed;

    transform.Translate(movement);

    if (Input.GetAxisRaw("Fire1") > 0)
    {
      Instantiate(boltPrefab, gunPosition.position, Quaternion.identity);
    }


  }
}
