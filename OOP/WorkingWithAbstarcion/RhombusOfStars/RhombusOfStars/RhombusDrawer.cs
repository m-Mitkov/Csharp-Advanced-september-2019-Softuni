using System;
using System.Collections.Generic;
using System.Text;

namespace RhombusOfStars
{
    class RhombusDrawer
    {
        public string Draw(int countOfStars)
        {
            StringBuilder result = new StringBuilder();
            this.DrawTopPart(result, countOfStars);
            this.DrawBottomPart(result, countOfStars);

            return result.ToString();
       }
        private void DrawTopPart(StringBuilder result, int countOfStars)
        {
            for (int i = 1; i <= countOfStars; i++)
            {
                result.Append(new string(' ', countOfStars - i));
                DrawLIneOfStars(result, i);

            }
        }

        private void DrawBottomPart(StringBuilder result, int countOfStars)
        {
            for (int i = countOfStars - 1; i >= 1; i--)
            {
                result.Append(new string(' ', countOfStars - i));

                DrawLIneOfStars(result, i);
            }
        }
        private void DrawLIneOfStars(StringBuilder result, int countStars)
        {
            for (int star = 0; star < countStars; star++)
            {
                result.Append('*');

                if (star < countStars)
                {
                    result.Append(' ');
                }
            }

            result.AppendLine();
        }
    }
}

