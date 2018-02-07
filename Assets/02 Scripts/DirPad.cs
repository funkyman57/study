using UnityEngine;
using UnityEngine.EventSystems;

public class DirPad : EventTrigger
{
    private Vector2 startPosition;
    public bool dragging { get; private set; }
    private Vector2 CurrentPosition;
    public Vector2 dir { get { return CurrentPosition - startPosition; } }

    private void Start()
    {
        Debug.Log("start dirpad");
    }

    public override void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("xx");
        base.OnBeginDrag(eventData);
        startPosition = eventData.position;
        dragging = true;
    }

    public override void OnDrag(PointerEventData eventData)
    {
        base.OnDrag(eventData);
        CurrentPosition = eventData.position;

    }

    public override void OnEndDrag(PointerEventData eventData)
    {
        base.OnEndDrag(eventData);
        dragging = false;
    }

    private void Update()
    {
        //Debug.LogFormat("Dragging  = {0}, Dir = {1}", dragging, dir);
    }
}
