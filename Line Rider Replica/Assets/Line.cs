using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour {

	public LineRenderer lineRenderer;
	public EdgeCollider2D edgeCol;

	List<Vector2> points;

	public void UpdateLine (Vector2 mousePos)
	{
		if (points == null)
		{
			points = new List<Vector2>();
			SetPoint(mousePos);
			return;
		}

		if (Vector2.Distance(points.Last(), mousePos) > .1f)
			SetPoint(mousePos);
	}

	void SetPoint (Vector2 point)
	{
		points.Add(point);

		lineRenderer.numPositions = points.Count;
		lineRenderer.SetPosition(points.Count - 1, point);

		if (points.Count > 1)
			edgeCol.points = points.ToArray();
	}

}
