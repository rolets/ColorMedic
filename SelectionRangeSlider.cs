﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace med
{
    /// <summary>
    /// Very basic slider control with selection range.
    /// </summary>
    [Description("Very basic slider control with selection range.")]
    public partial class SelectionRangeSlider : UserControl
    {
        /// <summary>
        /// Minimum value of the slider.
        /// </summary>
        [Description("Minimum value of the slider.")]
        public int ColorSheme
        {
            get { return colorSheme; }
            set { colorSheme = value; Invalidate(); }
        }
        int colorSheme = 1;

        /// <summary>
        /// Minimum value of the slider.
        /// </summary>
        [Description("Minimum value of the slider.")]
        public int Min
        {
            get { return min; }
            set { min = value; Invalidate(); }
        }
        int min = 0;
        /// <summary>
        /// Maximum value of the slider.
        /// </summary>
        [Description("Maximum value of the slider.")]
        public int Max
        {
            get { return max; }
            set { max = value; Invalidate(); }
        }
        int max = 100;
        /// <summary>
        /// Minimum value of the selection range.
        /// </summary>
        [Description("Minimum value of the selection range.")]
        public int SelectedMin
        {
            get { return selectedMin; }
            set
            {
                if (value > Min)
                    selectedMin = value;
                else
                    selectedMin = Min;

                //selectedMin = value;
                if (SelectionChanged != null)
                    SelectionChanged(this, null);
                Invalidate();
            }
        }
        int selectedMin = 0;
        /// <summary>
        /// Maximum value of the selection range.
        /// </summary>
        [Description("Maximum value of the selection range.")]
        public int SelectedMax
        {
            get { return selectedMax; }
            set
            {
                if (value<Max)
                selectedMax = value;
                else
                    selectedMax = Max;
                if (SelectionChanged != null)
                    SelectionChanged(this, null);
                Invalidate();
            }
        }
        int selectedMax = 100;
        /// <summary>
        /// Current value.
        /// </summary>
        //[Description("Current value.")]
        //public int Value
        //{
        //    get { return value; }
        //    set
        //    {
        //        this.value = value;
        //        if (ValueChanged != null)
        //            ValueChanged(this, null);
        //        Invalidate();
        //    }
        //}
        //int value = 50;
    /// <summary>
    /// Fired when SelectedMin or SelectedMax changes.
    /// </summary>
    [Description("Fired when SelectedMin or SelectedMax changes.")]
        public event EventHandler SelectionChanged;
        /// <summary>
        /// Fired when Value changes.
        /// </summary>
        [Description("Fired when Value changes.")]
        public event EventHandler ValueChanged;

        public SelectionRangeSlider()
        {
            InitializeComponent();
            //avoid flickering
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            Paint += new PaintEventHandler(SelectionRangeSlider_Paint);
            MouseDown += new MouseEventHandler(SelectionRangeSlider_MouseDown);
            MouseMove += new MouseEventHandler(SelectionRangeSlider_MouseMove);
        }

        void SelectionRangeSlider_Paint(object sender, PaintEventArgs e)
        {
            //paint background in white
            e.Graphics.FillRectangle(Brushes.White, ClientRectangle);
            //paint selection range in blue
            Rectangle selectionRect = new Rectangle(
                (selectedMin - Min) * Width / (Max - Min),
                0,
                (selectedMax - selectedMin) * Width / (Max - Min),
                Height);


            if (colorSheme == 1)
            {

                LinearGradientBrush br = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Black, 0, false);
                ColorBlend cb = new ColorBlend();
                cb.Positions = new[] { 0, 1 / 8f, 2 / 8f, 3 / 8f, 4 / 8f, 5 / 8f, 6 / 8f, 7 / 8f, 1 };
                cb.Colors = new[] { Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Indigo, Color.Violet, Color.Red };
                br.InterpolationColors = cb;
                // rotate
                br.RotateTransform(0);

                e.Graphics.FillRectangle(br, selectionRect);
            }
            else
            {
                Brush b = new LinearGradientBrush(ClientRectangle, Color.Black, Color.White, LinearGradientMode.Horizontal);
                e.Graphics.FillRectangle(b, selectionRect);
            }
            //draw a black frame around our control
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);


            //draw a simple vertical line at the Value position
            //e.Graphics.DrawLine(Pens.Black,
            //    (Value - Min) * Width / (Max - Min), 0,
            //    (Value - Min) * Width / (Max - Min), Height);
        }

        void SelectionRangeSlider_MouseDown(object sender, MouseEventArgs e)
        {
            //check where the user clicked so we can decide which thumb to move
            int pointedValue = Min + e.X * (Max - Min) / Width;
            //int distValue = Math.Abs(pointedValue - Value);
            int distMin = Math.Abs(pointedValue - SelectedMin);
            int distMax = Math.Abs(pointedValue - SelectedMax);
           // int minDist = Math.Min(distValue, Math.Min(distMin, distMax));
            //if (minDist == distValue)
           //     movingMode = MovingMode.MovingValue;
           // else 
            if (distMin< distMax)
                movingMode = MovingMode.MovingMin;
            else
                movingMode = MovingMode.MovingMax;
            //call this to refreh the position of the selected thumb
            SelectionRangeSlider_MouseMove(sender, e);
        }

        void SelectionRangeSlider_MouseMove(object sender, MouseEventArgs e)
        {
            //if the left button is pushed, move the selected thumb
            if (e.Button != MouseButtons.Left)
                return;
            int pointedValue = Min + e.X * (Max - Min) / Width;
            //if (movingMode == MovingMode.MovingValue)
            //    Value = pointedValue;
            //else 
            if (movingMode == MovingMode.MovingMin)
                SelectedMin = pointedValue;
            else if (movingMode == MovingMode.MovingMax)
                SelectedMax = pointedValue;
        }

        /// <summary>
        /// To know which thumb is moving
        /// </summary>
        enum MovingMode { MovingValue, MovingMin, MovingMax }
        MovingMode movingMode;
    }
}
