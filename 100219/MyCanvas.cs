using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100219
{
     public class MyCanvas
    {
        public const int MAX_WIDTH = 800;
        public const int MAX_HEIGHT = 600;
        private static int buttonIndex = 0;
        private static MyButton[] buttons = new MyButton[MaxButtons];
        private static int MaxButtons = 3;

        public static bool CreatNewButton(int x1, int y1, int x2, int y2)
        {
            bool result = false;

            Point topleft = new Point(x1, y1);
            Point bottomRight = new Point(x2, y2);

          
                if (buttonIndex < MaxButtons && topleft.GetX() < MAX_WIDTH && topleft.GetY() < MAX_HEIGHT && bottomRight.GetX() < MAX_WIDTH && bottomRight.GetY() < MAX_HEIGHT)
                {
                    buttons[buttonIndex] = new MyButton(topleft, bottomRight);
                    buttonIndex++;
                    result = true;
                }
            return result;
        }
        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            bool result;
            if (buttonNumber <= 0 || buttonNumber > buttonIndex)
            {
                result = false;
            }
            else
            {
                int newTopLeftX = buttons[buttonNumber].GetTopLeft().GetX() + x;
                int newTopLeftY = buttons[buttonNumber].GetTopLeft().GetY() + y;
                int newBottomRightX = buttons[buttonNumber].GetTopLeft().GetX() + x;
                int newBottomRightY = buttons[buttonNumber].GetTopLeft().GetY() + y;
                Point newTopleft = new Point(newTopLeftX, newTopLeftY);
                Point newBottomRight = new Point(newBottomRightX, newBottomRightY);
                buttons[buttonNumber] = new MyButton(newTopleft, newBottomRight);

                result = true;
            }
            return result;
        }
        public static bool DeleteLastButton()
        {

            bool result;
            if (buttonIndex == 0)
            {
                result = false;
            }
            else
            {
                buttonIndex--;
                result = true;
            }
            return result;
        }
        public static void ClearAllButton()
        {
            while (buttonIndex != 0)
            {
                buttonIndex--;
            }
        }
        public static int GetCurrentNumberOfButtons()
        {
            return buttonIndex;
        }
        public static int GetMaxNumberOfButtons()
        {
            return MaxButtons;
        }
        public static int GetMaxHeightOfAButtons()
        {
            int buttonMaxHeight = 0, result = 0;
            if (buttonIndex == 0)
            {
                result = 0;
            }
            else
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (buttons[i].GetHeight() > MAX_HEIGHT)
                    {
                        buttonMaxHeight = buttons[i].GetHeight();
                    }
                }
                result = buttonMaxHeight;
            }
            return result;
        }
        public static int GetMaxWidthOfAButtons()
        {
            int buttonMaxWidth = 0, result = 0;
            if (buttonIndex == 0)
            {
                result = 0;
            }
            else
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    if (buttons[i].GetWidth() > MAX_WIDTH)
                    {
                        buttonMaxWidth = buttons[i].GetWidth();
                    }
                }
                result = buttonMaxWidth;
            }
            return result;
        }
        public static bool isPointInsideAButton(int x, int y)
        {
            bool result = false;
            foreach (MyButton button in buttons)
            {
                if (x > button.GetTopLeft().GetX() && y < button.GetTopLeft().GetY() && x < button.GetBottomRight().GetX() && y > button.GetBottomRight().GetY())
                {
                    result = true;
                }
            }
            return result;
        }
        public static bool CheckIfAnyButtonsOverLapping()
        {
            bool result = false;
            for (int i = 0; i < buttons.Length; i++)
            {
                if (isPointInsideAButton(buttons[i].GetTopLeft().GetX(), buttons[i].GetTopLeft().GetY()) || isPointInsideAButton(buttons[i].GetBottomRight().GetX(), buttons[i].GetBottomRight().GetY()))
                {
                    result = true;
                }

            }
            return result;

        }
        public override string ToString()
        {
            return $"Max number of buttons: {MaxButtons} Current number of buttons : {buttonIndex} Max Height of button: {GetMaxHeightOfAButtons()} Max Width of button: {GetMaxWidthOfAButtons()} ";
        }
    }
}
