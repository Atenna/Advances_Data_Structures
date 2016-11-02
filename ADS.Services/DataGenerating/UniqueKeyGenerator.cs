using System;

namespace ADS.Services.DataGenerating
{
    public class UniqueKeyGenerator
    {
        private int _group = 0;
        private int _editor = 0;
        private Random rnd = new Random();

        public int GenerateEditorCode()
        {
            _editor = rnd.Next(1000000) + 10;
            return _editor;
        }

        public int GenerateGroupCode()
        {
            _group = rnd.Next(100);
            return _group;
        }
    }
}
