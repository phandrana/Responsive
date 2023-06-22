using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Setup
{
	public static int LINE = 5;
	public static int COLUMN = 12;

	public static float WIDTH;
	public static float HEIGHT;

	public static GameObject CELL;
	public static float CELL_WIDTH;
	public static float CELL_HEIGHT;

	public static void Initialize()
	{
		HEIGHT = Camera.main.orthographicSize * 2f;
		WIDTH = HEIGHT * Camera.main.aspect;

		CELL = (GameObject)Resources.Load("Cell");

		Rect oCellRect = CELL.GetComponent<SpriteRenderer>().sprite.rect;
		float fPixelPerUnit = CELL.GetComponent<SpriteRenderer>().sprite.pixelsPerUnit;

		CELL_WIDTH = oCellRect.width / fPixelPerUnit;
		CELL_HEIGHT = oCellRect.height / fPixelPerUnit;
	}
}
