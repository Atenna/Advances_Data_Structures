using System.Collections;
using System.Collections.Generic;

namespace ADS.ADS.Data.Library
{
    public class Editor
    {
        public class IsbnComparer : IComparer<Editor>
        {
            public int Compare(Editor x, Editor y)
            {
                if (x.EditorCode > y.EditorCode)
                {
                    return 1;
                }
                if (x.EditorCode < y.EditorCode)
                {
                    return -1;
                }
                return 0;
            }
        }

        public int EditorCode { get; }
        public string EditorName { get; }
        public int GroupCode { get; }
        public int Published { get; private set; }

        public Editor(int code, int group, string name)
        {
            EditorCode = code;
            GroupCode = group;
            EditorName = name;
            Published = 1;
        }

        public string GenerateIsbn()
        {
            string code = "978-" + GroupCode + "-" + EditorCode + "-" + PublishedWithZeros() + CheckSum();
            Published++;
            return code;
        }

        private string PublishedWithZeros()
        {
            int length = 3 + GroupCode.ToString().Length + EditorCode.ToString().Length + Published.ToString().Length;
            string publishedWithZeros = "";
            for (int i = 0; i < 12-length; i++)
            {
                publishedWithZeros += "0";
            }
            return publishedWithZeros + Published;
        }

        private int CheckSum()
        {
            int checksum = 0;
            int value = 1;
            string groupCode = GroupCode.ToString();
            foreach (var letter in groupCode)
            {
                var number = int.Parse(letter.ToString());
                checksum += number*value;
                value = value == 1 ? 3 : 1;
            }
            string editorCode = EditorCode.ToString();
            foreach (var letter in editorCode)
            {
                var number = int.Parse(letter.ToString());
                checksum += number * value;
                value = value == 1 ? 3 : 1;
            }
            string published = Published.ToString();
            foreach (var letter in editorCode)
            {
                var number = int.Parse(letter.ToString());
                checksum += number * value;
                value = value == 1 ? 3 : 1;
            }
            return checksum = 10 - (checksum%10);
        }
    }
}
