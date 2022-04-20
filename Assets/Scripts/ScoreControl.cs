using UnityEngine;
using UnityEngine.EventSystems;
public class ScoreControl : MonoBehaviour
{
    public EventTrigger.TriggerEvent scoreTrigger;

    private void OnCollisionEnter(Collision collision)
    {
        BallControl ball = collision.gameObject.GetComponent<BallControl>();
        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            this.scoreTrigger.Invoke(eventData);
        }
    }
}