using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thing2 : MonoBehaviour
{
  public void HolyShitIHeardThing1GotClicked(Dictionary<string, object> data = null)
  {
    Debug.Log("Holy shit I heard thing 1 got clicked\nMy number is now " + (data == null ? "?????" : (int)data?["bingo"]));
    //move a random direction by 2 units
    Vector2 direction = Random.insideUnitCircle;
    transform.position = transform.position + new Vector3(direction.x, direction.y, 0);
  }
}
