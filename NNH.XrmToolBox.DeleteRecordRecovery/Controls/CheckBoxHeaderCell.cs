﻿using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NNH.XrmToolBox.DeleteRecordRecovery.Controls
{
    public class CheckBoxHeaderCell : DataGridViewColumnHeaderCell
    {
        Size checkboxsize;
        bool ischecked;
        Point location;
        Point cellboundsLocation;
        CheckBoxState state = CheckBoxState.UncheckedNormal;

        public event CheckBoxHeaderClickHandler OnCheckBoxHeaderClick;

        public delegate void CheckBoxHeaderClickHandler(CheckBoxHeaderCellEventArgs e);

        public CheckBoxHeaderCell()
        {
            location = new Point();
            cellboundsLocation = new Point();
            ischecked = false;
        }

        protected override void OnMouseClick(DataGridViewCellMouseEventArgs e)
        {
            /* Make a condition to check whether the click is fired inside a checkbox region */
            Point clickpoint = new Point(e.X + cellboundsLocation.X, e.Y + cellboundsLocation.Y);

            if ((clickpoint.X > location.X && clickpoint.X < (location.X + checkboxsize.Width)) && (clickpoint.Y > location.Y && clickpoint.Y < (location.Y + checkboxsize.Height)))
            {
                ischecked = !ischecked;
                if (OnCheckBoxHeaderClick != null)
                {
                    OnCheckBoxHeaderClick(new CheckBoxHeaderCellEventArgs(ischecked));
                    this.DataGridView.InvalidateCell(this);
                }
            }
            base.OnMouseClick(e);
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds,
             Rectangle cellBounds, int rowIndex, DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle
            advancedBorderStyle, DataGridViewPaintParts paintParts)
        {

            base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState,
           value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts);

            checkboxsize = CheckBoxRenderer.GetGlyphSize(graphics, CheckBoxState.UncheckedNormal);
            location.X = cellBounds.X + (cellBounds.Width / 2 - checkboxsize.Width / 2);
            location.Y = cellBounds.Y + (cellBounds.Height / 2 - checkboxsize.Height / 2);
            cellboundsLocation = cellBounds.Location;

            if (ischecked)
                state = CheckBoxState.CheckedNormal;
            else
                state = CheckBoxState.UncheckedNormal;

            CheckBoxRenderer.DrawCheckBox(graphics, location, state);


        }
    }
}
