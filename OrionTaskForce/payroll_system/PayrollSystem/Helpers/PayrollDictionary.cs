using System.Collections.Generic;

namespace PayrollSystem.Helpers
{
    public static class PayrollDictionary
    {
        private static Dictionary<int, string> _cutoffDictionary;

        public static Dictionary<int, string> CutoffDictionary()
        {
            if (_cutoffDictionary == null)
            {
                _cutoffDictionary = new Dictionary<int, string>();
                _cutoffDictionary.Add(0, "");
                _cutoffDictionary.Add(1, "1st Cutoff (1-15)");
                _cutoffDictionary.Add(2, "2nd Cutoff (16-30)");
                _cutoffDictionary.Add(3, "All Cutoffs");
            }

            return _cutoffDictionary;
        }
    }
}