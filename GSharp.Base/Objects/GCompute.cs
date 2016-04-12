﻿using GSharp.Base.Cores;

namespace GSharp.Base.Objects
{
    public class GCompute : GObject
    {
        #region 속성
        public GObject FirstPart { get; set; }

        public GObject SecondPart { get; set; }

        public OperatorType Operator { get; set; }
        #endregion

        #region 열거형
        public enum OperatorType
        {
            PLUS,
            MINUS,
            MULTIPLY,
            DIVISION,
            MODULO
        }
        #endregion

        #region 생성자
        public GCompute(GObject firstPart, OperatorType operatorType, GObject secondPart)
        {
            FirstPart = firstPart;
            SecondPart = secondPart;
            Operator = operatorType;
        }
        #endregion

        public override string ToSource()
        {
            string operatorText = string.Empty;
            switch (Operator)
            {
                case OperatorType.PLUS:
                    operatorText = "+";
                    break;

                case OperatorType.MINUS:
                    operatorText = "-";
                    break;

                case OperatorType.MULTIPLY:
                    operatorText = "*";
                    break;

                case OperatorType.DIVISION:
                    operatorText = "/";
                    break;

                case OperatorType.MODULO:
                    operatorText = "%";
                    break;
            }

            return string.Format
                (
                    "({0} {1} {2})",
                    FirstPart.ToSource(),
                    operatorText,
                    SecondPart.ToSource()
                );
        }
    }
}
