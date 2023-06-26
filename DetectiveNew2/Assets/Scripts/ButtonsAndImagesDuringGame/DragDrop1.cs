using UnityEngine; using UnityEngine.EventSystems;
public class DragDrop1 : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler {
    [SerializeField] private Canvas canvas;
    private RectTransform rectTransform; private CanvasGroup CanvasGroup; public bool idle = true; 
    private void Awake() { rectTransform = GetComponent<RectTransform>(); CanvasGroup = GetComponent<CanvasGroup>(); }
    public void OnBeginDrag(PointerEventData eventData) { CanvasGroup.alpha = .6f; CanvasGroup.blocksRaycasts = false;  idle = false;
        this.GetComponent<MoveBookMatches>().Moving(); }
    public void OnDrag(PointerEventData eventData) { rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; }
    public void OnEndDrag(PointerEventData eventData) { CanvasGroup.alpha = 1f; CanvasGroup.blocksRaycasts = true; idle = true; }
    public void OnPointerDown(PointerEventData eventData)  { /*Debug.Log("OnPointerDown");*/ }
    public void OnDrop(PointerEventData eventData) { /*Debug.Log("OnDrop"); */}
}