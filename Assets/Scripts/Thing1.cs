using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing1 : MonoBehaviour
{
  public GameEvent clickEvent;

  void OnMouseDown()
  {
    clickEvent.TriggerEvent(new Dictionary<string, object> { { "bingo", Random.Range(1, 20) } });
  }
}
