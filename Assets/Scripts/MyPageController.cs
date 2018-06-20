using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPageController : MonoBehaviour
{
    private BookGestureListener gestureListener;
    public AutoFlip autoFlip;

    private void Start()
    {
        // hide mouse cursor
        Cursor.visible = false;

        // get the gestures listener
        gestureListener = BookGestureListener.Instance;
    }

    private void Update()
    {
        if (!gestureListener)
            return;


        if (Input.GetKeyDown(KeyCode.PageDown))
        autoFlip.FlipRightPage();
        else if (Input.GetKeyDown(KeyCode.PageUp))
            autoFlip.FlipLeftPage();

        if (gestureListener)
            if (gestureListener.IsSwipeLeft())
                autoFlip.FlipRightPage();
            else if (gestureListener.IsSwipeRight())
                autoFlip.FlipLeftPage();
    }
}