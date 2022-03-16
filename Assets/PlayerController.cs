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


  float cooldownValue = 0;

  [SerializeField]
  float cooldownMax = 1;

  bool fire1Released = true;

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
    Vector2 movementX = new Vector2(axisX, 0) * Time.deltaTime * speed;
    Vector2 movementY = new Vector2(0, axisY) * Time.deltaTime * speed;

    transform.Translate(movementX + movementY);

    if (Mathf.Abs(transform.position.x) > 9)
    {
      transform.Translate(-movementX);
    }




    if (cooldownValue > 0)
    {
      cooldownValue -= Time.deltaTime;
    }

    if (Input.GetAxisRaw("Fire1") > 0 && cooldownValue <= 0 && fire1Released)
    {
      Instantiate(boltPrefab, gunPosition.position, Quaternion.identity);
      cooldownValue = cooldownMax;
    }


    fire1Released = ! (Input.GetAxisRaw("Fire1") > 0);

  }
}
