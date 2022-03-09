using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{

  float timerValue = 0;
  [SerializeField]
  float timerMax = 3;

  [SerializeField]
  GameObject enemyPrefab;

  // Update is called once per frame
  void Update()
  {

    if (timerValue > 0)
    {
      timerValue -= Time.deltaTime;
    }

    if (timerValue <= 0)
    {
      Vector2 position = new Vector2(Random.Range(-8f, 8f), 6);

      Instantiate(enemyPrefab, position, Quaternion.identity);

      timerValue = timerMax;
    }

  }
}
