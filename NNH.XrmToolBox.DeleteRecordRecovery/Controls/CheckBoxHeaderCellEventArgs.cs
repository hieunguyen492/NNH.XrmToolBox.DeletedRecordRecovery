namespace NNH.XrmToolBox.DeleteRecordRecovery.Controls
{
    public class CheckBoxHeaderCellEventArgs
    {
        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
        }

        public CheckBoxHeaderCellEventArgs(bool _checked)
        {
            _isChecked = _checked;

        }
    }
}
