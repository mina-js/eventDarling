using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GameEventListener : MonoBehaviour
{
  public GameEvent gameEvent;
  public UnityEvent<Dictionary<string, object>> onEventTriggered;

  void OnEnable()
  {
    gameEvent.AddListener(this);
  }

  void OnDisable()
  {
    gameEvent.RemoveListener(this);
  }

  public void OnEventTriggered(Dictionary<string, object> data = null)
  {
    onEventTriggered.Invoke(data);
  }
}