using UnityEngine;
using System.Collections;

public class doorcontroller : MonoBehaviour 
{

	public Animator animator;
	public Rect openDoorRectangle;
	public Rect closeDoorRectangle;

	void OnGUI () 
	{

		if(GUI.Button (openDoorRectangle, "Open Door")) 
		{

			animator.SetInteger ("Door Close", 0);
			animator.SetInteger ("Door OPen", 1);
		}

		if(GUI.Button (closeDoorRectangle, "Close Door"))
		{
			animator.SetInteger ("Door Close", 1);
			animator.SetInteger ("Door OPen", 0);

				}
			}
		}	
